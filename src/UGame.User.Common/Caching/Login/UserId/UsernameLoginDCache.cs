using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using AiUo.Caching;
using AiUo.Extensions.StackExchangeRedis;
using UGame.User.Repository;

namespace UGame.User.Common.Caching
{
    /// <summary>
    /// 根据username获取userId
    /// </summary>
    internal class UsernameLoginDCache : RedisStringClient<string>
    {
        public TimeSpan EXPIRE_SPAN { get; } // 缓存有效期3天
        public string OperatorId { get; set; }
        public string Username { get; set; }
        public UsernameLoginDCache(string operatorId, string username, TimeSpan? expire = null)
        {
            if (string.IsNullOrEmpty(operatorId))
                throw new Exception("UsernameLoginDCache时operatorId为空");
            if (string.IsNullOrEmpty(username))
                throw new Exception("UsernameLoginDCache时username为空");

            OperatorId = operatorId;
            Username = username;
            EXPIRE_SPAN = expire.HasValue ? expire.Value : TimeSpan.FromDays(3);
            RedisKey = GetGlobalGroupRedisKey("Login", $"{OperatorId}|{Username}");
        }
        protected override async Task<CacheValue<string>> LoadValueWhenRedisNotExistsAsync()
        {
            var ret = new CacheValue<string>();
            foreach (var userMo in DbSink.GetUserMoList())
            {
                var userId = (await userMo.GetSingleAsync($"OperatorID=@OperatorID and Username=@Username"
                    , OperatorId, Username))?.UserID;
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
