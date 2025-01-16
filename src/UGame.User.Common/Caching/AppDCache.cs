using StackExchange.Redis;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Extensions.StackExchangeRedis;

namespace UGame.User.Common.Caching
{
    /// <summary>
    /// appId对应的全局缓存
    /// </summary>
    public class AppDCache : RedisHashClient
    {
        public string AppId { get; set; }
        private AppDCache(string appId)
        {
            if (string.IsNullOrEmpty(appId))
                throw new ArgumentNullException("AppDCache: AppId不能为空");
            AppId = appId.ToLower();
            RedisKey = GetGlobalRedisKey(AppId);
        }

        private static ConcurrentDictionary<string, AppDCache> _cache = new();
        public static AppDCache Create(string appId)
        {
            if (!_cache.TryGetValue(appId, out AppDCache ret))
            {
                ret = new AppDCache(appId);
                _cache.TryAdd(appId, ret);
            }
            return ret;
        }
    }
}
