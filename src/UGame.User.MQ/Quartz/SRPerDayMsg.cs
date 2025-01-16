using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Extensions.RabbitMQ;

namespace UGame.User.MQ.Quartz
{
    /// <summary>
    /// 每日统计消息
    /// </summary>
    public class SRPerDayMsg
    {
        public object MQMeta { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        public SRPerDayType Type { get; set; }

        /// <summary>
        /// DayId
        /// </summary>
        public DateTime DayId { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime SRStartTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime SREndTime { get; set; }

        /// <summary>
        /// 运营商编号
        /// </summary>
        public string OperatorId { get; set; }
    }

    public enum SRPerDayType
    {
        SrOperDay=1,
        SrUserDay =2,
        SrOperBankPaytypeDay = 3
    }
}
