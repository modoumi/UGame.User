using EasyNetQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.BIZ.RabbitMQ;
using AiUo.Extensions.RabbitMQ;
using UGame.User.Common.Caching; 
using UGame.User.MQ.Xxyy;

namespace UGame.User.Service.MQConsumers
{
    public class VipUpgradeMQSub: MQBizSubConsumer<VipUpgradeMsg>
    {
        public VipUpgradeMQSub()
        { }

        public override MQSubscribeMode SubscribeMode => MQSubscribeMode.OneQueue;

        protected override void Configuration(ISubscriptionConfiguration config)
        {
        }

        protected override Task OnMessage(VipUpgradeMsg message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        private async Task UpdateVip(VipUpgradeMsg message, CancellationToken cancellationToken)
        {
            var dcache = await GlobalUserDCache.Create(message.UserId);
            await dcache.SetVipAsync(message.VipTo);
        }
    }
}
