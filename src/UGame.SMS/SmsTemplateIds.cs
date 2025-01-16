using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGame.SMS
{
    public enum SmsTemplateIds
    {
        /// <summary>
        /// 短信验证码模板
        /// </summary>
        VerifyCode = 1,
        /// <summary>
        /// 充值通知
        /// </summary>
        PayNotify = 2,
        /// <summary>
        /// 提现通知
        /// </summary>
        CashNotify = 3
    }

}
