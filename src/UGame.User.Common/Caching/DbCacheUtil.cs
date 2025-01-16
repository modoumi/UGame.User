using Google.Protobuf.WellKnownTypes;
using Microsoft.CodeAnalysis;
using System.Collections.Concurrent;
using AiUo.DbCaching;
using UGame.User.Repository;
using Xxyy.Common;

namespace UGame.User.Common.Caching
{
    public static class DbCacheUtil
    {
        #region s_currency
        public static S_currencyPO GetCurrency(string currencyId, bool exceptionOnNull = true, string errorCode = null)
        {
            var ret = DbCachingUtil.GetSingle<S_currencyPO>(currencyId);
            if (ret == null)
            {
                if (exceptionOnNull)
                {
                    if (string.IsNullOrEmpty(errorCode))
                        throw new Exception($"currencyId不存在: {currencyId}");
                    else
                        throw new CustomException(errorCode, $"currencyId不存在: {currencyId}");
                }
                else
                    return null;
            }
            return ret;
        }
        public static CurrencyType GetCurrencyType(string currencyId)
        {
            var ret = GetCurrency(currencyId).CurrencyType.ToEnum(CurrencyType.Unknow);
            if (ret == CurrencyType.Unknow)
                throw new Exception($"未知的currencyId:{currencyId}");
            return ret;
        }
        #endregion

        #region s_app
        public static S_appPO GetApp(string appId, bool exceptionOnNull = true, string errorCode = null)
        {
            var ret = DbCachingUtil.GetSingle<S_appPO>(appId);

            if (ret == null)
            {
                if (exceptionOnNull)
                {
                    if (string.IsNullOrEmpty(errorCode))
                        throw new Exception($"AppId不存在: {appId}");
                    else
                        throw new CustomException(errorCode, $"AppId不存在: {appId}");
                }
                else
                    return null;
            }
            return ret;
        }

        public static S_appPO GetAppByProviderAppId(string providerId, string providerAppId, bool exceptionOnNull = true, string errorCode = null)
        {
            var ret = DbCachingUtil.GetSingle<S_appPO>(it => new { it.ProviderID, it.ProviderAppId }, new S_appPO
            {
                ProviderID = providerId,
                ProviderAppId = providerAppId
            });
            if (ret == null)
            {
                if (exceptionOnNull)
                {
                    if (string.IsNullOrEmpty(errorCode))
                        throw new Exception($"AppId不存在: providerId:{providerId} providerAppId:{providerAppId}");
                    else
                        throw new CustomException(errorCode, $"AppId不存在: providerId:{providerId} providerAppId:{providerAppId}");
                }
                else
                    return null;
            }
            return ret;
        }
        #endregion

        #region s_provider
        public static S_providerPO GetProvider(string providerId, bool excOnNull = true, string errorCode = null)
        {
            var ret = DbCachingUtil.GetSingle<S_providerPO>(providerId);
            if (ret == null)
            {
                if (excOnNull)
                {
                    if (string.IsNullOrEmpty(errorCode))
                        throw new Exception($"providerId不存在: {providerId}");
                    else
                        throw new CustomException(errorCode, $"providerId不存在: {providerId}");
                }
                else
                    return null;
            }
            return ret;
        }
        public static S_providerPO GetProviderByAppId(string appId)
        {
            var app = GetApp(appId);
            return GetProvider(app.ProviderID);
        }
        #endregion

        #region s_domain
        public static S_domainPO GetDomain(string domainId)
        {
            return DbCachingUtil.GetSingle<S_domainPO>(domainId);
        }
        #endregion

