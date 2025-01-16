using EasyNetQ;
using Google.Protobuf.WellKnownTypes;
using Newtonsoft.Json;
using Org.BouncyCastle.Ocsp;
using Org.BouncyCastle.Utilities;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.BIZ.RabbitMQ;
using AiUo.Data;
using AiUo.Data.MySql;
using AiUo.Extensions.RabbitMQ;
using AiUo.Logging;
using AiUo.Text;
using UGame.User.Service.Common;
using UGame.User.Service.Flow;
using UGame.User.Service.Caching;
using UGame.User.Common;
using UGame.User.Common.Caching;
using UGame.User.Common.Services; 
using UGame.User.MQ.Xxyy;
using UGame.User.Repository;
using Xxyy.Common;

namespace UGame.User.Service.MQConsumers
{
    public class UserBetMQSub : MQBizSubConsumer<UserBetMsg>
    {
        private UserExSummaryService _userExSvc = new();
        private S_provider_orderMO _provOrderMo = new();
        private UserDaySummaryService _userDaySvc = new();

        public override MQSubscribeMode SubscribeMode => MQSubscribeMode.OneQueue;

        public UserBetMQSub()
        {
            AddHandler(UpdateSUserEx);
            AddHandler(UpdateSUserDay);
        }

        /// <summary>
        /// 更新用户下注总额，返奖总额
        /// </summary>
        /// <param name="message"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        private async Task UpdateSUserEx(UserBetMsg message, CancellationToken cancellationToken)
        {
            //s_user_ex
            if (message.CurrencyType != CurrencyType.Cash)
                return;
            if (await _userExSvc.AddTotalBetWin(message.UserId, message.BetAmount, message.WinAmount, null) < 1)
                throw new Exception("Bet、Win或者Rollback后更新下注总额，返奖总额失败");
        }

        private async Task UpdateSUserDay(UserBetMsg message, CancellationToken cancellationToken)
        {
            // s_user_day
            if (message.CurrencyType != CurrencyType.Cash)
                return;

            var currTime = message.BetTime.ToLocalTime(message.OperatorId);
            await (await DayOperatorUserIdsDCache.Create(currTime, message.OperatorId, DayUserIdsType.Bet))
                .AddUserId(message.UserId);
            var userDayCache = await DayUserDCache.Create(currTime, message.UserId);
            var hasBet = await userDayCache.GetHasBet();
            if (!hasBet)
                await userDayCache.SetHasBet();
            if (message.IsFirst)
                await userDayCache.SetIsNewBet();

            // 统计下注
            if (message.BetType == 1 || message.BetType == 3)
                await userDayCache.IncrBetCount();
            if (message.BetAmount != 0)
                await userDayCache.AddBetAmount(message.BetAmount);
            if (message.BetBonus != 0)
                await userDayCache.AddBetBonus(message.BetBonus);
            // 统计返奖
            if (message.WinAmount != 0)
                await userDayCache.AddWinAmount(message.WinAmount);
            if (message.WinBonus != 0)
                await userDayCache.AddWinBonus(message.WinBonus);

            // 今天统计过退出
            if (hasBet)
                return;
            var userDCache = new GlobalUserDCache(message.UserId);
            await _userDaySvc.SetHasBet(new S_user_dayEO
            {
                DayID = currTime,
                UserID = message.UserId,
                UserKind = message.UserKind,
                OperatorID = message.OperatorId,
                CountryID = message.CountryId,
                CurrencyID = message.CurrencyId,
                FromId = await userDCache.GetFromIdAsync(),
                FromMode = await userDCache.GetFromModeAsync(),
            }, message.IsFirst);
        }


        /// <summary>
        /// 更新用户订单流水
        /// </summary>
        /// <param name="message"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        private async Task UpdateSRequireFlow(UserBetMsg message, CancellationToken cancellationToken)
        {
            //计算流水
            IFlowDealService flowService = FlowServiceFactory.CreateFlowService(message.UserId, message.AppId, message.OperatorId);
            await flowService.DealFlowWhenUserBet(message);
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

        protected override void Configuration(ISubscriptionConfiguration config)
        {
            
        }

        protected override Task OnMessage(UserBetMsg message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        #endregion
    }
}
