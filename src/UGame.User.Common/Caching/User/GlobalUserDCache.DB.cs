using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Caching;
using UGame.User.Repository;
using Xxyy.Common;

namespace UGame.User.Common.Caching
{
    public partial class GlobalUserDCache
    {
        #region s_user
        #region UserMode
        private const string Key_UserMode = "UserMode";
        public Task<UserMode> GetUserModeAsync() => GetOrExceptionAsync<UserMode>(Key_UserMode);
        public Task SetUserModeAsync(UserMode value) => SetAsync(Key_UserMode, value);
        #endregion

        #region OAuthType
        private const string Key_OAuthType = "OAuthType";
        public Task<int> GetOAuthTypeAsync() => GetOrExceptionAsync<int>(Key_OAuthType);
        public Task SetOAuthTypeAsync(int value) => SetAsync(Key_OAuthType, value);
        #endregion

        #region OAuthID
        private const string Key_OAuthID = "OAuthID";
        public Task<string> GetOAuthIDAsync() => GetOrExceptionAsync<string>(Key_OAuthID);
        public Task SetOAuthIDAsync(string value) => SetAsync(Key_OAuthID, value);
        #endregion

        #region Nickname
        private const string Key_Nickname = "Nickname";
        public Task<string> GetNicknameAsync() => GetOrExceptionAsync<string>(Key_Nickname);
        public Task SetNicknameAsync(string value) => SetAsync(Key_Nickname, value);
        #endregion

        #region FromMode
        private const string Key_FromMode = "FromMode";
        public Task<int> GetFromModeAsync() => GetOrExceptionAsync<int>(Key_FromMode);
        public Task SetFromModeAsync(int value) => SetAsync(Key_FromMode, value);
        #endregion

        #region FromId
        private const string Key_FromId = "FromId";
        public Task<string> GetFromIdAsync() => GetOrExceptionAsync<string>(Key_FromId);
        public Task SetFromIdAsync(string value) => SetAsync(Key_FromId, value);
        #endregion

        #region DomainId
        private const string Key_DomainId = "DomainId";
        public Task<string> GetDomainIdAsync() => GetOrDefaultAsync<string>(Key_DomainId, null);
        public Task SetDomainIdAsync(string value) => SetAsync(Key_DomainId, value);
        #endregion


        #region OperatorId
        private const string Key_OperatorId = "OperatorId";
        public Task<string> GetOperatorIdAsync() => GetOrExceptionAsync<string>(Key_OperatorId);
        public Task SetOperatorIdAsync(string value) => SetAsync(Key_OperatorId, value);
        #endregion

        #region OperatorUserId
        private const string Key_OperatorUserId = "OperatorUserId";
        public Task<string> GetOperatorUserIdAsync() => GetOrExceptionAsync<string>(Key_OperatorUserId);
        public Task SetOperatorUserIdAsync(string value) => SetAsync(Key_OperatorUserId, value);
        #endregion

        #region CountryId
        private const string Key_CountryId = "CountryId";
        public Task<string> GetCountryIdAsync() => GetOrExceptionAsync<string>(Key_CountryId);
        public Task SetCountryIdAsync(string value) => SetAsync(Key_CountryId, value);
        #endregion

        #region CurrencyId
        private const string Key_CurrencyId = "CurrencyId";
        public Task<string> GetCurrencyIdAsync() => GetOrExceptionAsync<string>(Key_CurrencyId);
        public Task SetCurrencyIdAsync(string value) => SetAsync(Key_CurrencyId, value);
        #endregion

        #region UserKind
        private const string Key_UserKind = "UserKind";
        public Task<UserKind> GetUserKindAsync() => GetOrExceptionAsync<UserKind>(Key_UserKind);
        public Task SetUserKindAsync(UserKind value) => SetAsync(Key_UserKind, value);
        #endregion

        #region Vip
        private const string Key_Vip = "Vip";
        public Task<int> GetVipAsync() => GetOrExceptionAsync<int>(Key_Vip);
        public Task SetVipAsync(int value) => SetAsync(Key_Vip, value);
        #endregion

        #region PUserID1
        private const string Key_PUserID1 = "PUserID1";
        public Task<string> GetPUserID1Async() => GetOrDefaultAsync<string>(Key_PUserID1, null);
        public Task SetPUserID1Async(string value) => SetAsync(Key_PUserID1, value);
        #endregion

        #region PUserID2
        private const string Key_PUserID2 = "PUserID2";
        public Task<string> GetPUserID2Async() => GetOrDefaultAsync<string>(Key_PUserID2, null);
        public Task SetPUserID2Async(string value) => SetAsync(Key_PUserID2, value);
        #endregion

        #region GAID
        private const string Key_GAID = "GAID";
        public Task<string> GetGAIDAsync() => GetOrDefaultAsync<string>(Key_GAID, null);
        #endregion

        #region UserIp
        private const string Key_RegistUserIp = "RegistUserIp";
        public Task<string> GetRegistUserIpAsync() => GetOrDefaultAsync<string>(Key_RegistUserIp, null);
        #endregion

        #region ClientUrl
        private const string Key_RegistClientUrl = "RegistClientUrl";
        public Task<string> GetRegistClientUrlAsync() => GetOrDefaultAsync<string>(Key_RegistClientUrl, null);
        #endregion

        #region UserStatus
        private const string Key_UserStatus = "UserStatus";
        public Task<UserStatus> GetUserStatusAsync() => GetOrExceptionAsync<UserStatus>(Key_UserStatus);
        public Task SetUserStatusAsync(UserStatus value) => SetAsync(Key_UserStatus, value);
        #endregion

