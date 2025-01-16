using System.Collections.Concurrent;
using System.Reflection;
using AiUo.AspNet;
using UGame.User.Common.Caching;

namespace UGame.User.Common
{
    public static class XxyyUtil
    {
        private static ConcurrentDictionary<string, object> _asmObjCache = new();
        public static T CreateFromAssembly<T>(string asmName, string typeName, params object[] args)
            where T : class
        {
            var fullName = $"{asmName}.{typeName}";
            if (!_asmObjCache.TryGetValue(fullName, out object obj))
            {
                var asmFile = $"{asmName}.dll";
                var asm = Assembly.LoadFrom(Path.Combine(AppContext.BaseDirectory, asmFile));
                var type = asm.GetType(fullName, true, true);
                obj = Activator.CreateInstance(type, args);

                _asmObjCache.TryAdd(fullName, obj);
            }
            T ret = obj as T;
            if (ret == null)
                throw new Exception($"{typeName}不存在。dll: {asmName}");
            return ret;
        }

        #region Money和Amount相互转换

        public static long MToA(this decimal money, string currencyId)
            => (long)(GetCurrencyUnit(currencyId) * money);
        public static long MToA(this double money, string currencyId)
            => MToA((decimal)money, currencyId);
        public static long MToA(this float money, string currencyId)
            => MToA((decimal)money, currencyId);
        public static long MToAByCountryId(this decimal money, string countryId)
            => (long)(GetCurrencyUnitByCountryId(countryId) * money);
        public static long MToAByCountryId(this double money, string countryId)
            => MToAByCountryId((decimal)money, countryId);
        public static long MToAByCountryId(this float money, string countryId)
            => MToAByCountryId((decimal)money, countryId);
        public static decimal AToM(this long amount, string currencyId)
            => amount / GetCurrencyUnit(currencyId);
        public static decimal AToM(this int amount, string currencyId)
            => AToM((long)amount, currencyId);
        public static decimal AToMByCountryId(this long amount, string countryId)
            => amount / GetCurrencyUnitByCountryId(countryId);
        public static decimal AToMByCountryId(this int amount, string countryId)
            => AToMByCountryId((long)amount, countryId);

        /// <summary>
        /// 获取货币对应的基础货币单位（1单位货币等于多少最小币值）
        /// 如当BaseUnit = 100时
        ///     充值时存入的值Balance = (long)Amount*100
        ///     返回客户端的值 = Balance/100;
        /// </summary>
        /// <param name="currencyId"></param>
        /// <returns></returns>
        private static decimal GetCurrencyUnit(string currencyId)
        {
            if (string.IsNullOrEmpty(currencyId))
                throw new ArgumentNullException(nameof(currencyId));
            return DbCacheUtil.GetCurrency(currencyId).BaseUnit;
        }
        private static decimal GetCurrencyUnitByCountryId(string countryId)
        {
            if (string.IsNullOrEmpty(countryId))
                throw new ArgumentNullException(nameof(countryId));
            var country = DbCacheUtil.GetCountry(countryId);
            if (string.IsNullOrEmpty(country.CurrencyID))
                throw new Exception($"国家没有配置主货币。countryId: {countryId}");
            return GetCurrencyUnit(country.CurrencyID);
        }
        #endregion

        #region 客户端获取的URL
        public static string GetAppUrl(string url = null)
        {
            if (url.StartsWith('/'))
            {
                if (ConfigUtil.Environment.IsDebug)
                    return $"{AspNetUtil.GetRequestBaseUrl()}{url}";
                // TODO https异常
                return $"https://www.{AspNetUtil.GetRequestTopDomain()}{url}";
            }
            return url;
        }
        public static string GetUploadUrl(string url = null)
        {
            if (url.StartsWith('/'))
            {
                if (ConfigUtil.Environment.IsDebug)
                    return $"{AspNetUtil.GetRequestBaseUrl()}{url}";
                //
                return $"https://upload.777gana.com{url}";
            }
            return url;
        }
        #endregion

        #region DateTime
        /// <summary>
        /// UTC时间转换OperatorId所在当地时间
        /// </summary>
        /// <param name="utcTime"></param>
        /// <param name="operatorId"></param>
        /// <returns></returns>
        public static DateTime ToLocalTime(this DateTime utcTime, string operatorId)
        {
            if (utcTime.Kind == DateTimeKind.Local)
                throw new Exception("XxyyUtil.ToLocalTime()时utcTime.Kind不能是DateTimeKind.Local");
            var timeZone = DbCacheUtil.GetOperatorTimeZone(operatorId);
            return TimeZoneInfo.ConvertTimeFromUtc(utcTime, timeZone);
        }
        public static DateTime ToLocalTimeByCountryId(this DateTime utcTime, string countryId)
        {
            if (utcTime.Kind == DateTimeKind.Local)
                throw new Exception("XxyyUtil.ToLocalTime()时utcTime.Kind不能是DateTimeKind.Local");
            var timeZone = DbCacheUtil.GetCountryTimeZone(countryId);
            return TimeZoneInfo.ConvertTimeFromUtc(utcTime, timeZone);
        }
        /// <summary>
        /// OperatorId所在当地时间转换UTC时间
        /// </summary>
        /// <param name="localTime"></param>
        /// <param name="operatorId"></param>
        /// <returns></returns>
        public static DateTime ToUtcTime(this DateTime localTime, string operatorId)
        {
            if (localTime.Kind == DateTimeKind.Utc)
                throw new Exception("XxyyUtil.ToUtcTime()时localTime.Kind不能是DateTimeKind.Utc");
            var currTime = localTime.Kind == DateTimeKind.Local
                ? new DateTime(localTime.Year, localTime.Month, localTime.Day, localTime.Hour, localTime.Minute, localTime.Second, localTime.Millisecond)
                : localTime;
            var timeZone = DbCacheUtil.GetOperatorTimeZone(operatorId);
            return TimeZoneInfo.ConvertTimeToUtc(currTime, timeZone);
        }
        public static DateTime ToUtcTimeByCountryId(this DateTime localTime, string countryId)
        {
            if (localTime.Kind == DateTimeKind.Utc)
                throw new Exception("XxyyUtil.ToUtcTime()时localTime.Kind不能是DateTimeKind.Utc");
            var currTime = localTime.Kind == DateTimeKind.Local
                ? new DateTime(localTime.Year, localTime.Month, localTime.Day, localTime.Hour, localTime.Minute, localTime.Second, localTime.Millisecond)
                : localTime;
            var timeZone = DbCacheUtil.GetCountryTimeZone(countryId);
            return TimeZoneInfo.ConvertTimeToUtc(currTime, timeZone);
        }
        /// <summary>
        /// 获取指定年月日时分秒的OperatorId所在当地时间
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <param name="hour"></param>
        /// <param name="minute"></param>
        /// <param name="second"></param>
        /// <param name="operatorId"></param>
        /// <returns></returns>
        public static DateTimeOffset GetLocalTime(string operatorId, int year, int month, int day, int hour = 0, int minute = 0, int second = 0)
        {
            var timeZone = DbCacheUtil.GetOperatorTimeZone(operatorId);
            var ret = new DateTimeOffset(year, month, day, hour, minute, second, timeZone.BaseUtcOffset);
            return ret;
        }
        #endregion
    }
}
