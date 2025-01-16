using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Extensions.RabbitMQ;

namespace UGame.User.MQ.Xxyy
{
    /// <summary>
    /// 领取奖励的需要发通知的消息
    /// </summary>
    public class NotifyRewardMsg
    {
        public object MQMeta { get; set; }
        public string UserId { get; set; }

        public string OperatorId { get; set; }

        public string CountryId { get; set; }

        public string CurrencyId { get; set; }

        /// <summary>
        /// 是否发送弹框通知
        /// </summary>
        public bool IsSendNotify { get; set; }

        /// <summary>
        /// 是否发送站内邮件通知
        /// </summary>
        public bool IsSendNotifyEmail { get; set; }

        /// <summary>
        /// 奖励金额
        /// </summary>
        public long RewardAmount { get; set; }

        /// <summary>
        /// 奖励需要完成的流水倍数
        /// </summary>
        public float FlowMultip { get; set; }

        /// <summary>
        /// 奖励原始表
        /// </summary>
        public string RewardSourceTable { get; set; }

        /// <summary>
        /// 奖励原始ID
        /// </summary>
        public string RewardSourceId { get; set; }

        /// <summary>
        /// 奖励标识ID
        /// </summary>
        public int RewardFlagId { get; set; }

        /// <summary>
        /// 邮件发送标识
        /// </summary>
        public string SenderId { get; set; }
    }
}
