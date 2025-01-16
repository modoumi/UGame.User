using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Net;
using UGame.SMS.Common;

namespace UGame.SMS.Providers
{
    internal class VoicesProxy : BaseSmsProxy<VoicesConfig>
    {
        public VoicesProxy(string smsId) : base(smsId)
        {
        }

        public override async Task<SmsProxyDto> SendAsync(string mobile, string content)
        {
            var ret = new SmsProxyDto();
            var req = new VoicesSmsReq
            {
                Number = mobile,
                Password = SmsConfig.Password, //"WAb7MxTpMN",
                Message = content,
                User = SmsConfig.User,//"Soul",
                Mask = SmsConfig.Mask //"NUMERO LARGO"
            };
            var url = "envioSms"; //"https://sms-voices.com.mx:8080/envioSms";
            var rsp = await SmsClient.CreateAgent()
                .AddUrl(url)
                .BuildJsonContent(req)
                .PostAsync<VoicesSmsRsp, object>();

            ret.SmsResponse = rsp;
            ret.SmsCode = Convert.ToString(rsp.SuccessResult?.Code);
            ret.SmsOrderId = rsp.SuccessResult?.Uuid;
            ret.Success = rsp.Success && rsp.SuccessResult?.Code == 200;
            return ret;
        }
    }
    internal class VoicesConfig : ISmsConfig
    {
        public string BaseUrl { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string Mask { get; set; }
    }
    internal class VoicesSmsReq
    {
        public string Number { get; set; }
        public string Password { get; set; }
        public string Message { get; set; }
        public string User { get; set; }
        public string Mask { get; set; }
    }
    internal class VoicesSmsRsp
    {
        public int Code { get; set; }
        public string Desc { get; set; }
        public string Uuid { get; set; }
    }
}
