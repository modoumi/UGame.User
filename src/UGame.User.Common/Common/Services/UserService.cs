using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UGame.User.Common;
using AiUo.Data;
using UGame.User.Common.Caching;
using UGame.User.Repository;
using Xxyy.Common;

namespace UGame.User.Common.Services
{
    [Obsolete]
    public class UserService
    {
        public string UserId { get; set; }
        public UserService(string userId)
        {
            UserId = userId;
        }
        /// <summary>
        /// 获取余额
        /// </summary>
        /// <param name="currencyId"></param>
        /// <param name="tm"></param>
        /// <param name="useBonus">是否使用bonus（bonus不参与第三方游戏，传入false）</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<long> GetBalance(string currencyId, TransactionManager tm = null, bool useBonus = false)
        {
            var ctype = DbCacheUtil.GetCurrencyType(currencyId);
            var userMo = GetUserMo();
            switch (ctype)
            {
                case CurrencyType.Cash:
                    if (useBonus)
                        return await userMo.GetCashByPKAsync(UserId, tm);
                    else
                    {
                        var row = await userMo.GetSingleRowAsync("Cash, Bonus", $"UserId='{UserId}'", null, null, tm);
                        var ret = row.ToInt64("Cash") - row.ToInt64("Bonus");
                        //if (ret < 0)
                        //    throw new Exception("Cash-Bonus负数，账户异常");
                        return ret;
                    }
                case CurrencyType.Coin:
                    return await userMo.GetCoinByPKAsync(UserId, tm);
                case CurrencyType.Gold:
                    return await userMo.GetGoldByPKAsync(UserId, tm);
                case CurrencyType.Point:
                    return await userMo.GetPointByPKAsync(UserId, tm);
                case CurrencyType.SWB:
                    return await userMo.GetSWBByPKAsync(UserId, tm);
                default:
                    throw new Exception("未知的ctype");
            }
        }

        public async Task<long> GetBonus(TransactionManager tm = null)
            => await GetUserMo().GetBonusByPKAsync(UserId, tm);

        public async Task<BalanceInfo> GetBalanceInfo(TransactionManager tm = null, bool useBonus = false)
        {
            var userMo = GetUserMo();
            var row = await userMo.GetSingleRowAsync("Cash, Bonus,Coin,Gold,SWB,Point", $"UserId='{UserId}'", null, null, tm);
            var ret = new BalanceInfo
            {
                Balance = row.ToInt64("Cash"),
                Bonus = row.ToInt64("Bonus"),
                Coin = row.ToInt64("Coin"),
                Gold = row.ToInt64("Gold"),
                SWB = row.ToInt64("SWB"),
                Point = row.ToInt64("Point"),
            };
            ret.ValidAmount = useBonus ? ret.Balance : ret.Balance - ret.Bonus;
            //if (ret.ValidAmount < 0)
            //    throw new Exception("Cash-Bonus负数，账户异常");
            return ret;
        }

        #region UpdateBalance
        public async Task<bool> UpdateBalance(string currencyId, long changeAmount, TransactionManager tm = null, long changeBonus = 0)
            => await UpdateBalanceCore(currencyId, changeAmount, 0, tm, changeBonus);
        public async Task<bool> UpdateBalanceByBet(string currencyId, long betAmount, TransactionManager tm = null, long changeBonus = 0)
        {
            if (betAmount < 0)
                throw new Exception("UpdateBalanceByBet时，betAmount不能小于0");
            var changeAmount = -betAmount;
            return await UpdateBalanceCore(currencyId, changeAmount, 0, tm, changeBonus);
        }
        public async Task<bool> UpdateBalanceByWin(string currencyId, long winAmount, TransactionManager tm = null,long changeBonus = 0)
        {
            if (winAmount < 0)
                throw new Exception("UpdateBalanceByWin时，winAmount不能小于0");
            var changeAmount = winAmount;
            return await UpdateBalanceCore(currencyId, changeAmount, 0, tm, changeBonus);
        }
        public async Task<bool> UpdateBalanceByBetWin(string currencyId, long betAmount, long winAmount, TransactionManager tm = null, long changeBonus = 0)
        {
            if (betAmount < 0)
                throw new Exception("UpdateBalanceByBetWin时，betAmount不能小于0");
            if (winAmount < 0)
                throw new Exception("UpdateBalanceByBetWin时，winAmount不能小于0");
            var changeAmount = winAmount - betAmount;
            return await UpdateBalanceCore(currencyId, changeAmount, betAmount, tm, changeBonus);
        }
        public async Task<bool> UpdateBalanceByRollback(string currencyId, long refererBetAmount, long refererWinAmount, TransactionManager tm = null, long changeBonus = 0)
        {
            if (refererBetAmount < 0)
                throw new Exception("UpdateBalanceByRollback时，refererBetAmount不能小于0");
            if (refererWinAmount < 0)
                throw new Exception("UpdateBalanceByRollback时，refererWinAmount不能小于0");
            var changeAmount = refererBetAmount - refererWinAmount;
            return await UpdateBalanceCore(currencyId, changeAmount, 0, tm, changeBonus);
        }

