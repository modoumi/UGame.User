using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Caching;
using AiUo.Extensions.StackExchangeRedis;

namespace UGame.User.Common.Caching
{
    internal class OAuthUserDCache : RedisStringClient<string>
    {
        public TimeSpan EXPIRE_SPAN { get; } // 缓存有效期3天
        public string OperatorId { get; set; }
        public int OAuthType { get; }
        public string OAuthId { get; }
        public OAuthUserDCache(string operatorId, int oauthType, string oauthId, TimeSpan? expire = null)
        {
            if (string.IsNullOrEmpty(operatorId))
                throw new Exception("OAuthUserDCache时operatorId为空");
            if (string.IsNullOrEmpty(oauthId))
                throw new Exception("OAuthUserDCache时oauthId为空");

            OperatorId = operatorId;
            OAuthType = oauthType;
            OAuthId = oauthId;
            EXPIRE_SPAN = expire.HasValue ? expire.Value : TimeSpan.FromDays(3);
            RedisKey = GetGlobalGroupRedisKey("Login", $"{OperatorId}|{OAuthType}|{OAuthId}");
        }

        protected override async Task<CacheValue<string>> LoadValueWhenRedisNotExistsAsync()
        {
            var ret = new CacheValue<string>();
            foreach (var userMo in DbSink.GetUserMoList())
            {
                var userId = (await userMo.GetSingleAsync($"OperatorID=@OperatorID and OAuthType=@OAuthType and OAuthID=@OAuthID"
                    , OperatorId, OAuthType, OAuthId))?.UserID;
                if (userId != null)
                {
                    ret.HasValue = true;
                    ret.Value = userId;
                    break;
                }
            }
            return ret;
        }

        public async Task<CacheValue<string>> GetUserId()
        {
            return await GetOrLoadAsync(false, EXPIRE_SPAN);
        }

        public async Task RemoveUserId()
        {
            await KeyDeleteAsync();
        }
    }
}
