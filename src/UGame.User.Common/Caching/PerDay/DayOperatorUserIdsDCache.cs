using EasyNetQ;
using Elasticsearch.Net.Specification.IndicesApi;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Extensions.StackExchangeRedis;

namespace UGame.User.Common.Caching
{
    public enum DayUserIdsType
    {
        NewUser,
        Register,
        Bet,
        Pay,
        Cash,
    }
    public class DayOperatorUserIdsDCache : RedisSetClient<string>
    {
        private const int EXPIRE_DAYS = 3; // 缓存有效期
        private bool _isExpired = false;
        public int DayId { get; }
        public string OperatorId { get; set; }
        protected DayOperatorUserIdsDCache(int dayId, string operatorId, DayUserIdsType type)
        {
            if (dayId == 0)
                throw new ArgumentNullException("UserDayDCache: dayId不能为0");
            DayId = dayId;
            OperatorId = operatorId;
            RedisKey = GetGlobalGroupRedisKey("PerDay", $"{DayId}:{OperatorId}:{type}");
        }
        public static async Task<DayOperatorUserIdsDCache> Create(DateTime day, string operatorId, DayUserIdsType type)
        {
            var dayId = day.ToString("yyyyMMdd").ToInt32();
            return await Create(dayId, operatorId, type);
        }
        private static ConcurrentDictionary<string, DayOperatorUserIdsDCache> _dict = new();
        public static async Task<DayOperatorUserIdsDCache> Create(int dayId, string operatorId, DayUserIdsType type)
        {
            var key = $"{dayId}|{operatorId}|{type}";
            return _dict.GetOrAdd(key, new DayOperatorUserIdsDCache(dayId, operatorId, type));
        }

        public Task<IEnumerable<string>> GetAllUserIds()
        {
            return GetAllAsync();
        }
        public async Task AddUserId(string userId)
        {
            await AddAsync(userId);
            if (!_isExpired)
            {
                await KeyExpireAsync(TimeSpan.FromDays(EXPIRE_DAYS));
                _isExpired = true;
            }
        }
    }
}
