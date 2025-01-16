using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo;
using AiUo.Net;
using UGame.SMS.DAL;

namespace UGame.SMS.Common
{
    internal abstract class BaseSmsProxy<TSmsConfig> : ISmsProxy
        where TSmsConfig : ISmsConfig, new()
    {
        public string SmsId { get; }
        public Sms_smsPO SmsEo { get; }
        public TSmsConfig SmsConfig { get; }
        public HttpClientEx SmsClient { get; }
        public BaseSmsProxy(string smsId)
        {
            SmsId = smsId;
            SmsEo = MemCacheUtil.GetSmsEo(smsId);
            SmsConfig = SerializerUtil.DeserializeJsonNet<TSmsConfig>(SmsEo.SmsConfig);
            if (!string.IsNullOrEmpty(SmsConfig?.BaseUrl))
            {
                SmsClient = HttpClientExFactory.CreateClientEx(new HttpClientConfig
                {
                    Name = smsId,
                    BaseAddress = SmsConfig.BaseUrl
                });
            }
        }

        public abstract Task<SmsProxyDto> SendAsync(string mobile, string content);
    }
    internal interface ISmsConfig
    {
        string BaseUrl { get; set; }
    }
    internal interface ISmsProxy
    {
        Sms_smsPO SmsEo { get; }
        Task<SmsProxyDto> SendAsync(string mobile, string content);
    }
    public class SmsProxyDto
    {
        public bool Success { get; set; }
        public string SmsCode { get; set; }
        public string SmsOrderId { get; set; }
        public object SmsResponse { get; set; }
    }
}
