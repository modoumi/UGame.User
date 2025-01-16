using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGame.User.Common.Caching
{
    public partial class UserAppDCache
    {
        #region LoginToken
        private const string Key_LoginToken = "LoginToken";
        public Task<string> GetLoginTokenAsync() => GetOrDefaultAsync<string>(Key_LoginToken, null);
        public Task SetLoginTokenAsync(string value) => SetAsync(Key_LoginToken, value);
        #endregion

        #region ClientBothKey
        private const string Key_ClientBothKey = "ClientBothKey";
        public Task<string> GetClientBothKey() => GetOrDefaultAsync<string>(Key_ClientBothKey, null);
        public Task SetClientBothKey(string value) => SetAsync(Key_ClientBothKey, value);
        #endregion
    }
}
