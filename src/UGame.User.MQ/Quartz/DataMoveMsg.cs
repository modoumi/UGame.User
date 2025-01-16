using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGame.User.MQ.Quartz
{
    public class DataMoveMsg
    {
        public string MessageId { get; set; }
        public long Timestamp { get; set; }
        public object MQMeta { get; set; }
    }
}
