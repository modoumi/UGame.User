using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Caching;
using UGame.User.Repository;

namespace UGame.User.Common.Caching
{
    public partial class UserAppDCache
    {
        #region LastLoginDate
        private const string Key_LastLoginDate = "LastLoginDate"; // 最后一次登录时间
        public Task<DateTime> GetLastLoginDateAsync() => GetOrExceptionAsync<DateTime>(Key_LastLoginDate);
        public Task SetLastLoginDateAsync(DateTime value) => SetAsync(Key_LastLoginDate, value);
        #endregion

        #region Status
        private const string Key_Status = "Status";
        public Task<int> GetStatusAsync() => GetOrExceptionAsync<int>(Key_Status);
        public Task SetStatusAsync(int value) => SetAsync(Key_Status, value);
        #endregion

        public async Task SetBaseValues(S_user_appEO userApp)
        {
            var values = new Dictionary<string, CacheItem<object>>
            {
                { Key_LastLoginDate, new CacheItem<object>(userApp.LastLoginDate) },
                { Key_Status, new CacheItem<object>(userApp.Status) },
                { Key_LoadFromDbDate, new CacheItem<object>(DateTime.UtcNow) },
            };
            await SetAsync(values);
            await KeyExpireDaysAsync(EXPIRE_DAYS);
        }

        #region LoadFromDbDate
        private const string Key_LoadFromDbDate = "LoadFromDbDate";
        public Task<DateTime?> GetLoadFromDbDateAsync() => GetOrDefaultAsync<DateTime?>(Key_LoadFromDbDate, null);
        #endregion
    }
}
