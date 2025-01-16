using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Extensions.RabbitMQ;

namespace UGame.User.MQ.Quartz
{
    /// <summary>
    /// 每日基础统计数据完成
    /// </summary>
    public class SRBaseDataCompleted
    {
        public object MQMeta { get; set; }
        public DateTime BeginUtcDate { get; set; }
        public DateTime EndUtcDate { get; set;}
    }
}