        #region RegistDate
        private const string Key_RegistDate = "RegistDate";
        public Task<DateTime?> GetRegistDateAsync() => GetOrDefaultAsync<DateTime?>(Key_RegistDate, null);
        public Task SetRegistDateAsync(DateTime value) => SetAsync(Key_RegistDate, value);
        #endregion

        #region LastLoginDate
        private const string Key_LastLoginDate = "LastLoginDate"; // 最后一次登录时间
        public Task<DateTime> GetLastLoginDateAsync() => GetOrDefaultAsync(Key_LastLoginDate, DateTime.MinValue);
        public Task SetLastLoginDateAsync(DateTime value) => SetAsync(Key_LastLoginDate, value);
        #endregion

        #region Mobile
        private const string Key_Mobile = "Mobile";
        public Task<string> GetMobileAsync() => GetOrExceptionAsync<string>(Key_Mobile);
        public Task SetMobileAsync(string value) => SetAsync(Key_Mobile, value);
        #endregion

        #region Email
        private const string Key_Email = "Email";
        public Task<string> GetEmailAsync() => GetOrExceptionAsync<string>(Key_Email);
        public Task SetEmailAsync(string value) => SetAsync(Key_Email, value);
        #endregion

        #region Username
        private const string Key_Username = "Username";
        public Task<string> GetUsernameAsync() => GetOrExceptionAsync<string>(Key_Username);
        public Task SetUsernameAsync(string value) => SetAsync(Key_Username, value);
        #endregion

        #region HasBet
        private const string Key_HasBet = "HasBet";
        public Task<bool> GetHasBetAsync() => GetOrDefaultAsync(Key_HasBet, false);
        public Task SetHasBetAsync(bool value = true) => SetAsync(Key_HasBet, value);
        #endregion

        #region HasPay
        public const string Key_HasPay = "HasPay";
        public Task<bool> GetHasPayAsync() => GetOrDefaultAsync(Key_HasPay, false);
        public Task SetHasPayAsync() => SetAsync(Key_HasPay, true);
        #endregion

        #region HasCash
        public const string Key_HasCash = "HasCash";
        public Task<bool> GetHasCashAsync() => GetOrDefaultAsync(Key_HasCash, false);
        public Task SetHasCashAsync() => SetAsync(Key_HasCash, true);
        #endregion
        #endregion

        #region s_user_ex
        #endregion

        public async Task SetBaseValues(S_userEO user, S_user_exEO userEx = null)
        {
            var values = new Dictionary<string, CacheItem<object>>
            {
                { Key_UserMode, new CacheItem<object>(user.UserMode.ToEnum(UserMode.Unknow))},
                { Key_OAuthType, new CacheItem<object>(user.OAuthType) },
                { Key_OAuthID, new CacheItem<object>(user.OAuthID) },
                { Key_Nickname, new CacheItem<object>(user.Nickname) },
                { Key_FromMode, new CacheItem<object>(user.FromMode) },
                { Key_FromId, new CacheItem<object>(user.FromId) },
                { Key_DomainId, new CacheItem<object>(user.DomainID) },
                { Key_OperatorId, new CacheItem <object>(user.OperatorID) },
                { Key_OperatorUserId, new CacheItem <object>(user.OperatorUserId) },
                { Key_CountryId, new CacheItem <object>(user.CountryID)},
                { Key_CurrencyId, new CacheItem <object>(user.CurrencyID)},
                { Key_UserKind, new CacheItem<object>(user.UserKind.ToEnum(UserKind.Unknow)) },
                { Key_Vip, new CacheItem <object>(user.VIP)},
                { Key_PUserID1, new CacheItem <object>(user.PUserID1)},
                { Key_PUserID2, new CacheItem <object>(user.PUserID2)},
                { Key_GAID, new CacheItem<object>(user.GAID) },
                { Key_RegistUserIp, new CacheItem<object>(user.UserIp) },
                { Key_RegistClientUrl, new CacheItem<object>(user.ClientUrl) },
                { Key_UserStatus, new CacheItem<object>(user.Status.ToEnum(UserStatus.Unknown)) },
                { Key_RegistDate, new CacheItem<object>(user.RegistDate) },
                { Key_LastLoginDate, new CacheItem<object>(user.LastLoginDate) },

                { Key_Mobile, new CacheItem<object>(user.Mobile) },
                { Key_Email, new CacheItem<object>(user.Email) },
                { Key_Username, new CacheItem<object>(user.Username) },

                { Key_HasBet, new CacheItem<object>(user.HasBet) },
                { Key_HasPay, new CacheItem<object>(user.HasPay) },
                { Key_HasCash, new CacheItem<object>(user.HasCash) },
                { Key_LoadFromDbDate, new CacheItem<object>(DateTime.UtcNow) },
            };
            //userEx ??= await DbSink.BuildUserExMo(user.UserID).GetByPKAsync(user.UserID);
            //if (userEx != null)
            //{
            //}

            await SetAsync(values);
            await KeyExpireDaysAsync(EXPIRE_DAYS);
        }

        #region LoadFromDbDate
        private const string Key_LoadFromDbDate = "LoadFromDbDate";
        public Task<DateTime?> GetLoadFromDbDateAsync() => GetOrDefaultAsync<DateTime?>(Key_LoadFromDbDate, null);
        #endregion
    }
}
