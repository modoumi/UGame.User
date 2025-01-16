using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Extensions.RabbitMQ;

namespace UGame.User.MQ.Xxyy
{
    /// <summary>
    /// 手机号变更消息（包含第一次绑定、后续手机号变更）
    /// </summary>
    public class ChangeMobileMsg
    {
        public object MQMeta { get; set; }
        /// <summary>
        /// 用户编码
        /// </summary>
        public string UserId { get; set; }
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
        public string AppId { get; set; } = "lobby";
        /// <summary>
        /// 手机号
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 是否首次绑定
        /// </summary>
        public bool IsFirst { get; set; }
    }
}
