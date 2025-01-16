using EasyNetQ;
using Google.Protobuf.WellKnownTypes;
using Org.BouncyCastle.Ocsp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Extensions.RabbitMQ;
using UGame.User.Common.Caching;
using UGame.User.Common; 
using UGame.User.Common.Services;
using AiUo.Text;
using AiUo.Data;
using AiUo.Logging;
using AiUo.BIZ.RabbitMQ;
using UGame.User.Service.Common;
using UGame.User.Service.Flow;
using UGame.User.MQ.Bank;
using Xxyy.Common;
using UGame.User.Repository;

namespace UGame.User.Service.MQConsumers
{
    public class UserPayMQSub : MQBizSubConsumer<UserPayMsg>
    {
        private UserExSummaryService _userExSvc = new();
        private UserDaySummaryService _userDaySvc = new();

        public override MQSubscribeMode SubscribeMode => MQSubscribeMode.OneQueue;

        public UserPayMQSub()
        {
            AddHandler(UpdateSUserEx);
            AddHandler(UpdateSUserDay);
        }
        private async Task UpdateSUserEx(UserPayMsg message, CancellationToken cancellationToken)
        {
            if (DbCacheUtil.GetCurrencyType(message.CurrencyId) != CurrencyType.Cash)
                return;

            // s_user_ex => TotalPayAmount
            await _userExSvc.AddTotalPay(message.UserId, message.PayAmount, message.IsFirst, null);
        }

        private async Task UpdateSUserDay(UserPayMsg message, CancellationToken cancellationToken)
        {
            if (DbCacheUtil.GetCurrencyType(message.CurrencyId) != CurrencyType.Cash)
                return;

            var currTime = message.PayTime.ToLocalTime(message.OperatorId);
            await (await DayOperatorUserIdsDCache.Create(currTime, message.OperatorId, DayUserIdsType.Pay))
                .AddUserId(message.UserId);
            var userDayCache = await DayUserDCache.Create(currTime, message.UserId);
            var hasPay = await userDayCache.GetHasPay();
            if (!hasPay)
                await userDayCache.SetHasPay();
            if (message.IsFirst)
                await userDayCache.SetIsNewPay();
            await userDayCache.IncrPayCount();
            await userDayCache.AddPayAmount(message.PayAmount);

            if (hasPay)
                return;
            var userDCache = new GlobalUserDCache(message.UserId);
            await _userDaySvc.SetHasPay(new S_user_dayEO
            {
                DayID = currTime,
                UserID = message.UserId,
                UserKind = (int)message.UserKind,
                OperatorID = message.OperatorId,
                CountryID = message.CountryId,
                CurrencyID = message.CurrencyId,
                FromId = await userDCache.GetFromIdAsync(),
                FromMode = await userDCache.GetFromModeAsync()
            }, message.IsFirst);
        }

        private async Task AddRequireFlowOrder(UserPayMsg message, CancellationToken cancellationToken)
        {
            if (DbCacheUtil.GetCurrencyType(message.CurrencyId) != CurrencyType.Cash)
                return;

            //用户余额没变化时，不记录流水
            if (!message.IsAddBalance)
                return;

            // s_requireflow_order
            IFlowDealService flowService = FlowServiceFactory.CreateFlowService(message.UserId, message.AppId, message.OperatorId);
            await flowService.DealFlowWhenUserPay(message);
        }

        protected override void Configuration(ISubscriptionConfiguration config)
        {
        }

        protected override Task OnMessage(UserPayMsg message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