        #region s_operator
        public static V_s_operatorPO GetOperator(string operatorId, bool excOnNull = true, string errorCode = null)
        {
            var ret = DbCachingUtil.GetSingle<V_s_operatorPO>(it => it.OperatorID, operatorId);
            if (ret == null)
            {
                if (excOnNull)
                {
                    if (string.IsNullOrEmpty(errorCode))
                        throw new Exception($"无效的operatorId: {operatorId}");
                    else
                        throw new CustomException(errorCode, $"无效的operatorId: {operatorId}");
                }
                else
                    return null;
            }
            return ret;
        }
        public static List<string> GetOperatorLangs(string operatorId)
        {
            var ret = new List<string>();
            var oper = GetOperator(operatorId);
            if (!string.IsNullOrEmpty(oper.Langs))
                ret = oper.Langs.Split('|').ToList();
            return ret;
        }
        public static V_s_operatorPO GetOperatorByDomain(string domain)
        {
            var dict = DbCachingUtil.GetOrAddCustom<V_s_operatorPO>("domain", (data) =>
            {
                var values = new Dictionary<string, V_s_operatorPO>();
                var list = data.FindAll(x => !string.IsNullOrEmpty(x.MapDomain));
                foreach (var item in list)
                {
                    var domains = item.MapDomain.Split('|', StringSplitOptions.RemoveEmptyEntries);
                    foreach (var domain in domains)
                    {
                        if (!string.IsNullOrEmpty(domain))
                            values.TryAdd(domain.ToLower(), item);
                    }
                }
                return values;
            });
            return dict.TryGetValue(domain.ToLower(), out var ret)
                ? ret : null;
        }
        #endregion

        #region s_operator_app

        #region {operatorId}_{appId} => EO
        /// <summary>
        /// 根据operatorId和appId获得S_operator_appEO
        /// </summary>
        /// <param name="operatorId"></param>
        /// <param name="appId"></param>
        /// <param name="excOnNull"></param>
        /// <param name="errorCode"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        /// <exception cref="CustomException"></exception>
        public static S_operator_appPO GetOperatorApp(string operatorId, string appId, bool excOnNull = true, string errorCode = null)
        {
            var ret = DbCachingUtil.GetSingle<S_operator_appPO>(it => new { it.OperatorID, it.AppID }, new S_operator_appPO
            {
                OperatorID = operatorId,
                AppID = appId,
            });

            if (ret == null)
            {
                if (excOnNull)
                {
                    if (string.IsNullOrEmpty(errorCode))
                        throw new Exception($"s_operator_app不存在定义。operatorId:{operatorId} AppId: {appId}");
                    else
                        throw new CustomException(errorCode, $"s_operator_app不存在定义。operatorId: {operatorId} appId:{appId}");
                }
                else
                    return null;
            }
            return ret;
        }
        /// <summary>
        /// 是否属于此运营商的游戏
        /// </summary>
        /// <param name="operatorId"></param>
        /// <param name="appId"></param>
        /// <returns></returns>
        public static bool IsOperatorApp(string operatorId, string appId)
            => GetOperatorApp(operatorId, appId, false) != null;
        public static S_operator_appPO GetOperatorAppByOperatorAppId(string operatorId, string operatorAppId)
        {
            var ret = DbCachingUtil.GetSingle<S_operator_appPO>(it => new { it.OperatorID, it.OperatorAppId }, new S_operator_appPO
            {
                OperatorID = operatorId,
                OperatorAppId = operatorAppId
            });
            if (ret == null)
                throw new Exception($"s_operator_app不存在定义。operatorId:{operatorId} operatorAppId: {operatorAppId}");
            return ret;
        }

        #endregion

        public static List<S_operator_appPO> GetOperatorAppsByOperatorId(string operatorId)
        {
            return DbCachingUtil.GetList<S_operator_appPO>(it => it.OperatorID, operatorId);
        }
        /// <summary>
        /// 获得operatorId定义的游戏列表appIds
        /// </summary>
        /// <param name="operatorId"></param>
        /// <returns></returns>
        public static List<string> GetAppIdsByOperatorId(string operatorId)
        {
            return GetOperatorAppsByOperatorId(operatorId)?.Select(x => x.AppID).ToList();
        }

