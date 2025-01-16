using Google.Protobuf.WellKnownTypes;
using Microsoft.AspNetCore.Identity;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using AiUo.Extensions.StackExchangeRedis;
using UGame.User.Repository;
using AiUo.Caching;

namespace UGame.User.Common.Caching
{
    /// <summary>
    /// 根据mobile获取userId 
    /// key: mobile value: userId
    /// </summary>
    internal class MobileLoginDCache : RedisStringClient<string>
    {
        public TimeSpan EXPIRE_SPAN { get; } // 缓存有效期3天
        public string OperatorId { get; set; }
        public string Mobile { get; set; }
        public MobileLoginDCache(string operatorId, string mobile, TimeSpan? expire = null)
        {
            if (string.IsNullOrEmpty(operatorId))
                throw new Exception("MobileLoginDCache时operatorId为空");
            if (string.IsNullOrEmpty(mobile))
                throw new Exception("MobileLoginDCache时mobile为空");

            OperatorId = operatorId;
            Mobile = mobile;
            EXPIRE_SPAN = expire.HasValue ? expire.Value : TimeSpan.FromDays(3);
            RedisKey = GetGlobalGroupRedisKey("Login", $"{OperatorId}|{Mobile}");
        }
        protected override async Task<CacheValue<string>> LoadValueWhenRedisNotExistsAsync()
        {
            var ret = new CacheValue<string>();
            foreach (var userMo in DbSink.GetUserMoList())
            {
                var userId = (await userMo.GetSingleAsync($"OperatorID=@OperatorID and Mobile=@Mobile"
                    , OperatorId, Mobile))?.UserID;
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
        public async Task SetUserId(string userId)
        {
            await SetAsync(userId, EXPIRE_SPAN);
        }

        public async Task RemoveUserId()
        {
            await KeyDeleteAsync();
        }
    }
}
