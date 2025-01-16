using Google.Protobuf.WellKnownTypes;
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
    /// Email获取UserId缓存 
    /// key: email value: userId
    /// </summary>
    internal class EmailLoginDCache : RedisStringClient<string>
    {
        public TimeSpan EXPIRE_SPAN { get; } // 缓存有效期3天
        public string OperatorId { get; set; }
        public string Email { get; set; }
        public EmailLoginDCache(string operatorId, string email, TimeSpan? expire = null)
        {
            if (string.IsNullOrEmpty(operatorId))
                throw new Exception("EmailLoginDCache时operatorId为空");
            if (string.IsNullOrEmpty(email))
                throw new Exception("EmailLoginDCache时email为空");
            
            OperatorId = operatorId;
            Email = email;
            EXPIRE_SPAN = expire.HasValue ? expire.Value : TimeSpan.FromDays(3);
            RedisKey = GetGlobalGroupRedisKey("Login", $"{OperatorId}|{Email}");
        }
        protected override async Task<CacheValue<string>> LoadValueWhenRedisNotExistsAsync()
        {
            var ret = new CacheValue<string>();
            foreach (var userMo in DbSink.GetUserMoList())
            {
                var userId = (await userMo.GetSingleAsync($"OperatorID=@OperatorID and Email=@Email"
                    , OperatorId, Email))?.UserID;
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
