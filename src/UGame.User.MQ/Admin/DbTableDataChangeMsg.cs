using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Extensions.RabbitMQ;

namespace UGame.User.MQ.Admin
{
    /// <summary>
    /// 数据库表数据发生变化时发送的消息
    /// </summary>
    public class DbTableDataChangeMsg
    {
        public string ConfigId { get; set; }
        public string TableName { get; set; }
        public object MQMeta { get; set; }
    }
}
