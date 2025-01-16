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
    internal class OAuthUserUrlStateDCache : RedisStringClient<string>
    {
        public TimeSpan EXPIRE_SPAN { get; } // 缓存有效期3天
        public string State { get; set; }
 
        public OAuthUserUrlStateDCache(string state, TimeSpan? expire = null)
        {
            this.State=state;
            if (string.IsNullOrEmpty(state))
                throw new Exception("OAuthUserUrlStateDCache时state为空");

            EXPIRE_SPAN = expire.HasValue ? expire.Value : TimeSpan.FromMinutes(3);
            RedisKey = GetGlobalGroupRedisKey("Login", "url"+ state);
        }
        public async Task<CacheValue<string>> GetState()
        {
        
            return await GetOrLoadAsync(false, EXPIRE_SPAN);
        }
        protected override async Task<CacheValue<string>> LoadValueWhenRedisNotExistsAsync()
        {
            var ret = new CacheValue<string>();
            
             
            return ret;
        }
        public async Task SetState()
        {
            await SetAsync(State, EXPIRE_SPAN);
        }
        public async Task RemoveState()
        {
            await KeyDeleteAsync();
        }
    }
}
