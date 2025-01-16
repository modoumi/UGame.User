using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Configuration;
using AiUo.Extensions.AutoMapper;
using AiUo.Extensions.StackExchangeRedis;

namespace UGame.User.Common.Caching
{
    public class AppLoginTokenDCache : RedisStringClient<AppLoginTokenDO>
    {
        private int EXPIRE_MINUTES = 30;
        public string AppId { get; set; }
        public string Token { get; set; }
        public AppLoginTokenDCache(string appId, string token)
        {
            EXPIRE_MINUTES = ConfigUtil.Environment.IsDebug
                ? (int)TimeSpan.FromDays(1).TotalMinutes : 30;
            AppId = appId;
            Token = token;
            RedisKey = GetGlobalGroupRedisKey("Partner", $"{appId}:{token}");
            this.Options.SlidingExpiration = new TimeSpan(0,EXPIRE_MINUTES,0);
        }

        public Task SetTokenDo(AppLoginTokenDO tokenDo)
            => SetAndExpireMinutesAsync(tokenDo, EXPIRE_MINUTES);

        public Task<AppLoginTokenDO> GetTokenDo()
            => GetOrDefaultAsync(null, TimeSpan.FromMinutes(EXPIRE_MINUTES));
    }
    public class AppLoginTokenDO
    {
        public string AppId { get; set; }
        public string ProviderId { get; set; }
        public string OperatorId { get; set; }
        public string OperatorUserId { get; set; }

        public string CountryId { get; set; }
        public string CurrencyId { get; set; }
        public string LangId { get; set; }
        public string LobbyUrl { get; set; }
        public string DepositUrl { get; set; }
        public string ClientRefererUrl { get; set; }
        /// <summary>
        /// 运营商保存的与UserId+AppId+CurrencyId相关的令牌，DEMO忽略
        /// </summary>
        public string Token { get; set; }
        /// <summary>
        /// token缓存来源
        /// 0-appurl生成
        /// 1-请求时根据用户数据生成(部分参数不全)
        /// </summary>
        public int TokenFrom { get; set; }
        /// <summary>
        /// 平台0-mobile 1-desktop
        /// </summary>
        public int Platform { get; set; }
        public string UserIp { get; set; }
        public object Meta { get; set; }

        public string UserId { get; set; }
        public OperatorType OperatorType { get; set; }
        public ProviderType ProviderType { get; set; }
    }
}
