using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Extensions.StackExchangeRedis;

namespace UGame.User.Service.Caching
{
    /// <summary>
    /// 手机验证码 
    /// 规则：
    ///     1）每个手机号每天最多只能发10条短信
    ///     2）单IP每天请求次数不能超过10次
    ///     3）单用户请求短信时间间隔为“60秒”
    ///     4）IP黑名单库
    ///         同一号码在同一天内发送超过10条短信
    ///         同一IP在1分钟内出现3次以上
    ///         同一IP在30分钟内超过5次以上
    ///         同一IP在60分钟内出现10次以上 
    ///         同一IP在48*60内出现20以上
    /// key: mobile value: 验证码
    /// </summary>
    internal class SMSTicketDCache : RedisHashClient
    {
        private const int TIME_SPACING = 60;
        private const int COUNT_PER_IP = 20;
        private const int COUNT_PER_MOBILE = 10;

        private const int EXPIRE_DAYS = 1; // 缓存有效期
        private const int LIMIT_SECONDS = 60; // 发送周期限制
        private const int LIMIT_COUNT = 20; // 缓存期内最大发送次数（验证通过删除重置）

        public string Mobile { get; }
        public SMSTicketDCache(string mobile)
        {
            if (string.IsNullOrEmpty(mobile))
                throw new ArgumentNullException("SMSTicketDCache: mobile不能为空");
            Mobile = mobile;
            RedisKey = GetGlobalGroupRedisKey("Login", mobile);
        }

        private const string Key_LastSendTime = "LastSendTime";
        public Task<DateTime> GetLastSendTime() => GetOrDefaultAsync(Key_LastSendTime, DateTime.MinValue);
        public Task SetLastSendTime(DateTime value) => SetAsync(Key_LastSendTime, value);

        private const string Key_Codes = "Codes";
        public Task<List<string>> GetCodes() => GetOrDefaultAsync(Key_Codes, new List<string>());
        public Task SetCodes(List<string> value) => SetAsync(Key_Codes, value);

        private const string Key_SendSmsIds = "Key_SendSmsIds";
        public Task<List<string>> GetSendSmsIds() => GetOrDefaultAsync(Key_SendSmsIds, new List<string>());
        public Task SetSendSmsIds(List<string> value) => SetAsync(Key_SendSmsIds, value);

        public async Task<bool> IsAllowSend()
        {
            if (!await KeyExistsAsync())
                return true;
            // 发送周期(60秒)仅允许发一次
            if ((DateTime.UtcNow - await GetLastSendTime()).TotalSeconds < LIMIT_SECONDS)
                return false;
            // 发送超过限制次数禁止
            if ((await GetCodes()).Count > LIMIT_COUNT)
                return false;
            return true;
        }

        public async Task<string> GetLastCode()
        {
            var codes = await GetCodes();
            var lastCode = codes.LastOrDefault();
            if (string.IsNullOrWhiteSpace(lastCode))
                return null;
            await SetCode(lastCode);
            return lastCode;
        }

        public async Task SetCode(string smsCode)
        {
            var codes = await GetCodes();
            codes.Add(smsCode);
            await SetCodes(codes);
            await SetLastSendTime(DateTime.UtcNow);
            await KeyExpireDaysAsync(EXPIRE_DAYS);
        }

        public async Task<bool> CheckCode(string smsCode)
        {
            var ret = (await GetCodes()).Any(x => x == smsCode);
            if (ret)
                await KeyDeleteAsync();
            return ret;
        }
    }

}
