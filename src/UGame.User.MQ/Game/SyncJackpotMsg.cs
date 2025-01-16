using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Extensions.RabbitMQ;

namespace UGame.User.MQ.Game
{
    public class SyncJackpotMsg
    {
        public object MQMeta { get; set; }
        /// <summary>
        /// 运营商编码
        /// </summary>
        public string OperatorId { get; set; }

        /// <summary>
        /// 国家编码
        /// </summary>
        public string CountryId { get; set; }

        /// <summary>
        /// 货币编码
        /// </summary>
        public string CurrencyId { get; set; }

        /// <summary>
        /// 应用编码
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// Jackpot奖池
        /// </summary>
        public long Jackpot { get; set; }

    }
}
