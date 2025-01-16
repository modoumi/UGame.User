using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Security;
using UGame.SMS.Common;

namespace UGame.SMS.Providers
{
    internal class HubtelProxy : BaseSmsProxy<HubtelConfig>
    {
        public HubtelProxy(string smsId) : base(smsId)
        {
        }

        public override async Task<SmsProxyDto> SendAsync(string mobile, string content)
        {
            var ret = new SmsProxyDto();
            var req = new HubtelSmsReq
            {
                Content = content,
                To = mobile,
                From = "yoyo777.com"
            };
            var sign = SecurityUtil.Base64Encrypt($"{SmsConfig.ApiId}:{SmsConfig.ApiKey}", Encoding.ASCII);
            var url = "v1/messages/send";//https://sms.hubtel.com/v1/messages/send
            var rsp = await SmsClient.CreateAgent().AddRequestHeader("Authorization", $"Basic {sign}")
                .AddUrl(url)
                .BuildJsonContent(req)
                .PostAsync<HubtelSmsRsp, object>();
            ret.SmsResponse = rsp;
            ret.SmsCode = rsp.SuccessResult?.Status.ToString();
            ret.SmsOrderId = rsp.SuccessResult?.MessageId;
            ret.Success = rsp.Success && rsp.SuccessResult?.Status == 0;
            return ret;
        }
    }
    internal class HubtelConfig : ISmsConfig
    {
        public string BaseUrl { get; set; }
        public string ApiId { get; set; }
        public string ApiKey { get; set; }
    }
    internal class HubtelSmsReq
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Content { get; set; }
    }
    internal class HubtelSmsRsp
    {
        public double Rate { get; set; }
        public string MessageId { get; set; }
        public int Status { get; set; }
        public string NetworkId { get; set; }
        public string ClientReference { get; set; }
        public string StatusDescription { get; set; }
    }
}
