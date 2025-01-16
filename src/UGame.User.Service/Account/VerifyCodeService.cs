using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AiUo.Configuration;
using UGame.User.Common.Caching;
using UGame.User.Common; 
using AiUo.Security;
using AiUo.Net;
using AiUo.Text;
using UGame.User.Service.Caching;
using UGame.SMS;

namespace UGame.User.Service.Account
{
    public class VerifyCodeService
    {
        public async Task SendVerifyCode(SendVerifyCodeIpo ipo)
        {
            // check
            AiUoUtil.ThrowIfNullOrEmptyEx(CommonCodes.SMSSendError, "参数不能为空"
                , ipo.Id, ipo.OperatorId, ipo.AppId, ipo.LangId);
            switch (ipo.Mode)
            {
                case VerifyCodeMode.Mobile:
                    await SendSmsCode(ipo);
                    break;
                default:
                    throw new Exception("未知VerifyCodeMode");
            }
        }
        private async Task SendSmsCode(SendVerifyCodeIpo ipo)
        {
            var oper = DbCacheUtil.GetOperator(ipo.OperatorId);
            var countryEo = DbCacheUtil.GetCountry(oper.CountryID);
            if (!ipo.Id.StartsWith(countryEo.CallingCode))
                throw new CustomException(CommonCodes.SMSSendError, $"手机号码区号错误。mobile:{ipo.Id} countryId:{countryEo.CountryID} callingCode:{countryEo.CallingCode}");
            if (ConfigUtil.Environment.IsDebug|| ConfigUtil.Environment.IsStaging) return;

            var code = await GetSMSTicket(ipo.Id);
            var req = new XxyySmsTemplateIpo
            {
                IsRetrySend = true,
                Mobile = ipo.Id,
                TemplateId = (int)SmsTemplateIds.VerifyCode,
                LangId = ipo.LangId,
                ContentArgs = new List<object> { code },
                OperatorId = ipo.OperatorId,
            };
            var rsp = await XxyySmsUtil.SendTemplateAsync(req);
            if (!rsp.Success)
                throw new CustomException(CommonCodes.SMSSendError, "短信发送失败");
        }

        public async Task<CheckVerifyCodeDto> CheckVerifyCode(CheckVerifyCodeIpo ipo)
        {
            // check
            AiUoUtil.ThrowIfNullOrEmptyEx(GResponseCodes.G_BAD_REQUEST, "参数不能为空"
                , ipo.Id, ipo.VerifyCode);
            switch (ipo.Mode)
            {
                case VerifyCodeMode.Mobile:
                    return await CheckSmsVerifyCode(ipo);
                default:
                    throw new Exception("未知VerifyCodeMode");
            }
        }

        private async Task<CheckVerifyCodeDto> CheckSmsVerifyCode(CheckVerifyCodeIpo ipo)
        {
            var ret = new CheckVerifyCodeDto();
            if (ConfigUtil.Environment.IsProduction)
                await CheckSMSTicket(ipo.Id, ipo.VerifyCode);
            ret.SecurityCode = CreateSecurityCode(ipo.Id, ipo.VerifyCode);
            return ret;
        }

        private string CreateSecurityCode(string id, string verifyCode)
        {
            return SecurityUtil.SHA1Hash($"{id}|=>|{verifyCode}");
        }

        public bool VerifySecurityCode(string securityCode, string id, string verifyCode)
        {
            return ConfigUtil.Environment.IsProduction
                ? SecurityUtil.SHA1Verify($"{id}|=>|{verifyCode}", securityCode)
                : true;
        }


        #region SMSTicket
        /// <summary>
        /// 获取验证码code并缓存
        /// </summary>
        /// <param name="mobile"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        private static async Task<string> GetSMSTicket(string mobile, int length = 4)
        {
            //限定规则
            var cache = new SMSTicketDCache(mobile);
            if (!await cache.IsAllowSend())
                throw new CustomException(CommonCodes.SMSLimited, null);
            var lastCode = await cache.GetLastCode();
            if (!string.IsNullOrWhiteSpace(lastCode))
                return lastCode;

            var code = new RandomString(CharsScope.Numbers, length).Next();
            await cache.SetCode(code);
            return code;
        }

        /// <summary>
        /// 检查短信验证码code
        /// </summary>
        /// <param name="mobile"></param>
        /// <param name="code"></param>
        private static async Task CheckSMSTicket(string mobile, string code)
        {
            if (string.IsNullOrEmpty(mobile))
                throw new ArgumentNullException("手机号mobile不能为空");
            if (string.IsNullOrEmpty(code))
                throw new ArgumentNullException("短信验证码不能为空");
            var cache = new SMSTicketDCache(mobile);
            if (!await cache.CheckCode(code))
                throw new CustomException(CommonCodes.VerifyCodeError, "短信验证码错误");
            await cache.KeyDeleteAsync();
        }
        #endregion
    }
}
