using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UGame.User.Common.Services;
using UGame.User.Common;
using AiUo.Data;
using AiUo.Text;
using UGame.User.Common.Caching;
using Google.Protobuf.WellKnownTypes;
using UGame.User.MQ.Xxyy;
using UGame.User.Repository;
using Xxyy.Common;

namespace UGame.User.Service.Flow
{
    public abstract class InheritingCommonFlowService
    {
        protected readonly S_provider_orderMO _provOrderMo = new();
        protected readonly S_requireflow_orderMO requireFlowMo;
        protected readonly S_appEO sappEo;
        protected readonly UserService userSvc;
        protected readonly V_s_operatorEO operatorInfo;
        protected readonly GlobalUserDCache userDCache;
        public InheritingCommonFlowService(string userId, string appId, string operatorId)
        {
            requireFlowMo = DbSink.BuildRequireFlowOrderMo(userId);
            userSvc = new UserService(userId);
            userDCache = new GlobalUserDCache(userId);
            sappEo = DbCacheUtil.GetApp(appId);
            operatorInfo = DbCacheUtil.GetOperator(operatorId);
        }
        protected abstract Task UserBetExecute(UserBetMsg message,TransactionManager tm);
        protected async Task DealFlowWhenUserBet(UserBetMsg message)
        {
            if (message.CurrencyType != CurrencyType.Cash || (message.BetType == 1) || (message.BetType == 4 && message.ReferOrderIds.Count < 1))
                return;

            var tm = new TransactionManager();
            try
            {
                //s_requireflow_order
                //UserService userSvc = new(message.UserId);
                //var requireFlowMo = DbSink.BuildRequireFlowOrderMo(message.UserId);
                var currBonus = await userSvc.GetBonus(tm);//当前账户的Bonus总额


                //rollBack
                if (message.BetType == 4 && (message.WinAmount < 0 || message.BetAmount < 0))
                {
                    await HandleRollBack(message, requireFlowMo, currBonus, tm);
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
                            foreach (var _referOrderId in message.ReferOrderIds)
                            {
                                var _curProvOrder = await _provOrderMo.GetByPKAsync(_referOrderId);
                                if (_curProvOrder != null)
                                {
                                    referProviderOrders.Add(_curProvOrder);
                                }
                            }
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

                    await UserBetExecute(message,tm);
                }

                tm.Commit();
            }
            catch (Exception)
            {
                tm.Rollback();
                throw;
            }
        }

        #region 内部方法
        /// <summary>
        /// 回滚消息处理
        /// </summary>
        /// <returns></returns>
        private async Task HandleRollBack(UserBetMsg message, S_requireflow_orderMO requireFlowMo, long currBonus, TransactionManager tm)
        {
            if (message.BetType != 4) return;
            var rollBackedOrder = await _provOrderMo.GetByPKAsync(message.ReferOrderIds[0]);//被回滚的订单
            if (rollBackedOrder == null) { return; }
            var userDCache = new GlobalUserDCache(message.UserId);
            if (message.BetBonus < 0 && Math.Abs(message.WinBonus) - Math.Abs(message.BetBonus) < 0)
            {
                var rollbackBonus = Math.Abs(Math.Abs(message.WinBonus) - Math.Abs(message.BetBonus));
                var requireFlowOrder = await requireFlowMo.GetTopSortAsync($"UserID='{message.UserId}' and IsBonus=1 ", 1, "UpdateTime desc");
                if (requireFlowOrder == null || requireFlowOrder.Count < 1) return;
                var orderEo = new S_requireflow_orderEO
                {
                    OrderID = ObjectId.NewId(),
                    ProviderID = rollBackedOrder.ProviderID,
                    AppID = rollBackedOrder.AppID,
                    OperatorID = message.OperatorId,
                    UserID = message.UserId,
                    UserKind = (int)await userDCache.GetUserKindAsync(),
                    CountryID = await userDCache.GetCountryIdAsync(),
                    CurrencyID = message.CurrencyId,
                    CurrencyType = (int)DbCacheUtil.GetCurrencyType(message.CurrencyId),
                    IsBonus = true,
                    FlowMultip = requireFlowOrder[0].FlowMultip,
                    OrderAmount = rollbackBonus,
                    OrderRemain = rollbackBonus,
                    RequireFlow = (long)(Math.Abs(message.BetBonus) * requireFlowOrder[0].FlowMultip),
                    EndBonus = currBonus + Math.Abs(message.BetBonus),
                    Status = requireFlowOrder[0].FlowMultip > 0 ? 0 : 1,
                    RecDate = DateTime.UtcNow,
                    EndBonusList = $"+{Math.Abs(message.BetBonus)}",
                    UpdateTime = DateTime.UtcNow,
                    BonusReason = "回滚",
                    BonusSourceType = requireFlowOrder[0].BonusSourceType
                };
                if (await requireFlowMo.AddAsync(orderEo, tm) < 1)
                    throw new Exception("RollBack后添加新的bonus流水订单失败");
            }
            if (Math.Abs(message.WinAmount) - Math.Abs(message.BetAmount) < 0)
            {
                var rollbackCash = Math.Abs(Math.Abs(message.WinAmount) - Math.Abs(message.BetAmount));

                if (Math.Abs(message.BetBonus) < Math.Abs(message.BetAmount))
                {
                    var _rollbackBonus = Math.Abs(Math.Abs(message.WinBonus) - Math.Abs(message.BetBonus));
                    rollbackCash = rollbackCash - _rollbackBonus;//去掉回滚金额中的bonus额度
                }
                var requireFlowOrder = await requireFlowMo.GetTopSortAsync($"UserID='{message.UserId}' and IsBonus=0 ", 1, "UpdateTime desc");
                if (requireFlowOrder == null || requireFlowOrder.Count < 1) return;
                var orderEo = new S_requireflow_orderEO
                {
                    OrderID = ObjectId.NewId(),
                    ProviderID = rollBackedOrder.ProviderID,
                    AppID = rollBackedOrder.AppID,
                    OperatorID = message.OperatorId,
                    UserID = message.UserId,
                    UserKind = (int)await userDCache.GetUserKindAsync(),
                    CountryID = await userDCache.GetCountryIdAsync(),
                    CurrencyID = message.CurrencyId,
                    CurrencyType = (int)DbCacheUtil.GetCurrencyType(message.CurrencyId),
                    IsBonus = false,
                    FlowMultip = requireFlowOrder[0].FlowMultip,
                    OrderAmount = rollbackCash,
                    OrderRemain = rollbackCash,
                    RequireFlow = (long)(rollbackCash * requireFlowOrder[0].FlowMultip),
                    EndBonus = currBonus + Math.Abs(message.BetBonus),
                    Status = requireFlowOrder[0].FlowMultip > 0 ? 0 : 1,
                    BonusReason = "回滚",
                    RecDate = DateTime.UtcNow,
                    UpdateTime = DateTime.UtcNow
                };
                if (await requireFlowMo.AddAsync(orderEo, tm) < 1)
                    throw new Exception("RollBack后添加新的真金流水订单失败");
            }
        }

        #endregion
    }
}
