using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using UGame.User.Common.Caching;
using UGame.User.Common;
using UGame.User.Repository;
using Xxyy.Common;

namespace UGame.User.Common.Contexts
{
    public class UserContext
    {
        private string _userId;
        public string UserId
        {
            get
            {
                if (string.IsNullOrEmpty(_userId))
                    throw new Exception("UserContext: UserId不能为空");
                return _userId;
            }
        }
        public void SetUserId(string userId)
            => _userId = userId;

        public UserContext(string userId)
        {
            _userId = userId;
        }

        #region MO & EO
        private S_userMO _userMo;
        public S_userMO GetUserMo()
            => _userMo ??= DbSink.BuildUserMo(UserId);

        private S_userEO _userEo;
        public async Task<S_userEO> GetUserEo()
            => _userEo ??= await GetUserMo().GetByPKAsync(UserId);
        public void SetUserEo(S_userEO userEo)
        {
            _userId = userEo.UserID;
            _userEo = userEo;
        }

        private S_user_exMO _userExMo;
        public S_user_exMO GetUserExMo()
            => _userExMo ??= DbSink.BuildUserExMo(UserId);
        private S_user_exEO _userExEo;
        public async Task<S_user_exEO> GetUserExEo()
            => _userExEo ??= await GetUserExMo().GetByPKAsync(UserId);
        #endregion

        #region GlobalUserDCache

        private GlobalUserDCache _globalUserDCache;
        public async Task<GlobalUserDCache> GetGlobalUserDCache()
            => _globalUserDCache ??= await GlobalUserDCache.Create(UserId, () => GetUserEo());

        private string _nickname;
        public async Task<string> GetNicknameByUserCache()
            => _nickname ??= await (await GetGlobalUserDCache()).GetNicknameAsync();

        private string _operatorId;
        public async Task<string> GetOperatorIdByUserCache()
            => _operatorId ??= await (await GetGlobalUserDCache()).GetOperatorIdAsync();

        private string _operatorUserId;
        public async Task<string> GetOperatorUserIdByUserCache()
            => _operatorUserId ??= await (await GetGlobalUserDCache()).GetOperatorUserIdAsync();

        private string _countryId;
        public async Task<string> GetCountryIdByUserCache()
            => _countryId ??= await (await GetGlobalUserDCache()).GetCountryIdAsync();

        private string _currencyId;
        public async Task<string> GetCurrencyIdByUserCache()
            => _currencyId ??= await (await GetGlobalUserDCache()).GetCurrencyIdAsync();

        private UserKind? _userKind;
        public async Task<UserKind> GetUserKindByUserCache()
            => _userKind ??= await (await GetGlobalUserDCache()).GetUserKindAsync();

        private string _mobile;
        public async Task<string> GetMobileByUserCache()
            => _mobile ??= await (await GetGlobalUserDCache()).GetMobileAsync();

        private int? _fromMode;
        public async Task<int> GetFromModeByUserCache()
            => _fromMode ??= await (await GetGlobalUserDCache()).GetFromModeAsync();
        private string _fromId;
        public async Task<string> GetFromIdByUserCache()
            => _fromId ??= await (await GetGlobalUserDCache()).GetFromIdAsync();
        #endregion
    }
}
