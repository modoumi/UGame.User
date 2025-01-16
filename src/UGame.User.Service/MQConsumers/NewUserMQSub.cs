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
using UGame.User.MQ.Xxyy;
using UGame.User.Repository;

namespace UGame.User.Service.MQConsumers
{
    public class NewUserMQSub : MQBizSubConsumer<NewUserMsg>
    {
        private UserDaySummaryService userDaySvc = new();

        public override MQSubscribeMode SubscribeMode => MQSubscribeMode.OneQueue;

        public NewUserMQSub()
        {
            AddHandler(AddSUserApp);
            AddHandler(UpdateSUserDay);
        }
        private async Task AddSUserApp(NewUserMsg message, CancellationToken cancellationToken)
        {
            // s_user_app
            var sUserMo = DbSink.BuildUserAppMo(message.UserId);
            await sUserMo.AddAsync(new S_user_appEO
            {
                UserID = message.UserId,
                AppID = message.AppId,
                Status = 1,
                LastLoginDate = message.RecDate
            }, null, true);
        }
        protected async Task UpdateSUserDay(NewUserMsg message, CancellationToken cancellationToken)
        {
            var currTime = message.RecDate.ToLocalTime(message.OperatorId);
            await (await DayOperatorUserIdsDCache.Create(currTime, message.OperatorId, DayUserIdsType.NewUser))
                .AddUserId(message.UserId);
            // s_user_day => IsNew
            await userDaySvc.SetIsNew(new S_user_dayEO
            {
                DayID = currTime,
                UserID = message.UserId,
                UserKind = message.UserKind,
                OperatorID = message.OperatorId,
                CountryID = message.CountryId,
                CurrencyID = message.CurrencyId,
                FromId = message.FromId,
                FromMode = message.FromMode,
                UserIp = message.UserIp,
            });
        }

        protected override void Configuration(ISubscriptionConfiguration config)
        {
            
        }

        protected override Task OnMessage(NewUserMsg message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
