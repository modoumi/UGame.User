using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using AiUo;
using AiUo.Caching;
using AiUo.Extensions.StackExchangeRedis;
using UGame.User.Common;
using UGame.User.Repository;

namespace UGame.User.Common.Caching
{
    /// <summary>
    /// 全局用户缓存
    /// </summary>
    public partial class GlobalUserDCache : RedisHashExpireClient
    {
        private const int EXPIRE_DAYS = 3; // 缓存有效期

        public string UserId { get; }
        public GlobalUserDCache(string userId)
        {
            if (string.IsNullOrEmpty(userId))
                throw new ArgumentNullException("GlobalUserDCache: userId不能为空");
            UserId = userId;
            RedisKey = GetGlobalRedisKey(UserId);
        }

        public static async Task<GlobalUserDCache> Create(string userId, Func<Task<S_userEO>> func = null, Func<Task<S_user_exEO>> funcEx = null)
        {
            var ret = new GlobalUserDCache(userId);
            if (!(await ret.GetLoadFromDbDateAsync()).HasValue)
            {
                var userEo = func != null
                    ? await func()
                    : await DbSink.BuildUserMo(userId).GetByPKAsync(userId);
                if (userEo == null)
                    throw new CustomException(CommonCodes.RS_USER_NOT_EXISTS, $"GlobalUserDCache.Create时，userId:{userId}不存在");
                var userExEo = funcEx != null
                    ? await funcEx()
                    : await DbSink.BuildUserExMo(userId).GetByPKAsync(userId);
                await ret.SetBaseValues(userEo, userExEo);
            }
            return ret;
        }
    }
}
