using EasyNetQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Data;
using AiUo.Logging;
using AiUo.Text;
using UGame.User.Common;
using UGame.User.Common.Caching;
using UGame.User.Common.Services;
using UGame.User.MQ.Xxyy;
using UGame.User.MQ.Bank;
using UGame.User.Repository;

namespace UGame.User.Service.Flow
{
    /// <summary>
    /// 累计流水，并继承未完成流水
    /// </summary>
    public class FlowInheritingNoCompletedService : InheritingCommonFlowService, IFlowDealService
    {

        public FlowInheritingNoCompletedService(string userId, string appId, string operatorId):base(userId,appId,operatorId)
        {
        }

        /// <summary>
        /// 用户下注时处理流水
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public async Task DealFlowWhenUserBet(UserBetMsg message)
        {
            await base.DealFlowWhenUserBet(message);
        }

        /// <summary>
        /// 用户充值时处理流水
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task DealFlowWhenUserPay(UserPayMsg message)
        {
            TransactionManager tm = new TransactionManager();
            var accumulativeFlow = 0L;//可以继承的流水

            try
            {
                var balanceInfo = await userSvc.GetBalanceInfo();
                var cashFlowMultip = message.IsFirst
                    ? operatorInfo.FirstPayFlowMultip
                    : operatorInfo.PayFlowMultip;//充值的流水倍数

                var hisRequireFlowOrders = await requireFlowMo.GetAsync("UserID=@userId and Status=0 and SourceId != @sourceId", message.UserId, message.OrderID);
                if (hisRequireFlowOrders != null && hisRequireFlowOrders.Any())
                {
                    if (message.PayBeforeAmount < operatorInfo.FlowBalance)
                    {
                        foreach (var order in hisRequireFlowOrders)
                        {
                            order.Status = 3;
                            order.UpdateTime = DateTime.UtcNow;
                        }
                    }
                    else
                    {
                        foreach (var order in hisRequireFlowOrders)
                        {
                            order.Status = 2;
                            order.UpdateTime = DateTime.UtcNow;
                            order.InheritFlow = order.RequireFlow - order.CompletedFlow;
                            order.InheritOrder = order.OrderRemain;
                            accumulativeFlow += order.RequireFlow - order.CompletedFlow;
                        }
                    }
                    if (await requireFlowMo.PutAsync(hisRequireFlowOrders, tm) < 1)
                        throw new Exception("充值消费端，继承流水时出错");
                }

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
                    RequireFlow = message.PayAmount * cashFlowMultip + accumulativeFlow,
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
                if (await requireFlowMo.AddAsync(requireFlowEo, tm) < 1)
                    throw new Exception("充值消费端，新增流水订单时出错");
                tm.Commit();
            }
            catch (Exception ex)
            {
                tm.Rollback();
                LogUtil.Error(ex, "充值消费端，计算流水订单时出错");
            }
        }

        /// <summary>
        /// 用户货币变化时流水处理
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public Task DealFlowWhenCurrencyChagne(CurrencyChangeReq req)
        {
            return Task.CompletedTask;
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
                    _remainFlow = _remainFlow <= 0 ? 0 : _remainFlow;
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

        protected async override Task UserBetExecute(UserBetMsg message, TransactionManager tm)
        {
            var toUpdateOrderList = new List<S_requireflow_orderEO>();
            tm = tm == null ? new TransactionManager() : tm;
            var currBonus = await userSvc.GetBonus(tm);//当前账户的Bonus总额
            var _totalFlow = (long)(message.BetAmount * (decimal)sappEo.FlowRatio);
            var orderList = await requireFlowMo.GetSortAsync($"UserID='{message.UserId}' and Status=0", "RecDate asc", tm);
            if (orderList != null && orderList.Any())
            {
                await AccumulateFlow(orderList, _totalFlow, currBonus, toUpdateOrderList);
            }

            if (toUpdateOrderList.Count > 0 && await requireFlowMo.PutAsync(toUpdateOrderList, tm) < 1)
                throw new Exception("Bet、Win后扣减流水订单中的bonus和真金失败");
        }
    }
}