        /// <summary>
        /// hub88回滚时允许账户为负
        /// </summary>
        /// <param name="currencyId"></param>
        /// <param name="refererBetAmount"></param>
        /// <param name="refererWinAmount"></param>
        /// <param name="tm"></param>
        /// <param name="changeBonus"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<bool> UpdateBalanceByRollbackForHub88(string currencyId, long refererBetAmount, long refererWinAmount, TransactionManager tm = null, long changeBonus = 0)
        {
            if (refererBetAmount < 0)
                throw new Exception("UpdateBalanceByRollback时，refererBetAmount不能小于0");
            if (refererWinAmount < 0)
                throw new Exception("UpdateBalanceByRollback时，refererWinAmount不能小于0");
            var changeAmount = refererBetAmount - refererWinAmount;
            return await UpdateBalanceCoreForHub88(currencyId, changeAmount, 0, tm, changeBonus);
        }

        /// <summary>
        /// hub88更新余额
        /// </summary>
        /// <param name="currencyId"></param>
        /// <param name="changeAmount">变化</param>
        /// <param name="betAmount"></param>
        /// <param name="tm"></param>
        /// <param name="changeBonus">bonus的变动金额</param>
        /// <returns></returns>
        private async Task<bool> UpdateBalanceCoreForHub88(string currencyId, long changeAmount, long betAmount, TransactionManager tm = null, long changeBonus = 0)
        {
            if (Math.Abs(changeAmount) < Math.Abs(changeBonus))
                throw new Exception("UpdateBalance时,changeAmount绝对值必须大于changeBonus");
            //if (!useBonus && changeBonus != 0)
            //    throw new Exception("UpdateBalance时,不使用bonus时changeBonus必须=0");
            if (changeAmount == 0 && betAmount == 0)
                return true;
            if (betAmount < 0)
                throw new Exception("UpdateBalance时,betAmount不能小于0");

            var ctype = DbCacheUtil.GetCurrencyType(currencyId);

            var set = $"{ctype}={ctype}+{changeAmount}";
            if (ctype == CurrencyType.Cash && changeBonus != 0)
                set += $",Bonus=Bonus+{changeBonus}";

            var where = $"UserId='{UserId}' ";
            var ret = await GetUserMo().PutAsync(set, where, tm);
            return ret == 1;
        }

        /// <summary>
        /// 更新余额
        /// </summary>
        /// <param name="currencyId"></param>
        /// <param name="changeAmount">变化</param>
        /// <param name="betAmount"></param>
        /// <param name="tm"></param>
        /// <param name="changeBonus">bonus的变动金额</param>
        /// <returns></returns>
        private async Task<bool> UpdateBalanceCore(string currencyId, long changeAmount, long betAmount, TransactionManager tm = null, long changeBonus = 0)
        {
            if (Math.Abs(changeAmount) < Math.Abs(changeBonus))
                throw new Exception("UpdateBalance时,changeAmount绝对值必须大于changeBonus");
            //if (!useBonus && changeBonus != 0)
            //    throw new Exception("UpdateBalance时,不使用bonus时changeBonus必须=0");
            if (changeAmount == 0 && betAmount == 0)
                return true;
            if (betAmount < 0)
                throw new Exception("UpdateBalance时,betAmount不能小于0");

            var ctype = DbCacheUtil.GetCurrencyType(currencyId);

            var set = $"{ctype}={ctype}+{changeAmount}";
            if (ctype == CurrencyType.Cash && changeBonus != 0)
                set += $",Bonus=Bonus+{changeBonus}";

            var where = $"UserId='{UserId}' ";
            if (betAmount > 0)
            {
                where += (ctype == CurrencyType.Cash && changeBonus==0)
                   ? $" and {ctype}-Bonus>={betAmount}"
                   : $" and {ctype}>={betAmount}";
            }
            where += (ctype == CurrencyType.Cash && changeBonus == 0)
                ? $" and {ctype}+{changeAmount}-Bonus>=0"
                : $" and {ctype}+{changeAmount}>=0";
            if (ctype == CurrencyType.Cash && changeBonus != 0)
            {
                where += $" and Bonus+{changeBonus}>=0";
            }
            var ret = await GetUserMo().PutAsync(set, where, tm);
            if(changeAmount == 0 && changeBonus == 0 && betAmount > 0&&ret==0)
                return true;
            
            return ret == 1;
        }

        public async Task<bool> UpdateUserBonus(string currencyId, long changeBonus = 0, TransactionManager tm = null)
        {
            if (changeBonus == 0)
                return true;
            var ctype = DbCacheUtil.GetCurrencyType(currencyId);
            if (ctype != CurrencyType.Cash)
                return true;
            var set = $"Bonus=Bonus+{changeBonus}";
            var where = $"UserId='{UserId}' and (Bonus+{changeBonus})>=0 and {ctype}>=(Bonus+{changeBonus})";
            var ret = await GetUserMo().PutAsync(set, where, tm);
            return ret == 1;
        }

        #endregion

        #region Utils
        private S_userMO _userMo;
        public S_userMO GetUserMo()
            => _userMo ??= DbSink.BuildUserMo(UserId);
        private S_user_exMO _userExMo;
        public S_user_exMO GetUserExMo()
            => _userExMo ??= DbSink.BuildUserExMo(UserId);
        private S_requireflow_orderMO _requireflowOrderMo;
        public S_requireflow_orderMO GetRequireflowOrderMo()
            => _requireflowOrderMo ??= DbSink.BuildRequireFlowOrderMo(UserId);
        #endregion
    }

    public class BalanceInfo
    {
        public long Balance { get; set; }
        public long ValidAmount { get; set; }
        public long Bonus { get; set; }
        public long Coin { get; set; }
        public long Gold { get; set; }
        public long Point { get; set; }
        public long SWB { get; set; }
    }
}
