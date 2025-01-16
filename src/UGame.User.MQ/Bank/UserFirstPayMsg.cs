using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Extensions.RabbitMQ;

namespace UGame.User.MQ.Bank
{
    public class UserFirstPayMsg
    {
        public object MQMeta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int UserKind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime PayTime { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public int PayType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public long PayAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal UserFee { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal OwnFee { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string OperatorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CountryId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CurrencyId { get; set; }

        /// <summary>
        /// 充值的订单号(sb_bank_order表）
        /// </summary>
        public string OrderID { get; set; }

        
        /// <summary>
        /// 事件源地址（如：https://www.lucro777.com）
        /// </summary>
        public string EventSourceUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public object Meta { get; set; }
        /// <summary>
        /// 活动id集合
        /// </summary>
        public List<string> ActivityIds { get; set; }

        /// <summary>
        /// 充值是否操作账户余额（true-操作，false-不操作）
        /// </summary>
        public bool IsAddBalance { get; set; }
        public string AppId { get; set; }
        public string BankId { get; set; }
    }
}
