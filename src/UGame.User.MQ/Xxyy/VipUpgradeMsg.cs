using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Extensions.RabbitMQ;

namespace UGame.User.MQ.Xxyy
{
    /// <summary>
    /// VIP升级消息
    /// </summary>
    public class VipUpgradeMsg
    {
        public object MQMeta { get; set; }
        public string UserId { get; set; }
        public DateTime UpgradeTime { get; set; }
        public long Point { get; set; }
        public int VipFrom { get; set; }
        public int VipTo { get; set; }
    }
}
