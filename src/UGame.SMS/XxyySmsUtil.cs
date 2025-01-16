using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Reflection;
using AiUo;
using System.Collections.Concurrent;
using UGame.SMS.Common;
using UGame.SMS.DAL;

namespace UGame.SMS
{
    public static class XxyySmsUtil
    {
        /// <summary>
        /// 发送TemplateId
        ///     内容Content确定规则: sms_template_lang(TemplateId+LangId)
        ///     短信渠道smsId确定规则: 
        ///         1) 指定smsId
        ///         2) sms_template_sms(TemplateId+OperatorId+sms_template.SelectSmsMode)
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        public static Task<XxyySmsDto> SendTemplateAsync(XxyySmsTemplateIpo ipo)
        {
            return new SmsSendService().SendAsync(new XxyySmsIpo
            {
                Mobile = ipo.Mobile,
                TemplateId = ipo.TemplateId,
                LangId = ipo.LangId,
                ContentArgs = ipo.ContentArgs,
                IsRetrySend = ipo.IsRetrySend,
                SmsId = ipo.SmsId,
                OperatorId = ipo.OperatorId,
            });
        }

        /// <summary>
        /// 发送指定内容短信
        ///     短信渠道smsId确定规则：
        ///         1) 指定smsId
        ///         2) sms_template(AppID+TemplateType=1) => TemplateId
        ///            sms_template_sms(TemplateId+OperatorId+sms_template.SelectSmsMode) => smsId
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        public static Task<XxyySmsDto> SendContentAsync(XxyySmsContentIpo ipo)
        {
            var templateId = 0;
            if (string.IsNullOrEmpty(ipo.SmsId))
                templateId = MemCacheUtil.GetTemplateEo(ipo.AppId).TemplateID;
            return new SmsSendService().SendAsync(new XxyySmsIpo
            {
                Mobile = ipo.Mobile,
                Content = ipo.Content,
                IsRetrySend = ipo.IsRetrySend,
                SmsId = ipo.SmsId,
                TemplateId = templateId,
                OperatorId = ipo.OperatorId,
                AppId = ipo.AppId,
            });
        }

        public static Task<XxyySmsDto> SendAsync(XxyySmsIpo ipo)
        {
            return new SmsSendService().SendAsync(ipo);
        }

        private static ConcurrentDictionary<string, ISmsProxy> _proxyDic = new();
        internal static ISmsProxy CreateProxy(string smsId)
        {
            if (!_proxyDic.TryGetValue(smsId, out var ret))
            {
                var smsEo = MemCacheUtil.GetSmsEo(smsId);
                var type = Type.GetType($"UGame.SMS.Providers.{smsEo.SmsBaseID.PascalCase()}Proxy");
                ret = (ISmsProxy)ReflectionUtil.CreateInstance(type, smsId);
                _proxyDic.TryAdd(smsId, ret);
            }
            return ret;
        }
    }
}
