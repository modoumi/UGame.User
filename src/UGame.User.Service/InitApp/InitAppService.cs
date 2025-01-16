using System.Text.Json.Nodes;
using AiUo.AspNet;
using AiUo.AspNet.ClientSign;
using AiUo.Configuration;
using AiUo.IP2Country;
using AiUo.Net;
using UGame.User.Service.Common;
using UGame.User.Common;
using UGame.User.Common.Caching; 
using UGame.User.Repository;

namespace UGame.User.Service.InitApp
{
    public class InitAppService
    {
        //private ClientSignFilterService _sinSvc;
        public InitAppService()
        {
            //_sinSvc = new ClientSignFilterService(); //DIUtil.GetRequiredService<IAccessSignFilterService>();
        }

        public async Task<InitOperatorAppDto> InitOperatorApp(InitOperatorAppIpo ipo)
        {
            CheckBothKey(ipo.Uuid, ipo.AppId, ipo.Timestamp, ipo.AUS);

            var app = DbCacheUtil.GetApp(ipo.AppId);

            var oper = GetOperator(ipo);
            var country = DbCacheUtil.GetCountry(oper.CountryID);
            var userIp = AspNetUtil.GetRemoteIpString();
            if (!IP2CountryUtil.VerifyCountryIp(userIp, country.CountryID2, "123.125.255.133"))
                throw new CustomException(CommonCodes.RS_WRONG_COUNTRY, "非法国家ip访问");

            var themes = !string.IsNullOrEmpty(oper.ClientThemes)
               ? SerializerUtil.DeserializeJson<OperatorThemes>(oper.ClientThemes)
               : null;
            var ret = new InitOperatorAppDto
            {
                OperatorId = oper.OperatorID,
                ProviderId = app.ProviderID,
                CountryId = oper.CountryID,
                CurrencyId = oper.CurrencyID,
                OperatorLangs = oper.Langs?.Split('|')?.ToList(),
                ServerUrl = await GetAppServerUrl(app),
                ServerUrl2 = GetAppServerUrl(app.ServerUrl2),
                ServerUrl3 = GetAppServerUrl(app.ServerUrl3),
                AccessKey = await GetAccessKey(ipo),
                OperatorVersion = oper.OperatorVersion,
                Themes = themes,
                IsShowBonus = oper.FlowMode == 2,
                AppId = GetMetaAppId(oper.Meta)
            };
            return ret;
        }

        private string GetMetaAppId(string meta)
        {
            if (string.IsNullOrWhiteSpace(meta))
                return string.Empty;
            var jsonMeta = new JsonMeta(meta);
            JsonNode? node = null;
            var appIdExists = jsonMeta.GetOrDefault<JsonObject>("App")?.TryGetPropertyValue("AppId",out node)??false;
            if (!appIdExists)
                return string.Empty;
            return node?.GetValue<string>() ?? string.Empty;
        }

        public async Task<InitProviderAppDto> InitProviderApp(InitProviderAppIpo ipo)
        {
            CheckBothKey(ipo.Uuid, ipo.AppId, ipo.Timestamp, ipo.AUS);

            if (string.IsNullOrEmpty(ipo.AppId))
                throw new ArgumentNullException(nameof(ipo.AppId));
            var app = DbCacheUtil.GetApp(ipo.AppId);
            var ret = new InitProviderAppDto()
            {
                AppServerUrl = await GetAppServerUrl(app),
                AccessKey = await GetAccessKey(ipo),
            };
            return ret;
        }


        private V_s_operatorPO GetOperator(IBothKeyIpo ipo)
        {
            // 测试
            if (!string.IsNullOrEmpty(ipo.OperatorId) && (ConfigUtil.Environment.IsDebug || ConfigUtil.Environment.IsStaging))
                return DbCacheUtil.GetOperator(ipo.OperatorId);

            // referer + operatorDomain
            var uri = AspNetUtil.GetRefererUri();
            if (uri != null)
            {
                var domain = $"{uri.Scheme}://{uri.Host}";
                var ret = DbCacheUtil.GetOperatorByDomain(domain);
                if (ret != null)
                    return ret;
            }

            if (!string.IsNullOrEmpty(ipo.ClientUrl))
            {
                try
                {
                    var url = ipo.ClientUrl.Trim().ToLower();
                    if (url.StartsWith("http://") || url.StartsWith("https://"))
                    {
                        uri = new Uri(url);
                        var domain = DbCacheUtil.GetDomain(uri.Host);
                        if (domain != null && !string.IsNullOrEmpty(domain.OperatorID))
                        {
                            var ret = DbCacheUtil.GetOperator(domain.OperatorID);
                            if (ret != null) return ret;
                        }
                    }
                }
                catch { }
            }
            throw new Exception($"InitOperatorApp获取V_s_operatorEO时，没有匹配url:{ipo.ClientUrl} 且没有ipo.OperatorId");
        }
        private void CheckBothKey(string uuid, string appId, long timestamp, string sign)
        {
            AiUoUtil.ThrowIfNullOrEmptyEx(CommonCodes.RS_INVALID_SIGNATURE
                , "应用程序init时sign不能为空", uuid, appId, sign);
            AiUoUtil.ThrowIfFuncEx(() => timestamp == 0, CommonCodes.RS_INVALID_SIGNATURE
                , "应用程序init时timestamp必须有值");

            // 间隔限制
            //var interval = TimeSpan.FromMilliseconds(AiUoUtil.UtcDateTimeToTimestamp(DateTime.UtcNow, false) - timestamp);
            //if (interval.TotalMinutes > 5)
            //    throw new Exception("非法请求");
            var sourceKey = $"{uuid}{appId}";
            var sourceData = $"{timestamp}{uuid}{appId}";
            //var result = _sinSvc.VerifyByBothKey(sourceKey, sourceData, sign);
            var result = ClientSignUtil.VerifyByBothKey(sourceData, sign, sourceKey);
            if (!result)
                throw new CustomException(GResponseCodes.G_UNAUTHORIZED, "非法请求");
        }
        private async Task<string> GetAppServerUrl(S_appEO app)
        {
            var uri = AspNetUtil.GetRefererUri();
            if (NetUtil.GetIpMode(uri.Host) == IpAddressMode.External)
                return null;
            var ret = app.ServerUrl;
            if (string.IsNullOrEmpty(ret))
                throw new Exception($"初始化时获取ServerUrl不能为空，服务可能没有启动。appId:{app.AppID}");
            return GetAppServerUrl(ret);
        }
        private string GetAppServerUrl(string url)
        {
            if (string.IsNullOrEmpty(url))
                return null;
            if (url.StartsWith('/'))
            {
                url = $"https://api.{AspNetUtil.GetRequestTopDomain()}{url}";
                //ret = $"{AspNetUtil.GetRequestSecondDomainUrl("api")}{ret}";
            }
            return url.Trim();
        }

        private async Task<string> GetAccessKey(IBothKeyIpo ipo)
        {
            var sourceKey = $"{ipo.Uuid}{ipo.AppId}";
            //var ret = _sinSvc.GetAccessKeyEncrypt(sourceKey, ipo.Uuid);
            var ret = ClientSignUtil.GetEncryptedAccessKey(sourceKey, ipo.Uuid);
            return ret;
        }
    }
}
