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
using Xxyy.Common;

namespace UGame.User.Service.MQConsumers
{
    public class CurrencyChangeMQSub : MQBizSubConsumer<CurrencyChangeMsg>
    {
        public CurrencyChangeMQSub()
        {
            AddHandler(UpdateSUserDay, "更新SUserDay");
        }

        public override MQSubscribeMode SubscribeMode => MQSubscribeMode.OneQueue;

        protected override void Configuration(ISubscriptionConfiguration config)
        {
            
        }

        protected override Task OnMessage(CurrencyChangeMsg message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        private async Task UpdateSUserDay(CurrencyChangeMsg message, CancellationToken cancellationToken)
        {
            if (message.CurrencyType != CurrencyType.Cash)
                return;

            var cache = await DayUserDCache.Create(message.ChangeTime.ToLocalTime(message.OperatorId),message.UserId );
            await cache.IncrChangeCount();
            if (message.Amount != 0)
                await cache.AddChangeAmount(message.Amount);
            if (message.Bonus != 0)
                await cache.AddChangeBonus(message.Bonus);
        }
    }
}
