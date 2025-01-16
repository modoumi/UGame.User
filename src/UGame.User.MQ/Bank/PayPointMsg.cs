using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Extensions.RabbitMQ;

namespace UGame.User.MQ.Bank
{
    /// <summary>
    /// spei充值打点消息
    /// </summary>
    public class PayPointMsg
    {
        public object MQMeta { get; set; }
        public string PointName { get; set; }
        /// <summary>
        /// 支付类型paytypeenum
        /// </summary>
        public int PayType { get; set; }
        public DateTime PayTime { get; set; }
        public string Currency { get; set; }
        public decimal Money { get; set; }
        public decimal Fee { get; set; }
        public string Transactionid { get; set; }
        public string UserId { get; set; }
        public string OperatorId { get; set; }
        public string Gaid { get; set; }
        public int FromMode { get; set; }
        public string FromId { get; set; }
    }
}
