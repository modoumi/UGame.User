using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using AiUo.Extensions.StackExchangeRedis;

namespace UGame.User.Common.Caching
{
    public class DayUserDCache : RedisHashClient
    {
        #region Constructors
        private const int EXPIRE_DAYS = 30; // 缓存有效期
        public int DayId { get; }
        public string UserId { get; }
        private DayUserDCache(int dayId, string userId)
        {
            if (string.IsNullOrEmpty(userId))
                throw new ArgumentNullException("UserDayDCache: userId不能为空");
            if (dayId == 0)
                throw new ArgumentNullException("UserDayDCache: dayId不能为0");
            UserId = userId;
            DayId = dayId;
            RedisKey = GetGlobalGroupRedisKey("PerDay", $"{DayId}:{UserId}");
        }
        public static async Task<DayUserDCache> Create(DateTime day, string userId)
        {
            var dayId = day.ToString("yyyyMMdd").ToInt32();
            return await Create(dayId, userId);
        }
        public static async Task<DayUserDCache> Create(int dayId, string userId)
        {
            var ret = new DayUserDCache(dayId, userId);
            if (!await ret.KeyExistsAsync())
            {
                // 加载数据
                await ret.KeyExpireAsync(TimeSpan.FromDays(EXPIRE_DAYS));
            }
            return ret;
        }
        #endregion

        #region HasDataRow
        public const string Key_HasDataRow = "Key_HasDataRow";
        public async Task<bool> GetHasDataRow() => await GetOrDefaultAsync(Key_HasDataRow, false);
        public async Task SetHasDataRow(bool value = true) => await SetAsync(Key_HasDataRow, value);
        #endregion

        #region s_provider_order
        #region IsNewBet
        private const string Key_IsNewBet = "IsNewBet";
        public async Task<bool> GetIsNewBet() => await GetOrDefaultAsync(Key_IsNewBet, false);
        public async Task SetIsNewBet(bool value = true) => await SetAsync(Key_IsNewBet, value);
        #endregion

        #region HasBet
        private const string Key_HasBet = "HasBet";
        public async Task<bool> GetHasBet() => await GetOrDefaultAsync(Key_HasBet, false);
        public async Task SetHasBet(bool value = true) => await SetAsync(Key_HasBet, value);
        #endregion

        #region BetCount
        private const string Key_BetCount = "BetCount";
        public async Task<int> GetBetCount() => await GetOrDefaultAsync(Key_BetCount, 0);
        public async Task IncrBetCount() => await IncerementAsync(Key_BetCount);
        #endregion

        #region BetAmount
        private const string Key_BetAmount = "BetAmount";
        public async Task<long> GetBetAmount() => await GetOrDefaultAsync(Key_BetAmount, 0L);
        public async Task AddBetAmount(long value) => await IncerementAsync(Key_BetAmount, value);
        #endregion

        #region BetBonus
        private const string Key_BetBonus = "BetBonus";
        public async Task<long> GetBetBonus() => await GetOrDefaultAsync(Key_BetBonus, 0L);
        public async Task AddBetBonus(long value) => await IncerementAsync(Key_BetBonus, value);
        #endregion

        #region WinAmount
        private const string Key_WinAmount = "WinAmount";
        public async Task<long> GetWinAmount() => await GetOrDefaultAsync(Key_WinAmount, 0L);
        public async Task AddWinAmount(long value) => await IncerementAsync(Key_WinAmount, value);
        #endregion

        #region WinBonus
        private const string Key_WinBonus = "WinBonus";
        public async Task<long> GetWinBonus() => await GetOrDefaultAsync(Key_WinBonus, 0L);
        public async Task AddWinBonus(long value) => await IncerementAsync(Key_WinBonus, value);
        #endregion

        #endregion //

        #region currency_change
        #region ChangeCount
        private const string Key_ChangeCount = "ChangeCount";
        public async Task<int> GetChangeCount() => await GetOrDefaultAsync(Key_ChangeCount, 0);
        public async Task IncrChangeCount() => await IncerementAsync(Key_ChangeCount);
        #endregion

        #region ChangeAmount
        private const string Key_ChangeAmount = "ChangeAmount";
        public async Task<long> GetChangeAmount() => await GetOrDefaultAsync(Key_ChangeAmount, 0L);
        public async Task AddChangeAmount(long value) => await IncerementAsync(Key_ChangeAmount, value);
        #endregion

