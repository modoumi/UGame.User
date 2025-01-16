using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Extensions.RabbitMQ;
using Xxyy.Common;

namespace UGame.User.MQ.Xxyy
{
    /// <summary>
    /// 货币变化消息（包括除下注返奖，充值提现之外的变化）
    /// </summary>
    public class CurrencyChangeMsg
    {
        public object MQMeta { get; set; }

        public string UserId { get; set; }
        public UserKind UserKind { get; set; }
        public string AppId { get; set; }
        public string OperatorId { get; set; }
        public string CountryId { get; set; }
        public string CurrencyId { get; set; }
        //public bool IsBonus { get; set; }
        public float FlowMultip { get; set; }
        public CurrencyType CurrencyType { get; set; }
        public DateTime ChangeTime { get; set; }

        public string SourceId { get; set; }
        public string SourceTable { get; set; }
        public int SourceType { get; set; }
        public string Reason { get; set; }
        public long Amount { get; set; }
        public long EndBalance { get; set; }
        public long Bonus { get; set; }
        public long EndBonus { get; set; }
        public long Coin { get; set; }
        public long EndCoin { get; set; }
        public int FromMode { get; set; }
        public string FromId { get; set; }
        public string DomainId { get; set; }
    }
}
