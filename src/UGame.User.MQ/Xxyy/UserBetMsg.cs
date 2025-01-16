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
    /// 用户下注消息
    /// </summary>
    public class UserBetMsg
    {
        public object MQMeta { get; set; }
        public string UserId { get; set; }
        public int UserKind { get; set; }
        public string AppId { get; set; }
        public string OperatorId { get; set; }
        public string CountryId { get; set; }
        public string CurrencyId { get; set; }
        public CurrencyType CurrencyType { get; set; }
        public DateTime BetTime { get; set; }
        public string ProviderId { get; set; }

        /// <summary>
        /// Bet = 1,Win = 2,BetWin = 3,Rollback = 4
        /// </summary>
        public int BetType { get; set; }
        public bool IsFirst { get; set; }
        public long BetAmount { get; set; }
        public long BetBonus { get; set; }
        public long WinAmount { get; set; }
        public long WinBonus { get; set; }
        public long Amount => WinAmount - BetAmount;
        public string OrderId { get; set; }
        public List<string> ReferOrderIds { get; set; }
        public bool RoundClosed { get; set; }
        public string RoundId { get; set; }
        public long EndBalance { get; set; }
        public long EndBonus { get; set; }
    }
}
