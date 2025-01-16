using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.AspNet;
using AiUo.Caching;
using AiUo.Net;

namespace UGame.User.Common.Caching
{
    public partial class GlobalUserDCache
    {

        #region ClientUserIp
        private const string Key_ClientUserIp = "ClientUserIp";
        public Task<string> GetClientUserIp() => GetOrDefaultAsync<string>(Key_ClientUserIp, null);
        public Task SetClientUserIp(string value) => SetAsync<string>(Key_ClientUserIp, value);
        #endregion

        #region ClientUserAgent
        private const string Key_ClientUserAgent = "ClientUserAgent";
        public Task<string> GetClientUserAgent() => GetOrDefaultAsync<string>(Key_ClientUserAgent, null);
        public Task SetClientUserAgent(string value) => SetAsync<string>(Key_ClientUserAgent, value);
        #endregion

        #region ClientVersionId
        private const string Key_ClientVersionId = "ClientVersionId";
        public Task<string> GetClientVersionId() => GetOrDefaultAsync<string>(Key_ClientVersionId, null);
        public Task SetClientVersionId(string value) => SetAsync<string>(Key_ClientVersionId, value);
        #endregion

        #region ClientLangId
        private const string Key_ClientLangId = "ClientLangId";
        public Task<string> GetClientLangId() => GetOrDefaultAsync<string>(Key_ClientLangId, null);
        public Task SetClientLangId(string value) => SetAsync<string>(Key_ClientLangId, value);
        #endregion

        #region ClientOS
        private const string Key_ClientOS = "ClientOS";
        public Task<OperatingSystemType> GetClientOS() => GetOrDefaultAsync(Key_ClientOS, OperatingSystemType.Unknow);
        public Task SetClientOS(OperatingSystemType value) => SetAsync(Key_ClientOS, value);
        #endregion

        #region ClientBrowser
        private const string Key_ClientBrowser = "ClientBrowser";
        public Task<BrowserType> GetClientBrowser() => GetOrDefaultAsync(Key_ClientBrowser, BrowserType.Unknow);
        public Task SetClientBrowser(BrowserType value) => SetAsync(Key_ClientBrowser, value);
        #endregion

        #region ClientIsMobile
        private const string Key_ClientIsMobile = "ClientIsMobile";
        public Task<bool?> GetClientIsMobile() => GetOrDefaultAsync<bool?>(Key_ClientIsMobile, null);
        public Task SetClientIsMobile(bool? value) => SetAsync(Key_ClientIsMobile, value);
        #endregion

        public async Task SetIClientInfo(IClientInfo value)
        {
            var userIp = AspNetUtil.GetRemoteIpString();
            var userAgent = HttpContextEx.RequestHeaders.GetOrDefault("User-Agent","");
            var values = new Dictionary<string, CacheItem<object>>
            {
                { Key_ClientVersionId, new CacheItem<object>(value.VersionId)},
                { Key_ClientLangId, new CacheItem<object>(value.Language)},
                { Key_ClientOS, new CacheItem<object>(value.OS)},
                { Key_ClientBrowser, new CacheItem<object>(value.Browser)},
                { Key_ClientIsMobile, new CacheItem<object>(value.IsMobile)},
                { Key_ClientUserIp, new CacheItem<object>(userIp)},
                { Key_ClientUserAgent, new CacheItem<object>(userAgent)},
            };
            await SetAsync(values);
        }
    }
    public interface IClientInfo
    {
        string VersionId { get; set; }
        string Language { get; set; }
        OperatingSystemType OS { get; set; }
        BrowserType Browser { get; set; }
        bool IsMobile { get; set; }
    }
}
