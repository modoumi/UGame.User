using EasyNetQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using AiUo.BIZ.RabbitMQ;
using AiUo.Extensions.RabbitMQ;
using UGame.User.Service.Common;
using UGame.User.Common;
using UGame.User.Common.Caching;
using UGame.User.MQ.Xxyy;
using UGame.User.Repository;

namespace UGame.User.Service.MQConsumers
{
    public class UserRegisterMQSub : MQBizSubConsumer<UserRegisterMsg>
    {
        private UserDaySummaryService userDaySvc = new();
        public UserRegisterMQSub()
        {
            AddHandler(UpdateSUserDay);
        }

        public override MQSubscribeMode SubscribeMode => MQSubscribeMode.OneQueue;

        protected override void Configuration(ISubscriptionConfiguration config)
        {
        }

        protected override Task OnMessage(UserRegisterMsg message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        private async Task UpdateSUserDay(UserRegisterMsg message, CancellationToken cancellationToken)
        {
            var currTime = message.RegisterDate.ToLocalTime(message.OperatorId);
            await (await DayOperatorUserIdsDCache.Create(currTime, message.OperatorId, DayUserIdsType.Register))
                .AddUserId(message.UserId);

            // s_user_day => IsRegister
            await userDaySvc.SetIsRegister(new S_user_dayEO
            {
                DayID = currTime,
                UserID = message.UserId,
                UserKind = message.UserKind,
                OperatorID = message.OperatorId,
                CountryID = message.CountryId,
                CurrencyID = message.CurrencyId,
                FromId = message.FromId,
                FromMode = message.FromMode,

                RegistDate = message.RegisterDate,
            });
        }
    }
}
