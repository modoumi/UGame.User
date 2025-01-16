using StackExchange.Redis;
using AiUo.Data;
using AiUo.Data.SqlSugar;
using AiUo.Logging;
using AiUo.Text;
using UGame.User.Common;
using UGame.User.Common.Caching;
using UGame.User.Common.Services; 
using UGame.User.Repository;
using UGame.User.MQ.Xxyy;
using UGame.User.MQ.Bank;
using Xxyy.Common;

namespace UGame.User.Service.Flow
{
    public class FlowNoInheritingNoCompletedService : IFlowDealService
    {
        private S_provider_orderMO _provOrderMo = new();
        S_requireflow_orderMO requireFlowMo;
        S_appEO sappEo;
        UserService userSvc;
        V_s_operatorEO operatorInfo;
        GlobalUserDCache userDCache;
        public FlowNoInheritingNoCompletedService(string userId, string appId, string operatorId)
        {
            requireFlowMo = DbSink.BuildRequireFlowOrderMo(userId);
            userSvc = new UserService(userId);
            userDCache = new GlobalUserDCache(userId);
            sappEo = DbCacheUtil.GetApp(appId);
            operatorInfo = DbCacheUtil.GetOperator(operatorId);
        }
        public Task DealFlowWhenCurrencyChagne(CurrencyChangeReq req)
        {
            return Task.CompletedTask;
        }

        public async Task DealFlowWhenUserBet(UserBetMsg message)
        {
            if (message.CurrencyType != CurrencyType.Cash || (message.BetType == 1) || (message.BetType == 4 && message.ReferOrderIds.Count < 1))
                return;

            TransactionManager tm = new TransactionManager();
            try
            {
                //s_requireflow_order
                var currBonus = await userSvc.GetBonus(tm);//当前账户的Bonus总额


                //rollBack
                if (message.BetType == 4 && (message.WinAmount < 0 || message.BetAmount < 0))
                {
                    await HandleRollBack(message, requireFlowMo, tm);
                }
                else
                {
                    #region 重新计算bet和win
                    if (!string.IsNullOrEmpty(message.RoundId) && !message.RoundClosed) { return; }
                    var referProviderOrders = new List<S_provider_orderEO>();
                    if (!string.IsNullOrEmpty(message.RoundId))
                    {
                        referProviderOrders = await _provOrderMo.GetAsync("UserID=@userId and AppID=@appId and ProviderID=@providerId and RoundId=@roundId",
                            message.UserId, message.AppId, message.ProviderId, message.RoundId);
                        if (referProviderOrders == null || !referProviderOrders.Any()) return;
                    }
                    else
                    {
                        if (message.BetType == 2 && (message.ReferOrderIds == null || !message.ReferOrderIds.Any())) { return; }
                        if (message.ReferOrderIds != null && message.ReferOrderIds.Any())
                        {
                            var providerOrderIds = string.Join("','", message.ReferOrderIds); 
                            referProviderOrders = await _provOrderMo.GetAsync($"OrderID in ('{providerOrderIds}')");
                            //foreach (var _referOrderId in message.ReferOrderIds)
                            //{
                            //    var _curProvOrder = await _provOrderMo.GetByPKAsync(_referOrderId);
                            //    if (_curProvOrder != null)
                            //    {
                            //        referProviderOrders.Add(_curProvOrder);
                            //    }
                            //}
                        }
                    }

                    if (referProviderOrders.Any())
                    {
                        message.BetAmount = referProviderOrders.Sum(p => p.PlanBet);
                        message.BetBonus = referProviderOrders.Sum(p => p.BetBonus);
                        message.WinAmount = referProviderOrders.Sum(p => p.PlanWin);
                        message.WinBonus = referProviderOrders.Sum(p => p.WinBonus);
                    }

                    #endregion

                    if (message.BetAmount <= 0 || message.BetBonus > message.BetAmount) return;//下注金额不合法，直接返回

                    var toUpdateOrderList = new List<S_requireflow_orderEO>();
                    tm = tm == null ? new TransactionManager() : tm;
                    //var currBonus = await userSvc.GetBonus();//当前账户的Bonus总额
                    var _totalFlow = (long)(message.BetBonus * (decimal)sappEo.FlowRatio);
                    var orderList = await requireFlowMo.GetSortAsync($"UserID='{message.UserId}' and Status=0", "RecDate asc", tm);
                    if (orderList != null && orderList.Any())
                    {
                        await AccumulateFlow(orderList, _totalFlow, currBonus, toUpdateOrderList);
                    }

                    if (toUpdateOrderList.Count > 0 && await requireFlowMo.PutAsync(toUpdateOrderList, tm) < 1)
                        throw new Exception("Bet、Win后扣减流水订单中的bonus和真金失败");
                }

                tm.Commit();
            }
            catch (Exception)
            {
                tm.Rollback();
                throw;
            }
        }

        #region 流水相关私有方法【不区分Bonus和真金时，继承流水】