        #region ChangeBonus
        private const string Key_ChangeBonus = "ChangeBonus";
        public async Task<long> GetChangeBonus() => await GetOrDefaultAsync(Key_ChangeBonus, 0L);
        public async Task AddChangeBonus(long value) => await IncerementAsync(Key_ChangeBonus, value);
        #endregion
        #endregion //

        #region s_bank_order

        #region IsNewPay
        private const string Key_IsNewPay = "IsNewPay";
        public async Task<bool> GetIsNewPay() => await GetOrDefaultAsync(Key_IsNewPay, false);
        public async Task SetIsNewPay(bool value = true) => await SetAsync(Key_IsNewPay, value);
        #endregion

        #region HasPay
        private const string Key_HasPay = "HasPay";
        public async Task<bool> GetHasPay() => await GetOrDefaultAsync(Key_HasPay, false);
        public async Task SetHasPay(bool value = true) => await SetAsync(Key_HasPay, value);
        #endregion

        #region PayCount
        private const string Key_PayCount = "PayCount";
        public async Task<int> GetPayCount() => await GetOrDefaultAsync(Key_PayCount, 0);
        public async Task IncrPayCount() => await IncerementAsync(Key_PayCount);
        #endregion

        #region PayAmount
        private const string Key_PayAmount = "PayAmount";
        public async Task<long> GetPayAmount() => await GetOrDefaultAsync(Key_PayAmount, 0L);
        public async Task AddPayAmount(long value) => await IncerementAsync(Key_PayAmount, value);
        #endregion

        #region IsNewCash
        private const string Key_IsNewCash = "IsNewCash";
        public async Task<bool> GetIsNewCash() => await GetOrDefaultAsync(Key_IsNewCash, false);
        public async Task SetIsNewCash(bool value = true) => await SetAsync(Key_IsNewCash, value);
        #endregion

        #region HasCash
        private const string Key_HasCash = "HasCash";
        public async Task<bool> GetHasCash() => await GetOrDefaultAsync(Key_HasCash, false);
        public async Task SetHasCash(bool value = true) => await SetAsync(Key_HasCash, value);
        #endregion

        #region CashCount
        private const string Key_CashCount = "CashCount";
        public async Task<int> GetCashCount() => await GetOrDefaultAsync(Key_CashCount, 0);
        public async Task IncrCashCount() => await IncerementAsync(Key_CashCount);
        #endregion

        #region CashAmount
        private const string Key_CashAmount = "CashAmount";
        public async Task<long> GetCashAmount() => await GetOrDefaultAsync(Key_CashAmount, 0L);
        public async Task AddCashAmount(long value) => await IncerementAsync(Key_CashAmount, value);
        #endregion

        #endregion

        public async Task SetValues(UserDayDO data)
        {
            var values = new Dictionary<string, object>()
            {
                {Key_IsNewBet, data.IsNewBet },
                {Key_HasBet, data.HasBet },
                {Key_BetCount, data.BetCount },
                {Key_BetAmount, data.BetAmount },
                {Key_BetBonus, data.BetBonus },
                {Key_WinAmount, data.WinAmount },
                {Key_WinBonus, data.WinBonus },
                {Key_ChangeCount, data.ChangeCount },
                {Key_ChangeAmount, data.ChangeAmount },
                {Key_ChangeBonus, data.ChangeBonus },
                {Key_IsNewPay, data.IsNewPay },
                {Key_HasPay, data.HasPay },
                {Key_PayCount, data.PayCount },
                {Key_PayAmount, data.PayAmount },
                {Key_IsNewCash, data.IsNewCash },
                {Key_HasCash, data.HasCash },
                {Key_CashCount, data.CashCount },
                {Key_CashAmount, data.CashAmount },
            };
            await SetAsync(values);
        }
    }
    public class UserDayDO
    {
        public bool IsNewBet { get; set; }
        public bool HasBet { get; set; }
        public int BetCount { get; set; }
        public long BetAmount { get; set; }
        public long BetBonus { get; set; }
        public long WinAmount { get; set; }
        public long WinBonus { get; set; }
        public int ChangeCount { get; set; }
        public long ChangeAmount { get; set; }
        public long ChangeBonus { get; set; }
        public bool IsNewPay { get; set; }
        public bool HasPay { get; set; }
        public int PayCount { get; set; }
        public long PayAmount { get; set; }
        public bool IsNewCash { get; set; }
        public bool HasCash { get; set; }
        public int CashCount { get; set; }
        public long CashAmount { get; set; }
    }
}
