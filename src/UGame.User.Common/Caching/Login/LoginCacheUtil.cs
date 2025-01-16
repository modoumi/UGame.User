namespace UGame.User.Common.Caching
{
    public static class LoginCacheUtil
    {
        #region Email|Mobile|Username|OAuth => UserId
        public static async Task<string> GetUserIdByEmail(string operatorId, string email, TimeSpan? expire = null)
        {
            var cache = new EmailLoginDCache(operatorId, email, expire);
            var ret = await cache.GetUserId();
            if (!ret.HasValue || string.IsNullOrEmpty(ret.Value))
            {
                //throw new CustomException(CommonCodes.EmailNotExist, $"Email不存在。email:{email}");
                await cache.RemoveUserId();
                return null;
            }
            return ret.Value;
        }
        public static async Task<string> GetUserIdByMobile(string operatorId, string mobile, TimeSpan? expire = null)
        {
            var cache = new MobileLoginDCache(operatorId, mobile, expire);
            var ret = await cache.GetUserId();
            if (!ret.HasValue || string.IsNullOrEmpty(ret.Value))
            {
                await cache.RemoveUserId();
                return null;
            }
            return ret.Value;
        }
        public static async Task SetUserIdByMobile(string operatorId, string mobile, string userId, TimeSpan? expire = null)
        {
            var cache = new MobileLoginDCache(operatorId, mobile, expire);
            await cache.SetUserId(userId);
        }

        public static async Task<string> GetUserIdByUsername(string operatorId, string username, TimeSpan? expire = null)
        {
            var cache = new UsernameLoginDCache(operatorId, username, expire);
            var ret = await cache.GetUserId();
            if (!ret.HasValue || string.IsNullOrEmpty(ret.Value))
            {
                await cache.RemoveUserId();
                return null;
            }
            return ret.Value;
        }

        public static async Task<string> GetUserIdByOperatorUserId(string operatorId, string operatorUserId, TimeSpan? expire = null)
        {
            var cache = new OperatorUserDCache(operatorId, operatorUserId, expire);
            var ret = await cache.GetUserId();
            if (!ret.HasValue || string.IsNullOrEmpty(ret.Value))
            {
                await cache.RemoveUserId();
                return null;
            }
            return ret.Value;
        }
        public static async Task<string> GetUserIdByOAuth(string operatorId, int oauthType, string oauthId, TimeSpan? expire = null)
        {
            if (string.IsNullOrEmpty(operatorId))
            {
                throw new CustomException("operatorId is not null", "operatorId is not null");
            }
            var cache = new OAuthUserDCache(operatorId, oauthType, oauthId, expire);
            var ret = await cache.GetUserId();
            if (!ret.HasValue || string.IsNullOrEmpty(ret.Value))
            {
                await cache.RemoveUserId();
                return null;
            }
            return ret.Value;
        }

        public static async Task<string> GetOAuthUserUrlState(string state, TimeSpan? expire = null)
        {
            var cache = new OAuthUserUrlStateDCache(state, expire);
            var ret = await cache.GetState();
            if (!ret.HasValue || string.IsNullOrEmpty(ret.Value))
            {
                await cache.RemoveState();
                return null;
            }
            return ret.Value;
        }

        public static async Task SetOAuthUserUrlState(string state, TimeSpan? expire = null)
        {
            var cache = new OAuthUserUrlStateDCache(state, expire);
            await cache.SetState();
        }


        #endregion

        #region AppLoginToken
        public static async Task SetAppLoginTokenDoAsync(AppLoginTokenDO appLoginTokenDO)
        {
            AiUoUtil.ThrowIfNullOrEmpty("SetAppLoginTokenDoAsync时appid,token,userid不能为空"
                , appLoginTokenDO.AppId, appLoginTokenDO.Token, appLoginTokenDO.UserId);
            await new AppLoginTokenDCache(appLoginTokenDO.AppId, appLoginTokenDO.Token).SetTokenDo(appLoginTokenDO);
            await new UserAppDCache(appLoginTokenDO.UserId, appLoginTokenDO.AppId).SetLoginTokenAsync(appLoginTokenDO.Token);
        }

        public static async Task<AppLoginTokenDO> GetAppLoginTokenDoAsync(string userId, string appId)
        {
            AiUoUtil.ThrowIfNullOrEmpty("GetAppLoginTokenDoAsync时appid,userid不能为空", userId, appId);
            var token = await new UserAppDCache(userId, appId).GetLoginTokenAsync();
            return !string.IsNullOrEmpty(token)
                ? await GetAppLoginTokenDoByTokenAsync(appId, token)
                : null;
        }

        public static async Task<AppLoginTokenDO> GetAppLoginTokenDoByTokenAsync(string appId, string token)
        {
            AiUoUtil.ThrowIfNullOrEmpty("GetAppLoginTokenDoByTokenAsync时appid,token不能为空", token, appId);
            return await new AppLoginTokenDCache(appId, token).GetTokenDo();
        }
        #endregion

        #region AccessKey
        //public async Task 
        #endregion
    }
}
