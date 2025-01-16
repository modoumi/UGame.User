using Google.Protobuf.WellKnownTypes;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo;
using UGame.User.Common.Caching;
using UGame.User.Common;
using UGame.User.Repository;

namespace UGame.User.Common.Contexts
{
    public class AppUserContext : UserContext
    {
        public string AppId { get; }

        public S_appEO AppEo { get; }
        public string ProviderId => AppEo.ProviderID;
        public string ProviderAppId => AppEo.ProviderAppId;
        public AppType AppType => AppEo.AppType.ToEnum(AppType.Unknown);

        public S_providerEO ProviderEO { get; }
        public ProviderType ProviderType => (ProviderType)ProviderEO.ProviderType;
        public bool IsOwnProvider => ProviderType == ProviderType.Own;
        public string ProviderPublicKey => ProviderEO.ProvPublicKey;

        public AppUserContext(string appId, string userId) : base(userId)
        {
            //if (string.IsNullOrEmpty(appId))
            //    throw new Exception("AppUserContext: appId不能为空");
            AppId = appId;
            AppEo = DbCacheUtil.GetApp(appId, true, CommonCodes.RS_INVALID_APP);
            ProviderEO = DbCacheUtil.GetProvider(AppEo.ProviderID, true, CommonCodes.RS_INVALID_APP);
        }

        #region MO & EO
        private S_user_appMO _userAppMo;
        public S_user_appMO GetUserAppMo()
            => _userAppMo ??= DbSink.BuildUserAppMo(UserId);
        private S_user_appEO _userAppEo;
        public async Task<S_user_appEO> GetUserAppEo()
            => _userAppEo ??= await GetUserAppMo().GetByPKAsync(UserId, AppId);
        #endregion

        private UserAppDCache _userAppDCache;
        public async Task<UserAppDCache> GetUserAppDCache()
            => _userAppDCache ??= await UserAppDCache.Create(UserId, AppId, () => GetUserAppEo());

        private AppLoginTokenDO _loginTokenDo;
        public async Task<AppLoginTokenDO> GetLoginTokenDo(bool throwWhenNull = true)
        {
            if (_loginTokenDo != null)
                return _loginTokenDo;

            var token = await (await GetUserAppDCache()).GetLoginTokenAsync();
            if (string.IsNullOrEmpty(token))
            {
                if (throwWhenNull)
                    throw new CustomException(CommonCodes.RS_INVALID_TOKEN, $"UserAppDCache不存在LoginToken值。appId:{AppId} userId:{UserId}");
                else
                    return null;
            }
            _loginTokenDo = await new AppLoginTokenDCache(AppId, token).GetTokenDo();
            if (_loginTokenDo == null && throwWhenNull)
                throw new CustomException(CommonCodes.RS_INVALID_TOKEN, $"AppLoginTokenDCache不存在Token值。appId:{AppId} token:{token} userId:{UserId}");
            return _loginTokenDo;
        }
    }
}
