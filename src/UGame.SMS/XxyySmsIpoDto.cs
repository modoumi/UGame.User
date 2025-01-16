using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGame.SMS
{
    public class XxyySmsTemplateIpo
    {
        public string Mobile { get; set; }
        public int TemplateId { get; set; } = -1;
        /// <summary>
        /// 确定Content = sms_template_lang(TemplateId+LangId)
        /// </summary>
        public string LangId { get; set; }
        /// <summary>
        /// 内容模板中替换的内容，string.Format
        /// </summary>
        public List<object> ContentArgs { get; set; } = new();
        /// <summary>
        /// 是否重新尝试直到成功
        /// </summary>
        public bool IsRetrySend { get; set; }

        /// <summary>
        /// 指定短信通道
        /// </summary>
        public string SmsId { get; set; }
        /// <summary>
        /// 按sms_template_sms选择短信通道
        /// </summary>
        public string OperatorId { get; set; }
    }

    public class XxyySmsContentIpo
    {
        public string Mobile { get; set; }
        public string Content { get; set; }
        /// <summary>
        /// 是否重新尝试直到成功
        /// </summary>
        public bool IsRetrySend { get; set; }

        /// <summary>
        /// 指定短信通道
        /// </summary>
        public string SmsId { get; set; }
        /// <summary>
        /// 按sms_template_sms选择短信通道
        /// </summary>
        public string OperatorId { get; set; }
        /// <summary>
        /// 按sms_template_sms选择短信通道
        /// </summary>
        public string AppId { get; set; }
    }

    public class XxyySmsIpo
    {
        public string Mobile { get; set; }
        public int TemplateId { get; set; } = -1;
        public string LangId { get; set; }
        /// <summary>
        /// 内容模板中替换的内容，string.Format
        /// </summary>
        public List<object> ContentArgs { get; set; } = new();
        public string Content { get; set; }
        /// <summary>
        /// 是否重新尝试直到成功
        /// </summary>
        public bool IsRetrySend { get; set; }

        /// <summary>
        /// 指定短信通道
        /// </summary>
        public string SmsId { get; set; }
        /// <summary>
        /// 按sms_template_sms选择短信通道
        /// </summary>
        public string OperatorId { get; set; }
        /// <summary>
        /// 统计用，可空
        /// </summary>
        public string AppId { get; set; }
    }

    public class XxyySmsDto
    {
        public bool Success { get; set; }
        public string Code { get; set; }
        public string Message { get; set; }
        public Exception Exception { get; set; }

        public string SmsId { get; set; }
        public string Content { get; set; }
        public List<string> OtherSmsIds { get; set; } = new();

        public string SmsCode { get; set; }
        public string SmsOrderId { get; set; }
        public object SmsResponse { get; set; }
    }
}
