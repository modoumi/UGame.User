using EasyNetQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.BIZ.RabbitMQ;
using AiUo.Extensions.RabbitMQ;
using UGame.User.Service.Common;
using UGame.User.Common;
using UGame.User.Common.Caching; 
using UGame.User.MQ.Bank;
using Xxyy.Common;
using UGame.User.Repository;

namespace UGame.User.Service.MQConsumers
{
    public class UserCashMQSub : MQBizSubConsumer<UserCashMsg>
    {
        private UserExSummaryService _userExSvc = new();
        private UserDaySummaryService _userDaySvc = new();

        public override MQSubscribeMode SubscribeMode => MQSubscribeMode.OneQueue;

        public UserCashMQSub()
        {
            AddHandler(UpdateSUserEx);
            AddHandler(UpdateSUerDay);
        }
        private async Task UpdateSUserEx(UserCashMsg message, CancellationToken cancellationToken)
        {
            if (message.Status==1)
                return;
            if (DbCacheUtil.GetCurrencyType(message.CurrencyId) != CurrencyType.Cash)
                return;
            // s_user_ex => TotalCashAmount
            await _userExSvc.AddTotalCash(message.UserId, message.CashAmount, null);
        }

        private async Task UpdateSUerDay(UserCashMsg message, CancellationToken cancellationToken)
        {
            if (message.Status==1)
                return;
            if (DbCacheUtil.GetCurrencyType(message.CurrencyId) != CurrencyType.Cash)
                return;

            var currTime = message.CashTime.ToLocalTime(message.OperatorId);
            await (await DayOperatorUserIdsDCache.Create(currTime, message.OperatorId, DayUserIdsType.Cash))
                .AddUserId(message.UserId);
            var userDayCache = await DayUserDCache.Create(currTime, message.UserId);
            var hasCash = await userDayCache.GetHasCash();
            if (!hasCash)
                await userDayCache.SetHasCash();
            if (message.IsFirst)
                await userDayCache.SetIsNewCash();
            await userDayCache.IncrCashCount();
            await userDayCache.AddCashAmount(message.CashAmount);

            if (hasCash)
                return;
            // s_user_day
            var userDCache = new GlobalUserDCache(message.UserId);
            await _userDaySvc.SetHasCash(new S_user_dayEO
            {
                DayID = currTime,
                UserID = message.UserId,
                UserKind = message.UserKind,
                OperatorID = message.OperatorId,
                CountryID = message.CountryId,
                CurrencyID = message.CurrencyId,
                FromId = await userDCache.GetFromIdAsync(),
                FromMode = await userDCache.GetFromModeAsync()
            }, message.IsFirst);
        }

        protected override void Configuration(ISubscriptionConfiguration config)
        {
        }

        protected override Task OnMessage(UserCashMsg message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
