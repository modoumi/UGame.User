using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.DataProtection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using AiUo;
using AiUo.Configuration;
using AiUo.Logging;
using AiUo.Net;
using UGame.SMS.Common;

namespace UGame.SMS.Providers
{
    internal class PaasooProxy : BaseSmsProxy<PaasooConfig>
    {
        public PaasooProxy(string smsId) : base(smsId)
        {
        }

        public override async Task<SmsProxyDto> SendAsync(string mobile, string content)
        {
            var ret = new SmsProxyDto();
            var url = $"json?key={SmsConfig.ApiKey}&secret={SmsConfig.ApiSecret}&from=xxyy&to={mobile}&text={HttpUtility.UrlEncode(content, Encoding.UTF8)}";
            var rsp = await SmsClient.CreateAgent()
                .AddUrl(url)
                .GetAsync<PaasooSmsRsp, object>();
            ret.SmsResponse = rsp;
            ret.SmsCode = rsp.SuccessResult?.status;
            ret.SmsOrderId = rsp.SuccessResult?.messageid;
            ret.Success = rsp.Success && rsp.SuccessResult?.status == "0" && !string.IsNullOrWhiteSpace(rsp.SuccessResult?.messageid);
            return ret;
        }
    }
    internal class PaasooConfig : ISmsConfig
    {
        public string BaseUrl { get; set; }
        public string ApiKey { get; set; }
        public string ApiSecret { get; set; }
    }
    internal class PaasooSmsRsp
    {
        public string status { get; set; }
        
        public string messageid { get; set; }
    }

    internal class PaasooSmsErrorRsp
    {
        public string status { get; set; }
        public string status_code { get; set; }
    }
}
