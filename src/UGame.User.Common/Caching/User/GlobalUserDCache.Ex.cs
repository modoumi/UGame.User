using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Net;

namespace UGame.User.Common.Caching
{
    public partial class GlobalUserDCache
    {
        #region TryLoginData
        private const string Key_TryLoginData = "TryLoginData";
        /// <summary>
        /// 30分钟内共允许尝试5次登录
        /// </summary>
        /// <returns></returns>
        public async Task<bool> CheckAllowLoginAsync()
        {
            var data = await GetOrDefaultAsync(Key_TryLoginData, new TryLoginData());
            if ((DateTime.UtcNow - data.LastTryDate).TotalMinutes > 30)
            {
                data.TryCount = 0;
            }
            data.LastTryDate = DateTime.UtcNow;
            data.TryCount++;
            await SetAsync(Key_TryLoginData, data);
            return data.TryCount <= 5;
        }
        public async Task LoginSuccessAsync()
        {
            await DeleteAsync(Key_TryLoginData);
        }
        #endregion

        #region LoginDays
        private const string Key_LoginDays = "LoginDays"; //连续登录天数
        public Task<int> GetLoginDaysAsync() => GetOrDefaultAsync(Key_LoginDays, 0);
        public Task SetLoginDaysAsync(int value) => SetAsync(Key_LoginDays, value);
        #endregion

        #region LastCashDate
        private const string Key_LastCashDate = "LastCashDate";
        public Task<DateTime> GetLastCashDateAsync() => GetOrDefaultAsync(Key_LastCashDate, DateTime.MinValue);
        public Task SetLastCashDateAsync(DateTime value) => SetAsync(Key_LastCashDate, value);
        #endregion
    }

    public class TryLoginData
    {
        public int TryCount { get; set; }
        public DateTime LastTryDate { get; set; }
    }
}
