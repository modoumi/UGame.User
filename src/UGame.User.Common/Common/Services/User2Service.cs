using Org.BouncyCastle.Utilities;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Data;
using AiUo.Data.SqlSugar;
using UGame.User.Common.Caching;
using UGame.User.Repository;
using Xxyy.Common;

namespace UGame.User.Common.Services
{
    public class User2Service
    {
        public string UserId { get; set; }
        public User2Service(string userId)
        {
            UserId = userId;
        }

        #region GetBalance
        public async Task<BalanceInfo> GetBalanceInfo(bool useBonus = false, DbTransactionManager tm = null)
        {
            //"Cash, Bonus,Coin,Gold,SWB,Point"
            var row = await GetDb(tm).Queryable<S_userPO>()
                .Select(it => new S_userPO
                {
                    Cash = it.Cash,
                    Bonus = it.Bonus,
                    Coin = it.Coin,
                    Gold = it.Gold,
                    SWB = it.SWB,
                    Point = it.Point
                }).SingleAsync(it => it.UserID == UserId);
            if (row == null)
                throw new Exception($"UserId不存在: {UserId}");
            var ret = new BalanceInfo
            {
                Balance = row.Cash,
                Bonus = row.Bonus,
                Coin = row.Coin,
                Gold = row.Gold,
                SWB = row.SWB,
                Point = row.Point,
            };
            ret.ValidAmount = useBonus ? ret.Balance : ret.Balance - ret.Bonus;
            if (ret.ValidAmount < 0)
                throw new Exception("Cash-Bonus负数，账户异常");
            return ret;
        }

        public async Task<long> GetBonus(DbTransactionManager tm = null)
        {
            return await GetDb(tm).Queryable<S_userPO>()
                .Where(it => it.UserID == UserId)
                .Select(it => it.Bonus).SingleAsync();
        }
        public async Task<long> GetBalance(bool useBonus = false, DbTransactionManager tm = null)
        {
            var ret = await GetBalanceInfo(useBonus, tm);
            return ret.ValidAmount;
        }
        public async Task<long> GetCoin(DbTransactionManager tm = null)
        {
            return await GetDb(tm).Queryable<S_userPO>()
                .Where(it => it.UserID == UserId)
                .Select(it => it.Coin).SingleAsync();
        }
        #endregion

        #region UpdateBalance
        public async Task<bool> UpdateBalance(string currencyId, long changeAmount, long changeBonus = 0, DbTransactionManager tm = null)
            => await UpdateBalanceCore(currencyId, changeAmount, 0, changeBonus, tm);
        public async Task<bool> UpdateBalanceByBet(string currencyId, long betAmount, long changeBonus = 0, DbTransactionManager tm = null)
        {
            if (betAmount < 0)
                throw new Exception("UpdateBalanceByBet时，betAmount不能小于0");
            var changeAmount = -betAmount;
            return await UpdateBalanceCore(currencyId, changeAmount, 0, changeBonus, tm);
        }
        public async Task<bool> UpdateBalanceByWin(string currencyId, long winAmount,long changeBonus = 0, DbTransactionManager tm = null)
        {
            if (winAmount < 0)
                throw new Exception("UpdateBalanceByWin时，winAmount不能小于0");
            var changeAmount = winAmount;
            return await UpdateBalanceCore(currencyId, changeAmount, 0, changeBonus, tm);
        }
        public async Task<bool> UpdateBalanceByBetWin(string currencyId, long betAmount, long winAmount,long changeBonus = 0, DbTransactionManager tm = null)
        {
            if (betAmount < 0)
                throw new Exception("UpdateBalanceByBetWin时，betAmount不能小于0");
            if (winAmount < 0)
                throw new Exception("UpdateBalanceByBetWin时，winAmount不能小于0");
            var changeAmount = winAmount - betAmount;
            return await UpdateBalanceCore(currencyId, changeAmount, betAmount, changeBonus, tm);
        }
        public async Task<bool> UpdateBalanceByRollback(string currencyId, long refererBetAmount, long refererWinAmount,long changeBonus = 0, DbTransactionManager tm = null)
        {
            if (refererBetAmount < 0)
                throw new Exception("UpdateBalanceByRollback时，refererBetAmount不能小于0");
            if (refererWinAmount < 0)
                throw new Exception("UpdateBalanceByRollback时，refererWinAmount不能小于0");
            var changeAmount = refererBetAmount - refererWinAmount;
            return await UpdateBalanceCore(currencyId, changeAmount, 0, changeBonus, tm);
        }
        public async Task<bool> UpdateBalanceCore(string currencyId, long changeAmount, long betAmount,long changeBonus = 0, DbTransactionManager tm = null)
        {
            if (Math.Abs(changeAmount) < Math.Abs(changeBonus))
                throw new Exception("UpdateBalance时,changeAmount绝对值必须大于changeBonus");
            if (changeAmount == 0 && betAmount == 0)
                return true;
            if (betAmount < 0)
                throw new Exception("UpdateBalance时,betAmount不能小于0");

            var ctype = DbCacheUtil.GetCurrencyType(currencyId);

            var client = GetDb(tm).Updateable<S_userPO>();
            switch (ctype)
            {
                case CurrencyType.Coin:
                    client.SetColumns(it => it.Coin == it.Coin + changeAmount);
                    break;
                case CurrencyType.Gold:
                    client.SetColumns(it => it.Gold == it.Gold + changeAmount);
                    break;
                case CurrencyType.Point:
                    client.SetColumns(it => it.Point == it.Point + changeAmount);
                    break;
                case CurrencyType.SWB:
                    client.SetColumns(it => it.SWB == it.SWB + changeAmount);
                    break;
                case CurrencyType.Cash:
                    client.SetColumns(it => it.Cash == it.Cash + changeAmount);
                    break;
            }
            if (ctype == CurrencyType.Cash && changeBonus != 0)
                client.SetColumns(it => it.Bonus == it.Bonus + changeBonus);

            var where = $"UserId='{UserId}' ";
            if (betAmount > 0)
            {
                where += (ctype == CurrencyType.Cash && changeBonus==0)
                   ? $" and {ctype}-Bonus>={betAmount}"
                   : $" and {ctype}>={betAmount}";
            }
            where += (ctype == CurrencyType.Cash && changeBonus==0)
                ? $" and {ctype}+{changeAmount}-Bonus>=0"
                : $" and {ctype}+{changeAmount}>=0";
            if (ctype == CurrencyType.Cash && changeBonus != 0)
            {
                where += $" and Bonus+{changeBonus}>=0";
            }
            var ret = await client.Where(where).ExecuteCommandAsync();
            if (changeAmount == 0 && changeBonus == 0 && betAmount > 0 && ret == 0)
                return true;
            return ret == 1;
        }

        public async Task<bool> UpdateCoin(long changeCoin, DbTransactionManager tm = null)
        {
            if (changeCoin == 0)
                return true;
            var ret = await GetDb(tm).Updateable<S_userPO>()
                .SetColumns(it => it.Coin == it.Coin + changeCoin)
                .Where(it => it.UserID == UserId && it.Coin + changeCoin >= 0)
                .ExecuteCommandAsync();
            return ret == 1;
        }
        #endregion

        private ISqlSugarClient GetDb(DbTransactionManager tm = null)
        {
            return tm != null
                ? tm.GetDb<S_userPO>()
                : DbUtil.GetDb<S_userPO>();
        }
    }
}