        /// <summary>
        /// 累计流水
        /// </summary>
        /// <param name="orderList"></param>
        /// <param name="flowAmount"></param>
        /// <param name="currBonus"></param>
        /// <param name="toUpdateList"></param>
        /// <returns></returns>
        private async Task<long> AccumulateFlow(List<S_requireflow_orderEO> orderList, long flowAmount, long currBonus, List<S_requireflow_orderEO> toUpdateList)
        {
            var _remainFlow = flowAmount;
            foreach (var _order in orderList)
            {
                _order.UpdateTime = DateTime.UtcNow;
                _order.EndBonus = currBonus;
                var _logInfo = $"【增加流水】用户Id：{_order.UserID},流水订单号：{_order.OrderID},所需完成的流水:{_order.RequireFlow},之前已完成的流水:{_order.CompletedFlow}";//本次流水计算日志

                if (_remainFlow > 0)
                {
                    var planCompleteFlow = _order.CompletedFlow + _remainFlow;
                    if (planCompleteFlow <= _order.RequireFlow)
                    {
                        _logInfo += $",本次增加流水:{_remainFlow}";
                        _order.CompletedFlow = planCompleteFlow;
                        if (planCompleteFlow == _order.RequireFlow)
                        {
                            _order.Status = 1;
                            _logInfo += ",流水完成";
                        }
                        toUpdateList.Add(_order);
                        _remainFlow = 0;
                        LogUtil.Debug(_logInfo);
                        break;
                    }
                    else
                    {
                        _logInfo += $",本次增加流水:{_order.RequireFlow - _order.CompletedFlow},流水完成";
                        _order.CompletedFlow = _order.RequireFlow;
                        _order.Status = 1;
                        _remainFlow = planCompleteFlow - _order.RequireFlow;//仍然有溢出流水
                        toUpdateList.Add(_order);
                    }
                }
                LogUtil.Debug(_logInfo);
            }
            return _remainFlow;
        }

        #endregion

        public async Task DealFlowWhenUserPay(UserPayMsg message)
        {
            try
            {
                var cashFlowMultip = message.IsFirst
                    ? operatorInfo.FirstPayFlowMultip
                    : operatorInfo.PayFlowMultip;//充值的流水倍数
                if (cashFlowMultip <= 0) return;

                var balanceInfo = await userSvc.GetBalanceInfo();
                var requireFlowEo = new S_requireflow_orderEO
                {
                    OrderID = ObjectId.NewId(),
                    ProviderID = null,
                    AppID = null,
                    OperatorID = message.OperatorId,
                    UserID = message.UserId,
                    UserKind = (int)await userDCache.GetUserKindAsync(),
                    CountryID = await userDCache.GetCountryIdAsync(),
                    CurrencyID = message.CurrencyId,
                    CurrencyType = (int)DbCacheUtil.GetCurrencyType(message.CurrencyId),
                    IsBonus = false,
                    FlowMultip = cashFlowMultip,
                    OrderAmount = message.PayAmount,
                    OrderRemain = message.PayAmount,
                    RequireFlow = message.PayAmount * cashFlowMultip,
                    EndBonus = balanceInfo.Bonus,
                    EndBalance = balanceInfo.Balance,
                    Status = 0,
                    RecDate = message.PayTime,
                    UpdateTime = message.PayTime,
                    SourceId = message.OrderID,
                    SourceTable = "sb_bank_order",
                    BonusSourceType = 400001,
                    BonusReason = "用户充值",
                    FromId = await userDCache.GetFromIdAsync(),
                    FromMode = await userDCache.GetFromModeAsync()
                };
                if (await requireFlowMo.AddAsync(requireFlowEo) < 1)
                    throw new Exception("FlowNoInheritingNoCompletedService充值消费端，新增流水订单时出错");
            }
            catch (Exception ex)
            {
                LogUtil.Error(ex, "FlowNoInheritingNoCompletedService充值消费端，计算流水订单时出错");
            }
        }

        #region 内部方法
        /// <summary>
        /// 回滚消息处理
        /// </summary>
        /// <returns></returns>
        private async Task HandleRollBack(UserBetMsg message, S_requireflow_orderMO requireFlowMo, TransactionManager tm)
        {
            if (message.BetType != 4) return;
            if (message.BetBonus < 0)
            {
                var rollbackBonus =(long)(message.BetBonus*sappEo.FlowRatio);
                if (rollbackBonus == 0) return;
                var requireFlowOrders = await requireFlowMo.GetTopSortAsync($"UserID='{message.UserId}' and Status=0", 1, "UpdateTime desc",tm);
                if (requireFlowOrders == null || requireFlowOrders.Count < 1) return;
                if (await requireFlowMo.PutAsync("CompletedFlow+=@rollbackBonus", "OrderID=@OrderID", tm,rollbackBonus, requireFlowOrders[0].OrderID) < 1)
                    throw new Exception("RollBack后更新最近一条未完成的bonus流水订单失败");
            }
        }

        #endregion
    }
}
