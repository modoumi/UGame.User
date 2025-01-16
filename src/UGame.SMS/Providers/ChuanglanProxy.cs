using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using AiUo;
using AiUo.Configuration;
using AiUo.Logging;
using AiUo.Net;
using UGame.SMS.Common;

namespace UGame.SMS.Providers
{
    internal class ChuanglanProxy : BaseSmsProxy<ChuanglanConfig>
    {
        public ChuanglanProxy(string smsId) : base(smsId)
        {
        }

        public override async Task<SmsProxyDto> SendAsync(string mobile, string content)
        {
            var ret = new SmsProxyDto();
            var req = new ChuanglanSmsReq
            {
                Mobile = mobile,
                Password = SmsConfig.Password,
                Msg = content,
                Account = SmsConfig.Account,
                SenderId = ""//"NUMERO LARGO"
            };
            
            var url = "send/json";
            var rsp = await SmsClient.CreateAgent()
                .AddUrl(url)
                .BuildJsonContent(req)
                .PostAsync<ChuanglanSmsRsp, object>();
            ret.SmsResponse = rsp;
            ret.SmsCode = rsp.SuccessResult?.Code;
            ret.SmsOrderId = rsp.SuccessResult?.Msgid;
            ret.Success = rsp.Success && rsp.SuccessResult?.Code == "0";
            return ret;
        }
    }
    internal class ChuanglanConfig : ISmsConfig
    {
        public string BaseUrl { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
    }
    internal class ChuanglanSmsReq
    {
        public string Account { get; set; }
        public string Password { get; set; }
        public string Msg { get; set; }
        public string Mobile { get; set; }
        public string SenderId { get; set; }
    }
    internal class ChuanglanSmsRsp
    {
        public string Code { get; set; }
        public string Error { get; set; }
        public string Msgid { get; set; }
    }
}
