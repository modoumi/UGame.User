using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Caching;
using AiUo.Data;
using AiUo.Extensions.StackExchangeRedis;
using UGame.User.Common;

namespace UGame.User.Common.Caching
{
    public class OperatorUserIdDCache : RedisStringClient<string>
    {
        private const int EXPIRE_DAYS = 3; // 缓存有效期
        public string OperatorId { get; set; }
        public string OperatorUserId { get; set; }
        public OperatorUserIdDCache(string operatorId, string operatorUserId)
        {
            if(string.IsNullOrEmpty(operatorId))
            OperatorId = operatorId;
            OperatorUserId = operatorUserId;
            RedisKey = GetGlobalGroupRedisKey("Partner", $"{OperatorId}:{OperatorUserId}");
        }
        //private string GetKey() => $"{OperatorId}:{OperatorUserId}";
        protected override async Task<CacheValue<string>> LoadValueWhenRedisNotExistsAsync()
        {
            foreach (var mo in DbSink.GetUserMoList())
            {
                var where = $"OperatorID='{OperatorId}' and OperatorUserId='{OperatorUserId}'";
                var row = await mo.GetSingleRowAsync("UserID", where);
                if (row != null)
                {
                    return new CacheValue<string>(row.ToString(0));
                }
            }
            return new CacheValue<string>(false);
        }

        public async Task<string> GetUserId()
        {
            var ret = await GetOrLoadAsync(false, TimeSpan.FromDays(EXPIRE_DAYS));
            return ret.Value;
        }
        public async Task SetUserId(string userId)
        {
            await SetAndExpireDaysAsync(userId, EXPIRE_DAYS);
        }
    }
}
