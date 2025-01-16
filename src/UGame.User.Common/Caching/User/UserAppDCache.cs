using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AiUo;
using AiUo.Caching;
using AiUo.Extensions.StackExchangeRedis;
using UGame.User.Common;
using UGame.User.Repository;

namespace UGame.User.Common.Caching
{
    /// <summary>
    /// 用户游戏数据全局缓存: Key = userId:appId
    /// 经常变化的currency只放在内存和数据库
    /// </summary>
    public partial class UserAppDCache : RedisHashExpireClient
    {
        #region Constructors
        private const int EXPIRE_DAYS = 3; // 缓存有效期
        public string UserId { get; }
        public string AppId { get; }
        
        public UserAppDCache(string userId, string appId)
        {
            if (string.IsNullOrEmpty(userId))
                throw new Exception("UserAppDCache: userId不能为空");
            if (string.IsNullOrEmpty(appId))
                throw new Exception("UserAppDCache: appId不能为空");
            UserId = userId;
            AppId = appId;
            RedisKey = GetGlobalRedisKey($"{UserId}:{AppId}");
            this.Options.SlidingExpiration = new TimeSpan(EXPIRE_DAYS,0,0,0);
        }
        #endregion

        public static async Task<UserAppDCache> Create(string userId, string appId, Func<Task<S_user_appEO>> func = null)
        {
            var ret = new UserAppDCache(userId, appId);
            if (!(await ret.GetLoadFromDbDateAsync()).HasValue)
            {
                var userAppEo = func != null
                    ? await func()
                    : await DbSink.BuildUserAppMo(userId).GetByPKAsync(userId, appId);
                await ret.SetBaseValues(userAppEo);
            }
            return ret;
        }
    }
}
