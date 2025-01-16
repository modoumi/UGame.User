using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Extensions.RabbitMQ;

namespace UGame.User.MQ.Admin
{
    public class CachingChangeMsg
    {
        public string TableName { get; set; }
        public string PrimaryKeyValue { get; set; }
        public string AppId { get; set; }
        public string UserId { get; set; }
        public object MQMeta { get; set; }
    }
}
