using MySqlX.XDevAPI.Common;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UGame.User.Service.Caching;
using UGame.User.Common;
using UGame.User.Common.Caching; 
using UGame.User.Repository;

namespace UGame.User.Service.Common
{
    internal class UserDaySummaryService
    {
        private S_user_dayMO _userDayMo = new();
        public async Task SetIsNew(S_user_dayEO userDayEo)
        {
            if (await ExistRow(userDayEo.UserID, userDayEo.DayID))
            {
                var setStr = $"IsLogin=true,IsNew=true";
                await _userDayMo.PutByPKAsync(userDayEo.DayID, userDayEo.UserID, setStr);
            }
            else
            {
                userDayEo.IsLogin = true;
                userDayEo.IsNew = true;
                userDayEo.RecDate = DateTime.UtcNow;
                await _userDayMo.AddAsync(userDayEo, null, true);
            }
        }
        public async Task SetIsRegister(S_user_dayEO userDayEo)
        {
            if (await ExistRow(userDayEo.UserID, userDayEo.DayID))
            {
                var setStr = $"IsLogin=true,IsRegister=true";
                if (userDayEo.RegistDate.HasValue)
                    setStr += $",RegistDate='{userDayEo.RegistDate.Value.ToString("yyyy-MM-dd HH:mm:ss")}'";
                await _userDayMo.PutByPKAsync(userDayEo.DayID, userDayEo.UserID, setStr);
            }
            else
            {
                userDayEo.IsLogin = true;
                userDayEo.IsRegister = true;
                userDayEo.RecDate = DateTime.UtcNow;
                await _userDayMo.AddAsync(userDayEo, null, true);
            }
        }
        public async Task SetIsLogin(S_user_dayEO userDayEo, int loginDays, DateTime lastLoginTime)
        {
            if (await ExistRow(userDayEo.UserID, userDayEo.DayID))
            {
                var setStr = $"IsLogin=true,LoginDays={loginDays},LastLoginTime='{lastLoginTime.ToString("yyyy-MM-dd HH:mm:ss")}'";
                await _userDayMo.PutByPKAsync(userDayEo.DayID, userDayEo.UserID, setStr);
            }
            else
            {
                userDayEo.IsLogin = true;
                userDayEo.LoginDays = loginDays;
                userDayEo.LastLoginTime = lastLoginTime;
                userDayEo.RecDate = DateTime.UtcNow;
                await _userDayMo.AddAsync(userDayEo, null, true);
            }
        }

        public async Task SetHasBet(S_user_dayEO userDayEo, bool isFirst)
        {
            if (await ExistRow(userDayEo.UserID, userDayEo.DayID))
            {
                var set = "HasBet=true";
                if (isFirst)
                    set += ",IsNewBet=true";
                await _userDayMo.PutByPKAsync(userDayEo.DayID, userDayEo.UserID, set);
            }
            else
            {
                userDayEo.IsNewBet = isFirst;
                userDayEo.HasBet = true;
                userDayEo.RecDate = DateTime.UtcNow;
                await _userDayMo.AddAsync(userDayEo, null, true);
            }
        }
        public async Task SetHasPay(S_user_dayEO userDayEo, bool isFirst)
        {
            if (await ExistRow(userDayEo.UserID, userDayEo.DayID))
            {
                var set = $"HasPay=true";
                if (isFirst)
                    set += ",IsNewPay=true";
                await _userDayMo.PutByPKAsync(userDayEo.DayID, userDayEo.UserID, set);
            }
            else
            {
                userDayEo.HasPay = true;
                userDayEo.IsNewPay = isFirst;
                userDayEo.RecDate = DateTime.UtcNow;
                await _userDayMo.AddAsync(userDayEo, null, true);
            }
        }
        public async Task SetHasCash(S_user_dayEO userDayEo, bool isFirst)
        {
            if (await ExistRow(userDayEo.UserID, userDayEo.DayID))
            {
                var set = $"HasCash=true";
                if (isFirst)
                    set += ",IsNewCash=true";
                await _userDayMo.PutByPKAsync(userDayEo.DayID, userDayEo.UserID, set);
            }
            else
            {
                userDayEo.HasCash = true;
                userDayEo.IsNewCash = isFirst;
                userDayEo.RecDate = DateTime.UtcNow;
                await _userDayMo.AddAsync(userDayEo, null, true);
            }
        }

        private async Task<bool> ExistRow(string userId, DateTime dayId)
        {
            var userDayDCache = await DayUserDCache.Create(dayId,userId);
            if (await userDayDCache.GetHasDataRow())
                return true;

            var eo = await _userDayMo.GetByPKAsync(dayId, userId);
            if (eo == null)
                return false;
            else
            {
                await userDayDCache.SetHasDataRow(true);
                return true;
            }
        }
    }
}