        /// <summary>
        /// 获取appId对应的OperatorID列表
        /// </summary>
        /// <param name="appId"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static List<string> GetOperatorIdsByAppId(string appId)
        {
            var ret = DbCachingUtil.GetList<S_operator_appPO>(it => it.AppID, appId);
            if (ret == null)
                throw new ArgumentException($"s_operator_app中appId不存在。appId: {appId}", nameof(appId));
            return ret.Select(x => x.OperatorID).ToList();
        }
        public static bool IsSupportActivityId(string operatorId, string appId, string activityId)
        {
            var dict = DbCachingUtil.GetOrAddCustom<S_operator_appPO>("activityIds", (data) =>
            {
                var values = new Dictionary<string, S_operator_appPO>();
                var list = data.FindAll(x => !string.IsNullOrEmpty(x.ActivityIds));
                foreach (var item in list)
                {
                    var ids = item.ActivityIds.Split('|', StringSplitOptions.RemoveEmptyEntries);
                    foreach (var id in ids)
                    {
                        if (!string.IsNullOrEmpty(id))
                            values.TryAdd($"{operatorId}|{appId}|{id}", item);
                    }
                }
                return values;

            });
            return dict.ContainsKey($"{operatorId}|{appId}|{activityId}");
        }
        #endregion

        #region s_app_lang
        public static S_app_langPO GetAppLang(string appId, string langId)
        {
            var ret = DbCachingUtil.GetSingle<S_app_langPO>(it => new { it.AppID, it.LangID }, new S_app_langPO
            {
                AppID = appId,
                LangID = langId
            }) ?? DbCachingUtil.GetSingle<S_app_langPO>(it => new { it.AppID, it.LangID }, new S_app_langPO
            {
                AppID = appId,
                LangID = "en"
            }) ?? DbCachingUtil.GetSingle<S_app_langPO>(it => new { it.AppID, it.LangID }, new S_app_langPO
            {
                AppID = appId,
                LangID = null
            });
            if (ret == null)
            {
                throw new Exception($"s_app_lang没有定义且没有默认langId。appId: {appId} langId:{langId}");
            }
            return ret;
        }
        #endregion

        #region s_country
        public static S_countryPO GetCountry(string countryId)
        {
            var ret = DbCachingUtil.GetSingle<S_countryPO>(countryId);
            if (ret == null)
                throw new Exception($"countryId不存在: {countryId}");
            return ret;
        }
        public static S_countryPO GetCountryByOperatorId(string operatorId)
        {
            var oper = GetOperator(operatorId);
            return GetCountry(oper.CountryID);
        }
        private static ConcurrentDictionary<string, TimeZoneInfo> _countryTimeZoneDic = new();
        public static TimeZoneInfo GetCountryTimeZone(string countryId)
        {
            if (_countryTimeZoneDic == null)
                _countryTimeZoneDic = new();
            if (!_countryTimeZoneDic.TryGetValue(countryId, out var ret))
            {
                var country = GetCountry(countryId);
                var standardName = $"{country.EnName} Time";
                var displayName = $"(UTC {country.TimeZone}) {standardName}";
                var offset = TimeSpan.FromHours(country.TimeZone);
                ret = TimeZoneInfo.CreateCustomTimeZone(standardName, offset, displayName, standardName);
                _countryTimeZoneDic.TryAdd(countryId, ret);
            }
            return ret;
        }
        public static TimeZoneInfo GetOperatorTimeZone(string operatorId)
        {
            var oper = GetOperator(operatorId);
            return GetCountryTimeZone(oper.CountryID);
        }
        #endregion

        #region s_channel
        public static S_channelPO GetChannel(string channelId, bool excOnNull = true, string errorCode = null)
        {
            var ret = DbCachingUtil.GetSingle<S_channelPO>(channelId);
            if (ret == null)
            {
                if (excOnNull)
                {
                    if (string.IsNullOrEmpty(errorCode))
                        throw new Exception($"无效的channelId: {channelId}");
                    else
                        throw new CustomException(errorCode, $"无效的channelId: {channelId}");
                }
                else
                    return null;
            }
            return ret;
        }
        #endregion
    }
}
