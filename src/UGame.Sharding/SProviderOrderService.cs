using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo;
using AiUo.Data;
using AiUo.Data.MySql;

namespace UGame.Sharding
{
    public class SProviderOrderService
    {
        public async Task<List<string>> GetTableNames(ProviderOrderFilter filter)
        {
            if (filter == null)
                throw new ArgumentNullException(nameof(filter));
            //if (filter.BeginDate.Kind != DateTimeKind.Utc || filter.EndDate.Kind != DateTimeKind.Utc)
            //    throw new Exception("ProviderOrderService.GetTableNames()时BeginDate和EndDate的Kind必须等于DateTimeKind.Utc");

            var ret = new List<string>();
            var dict = await GetNameDict();

            //var beginDay = filter.BeginUtcDate.ToString("yyyyMMdd").ToInt32();
            //var currDate = (beginDay < _minDay) 
            //    ? DateTime.ParseExact(_minDay.ToString(), "yyyyMMdd", null)
            //    : filter.BeginUtcDate;
            var currDate = filter.BeginUtcDate;
            var hasBaseTable = false;
            while (currDate < filter.EndUtcDate)
            {
                var day = currDate.ToString("yyyyMMdd").ToInt32();
                if (dict.ContainsKey(day))
                    ret.Add(dict[day]);
                else
                    hasBaseTable = true;
                currDate = currDate.AddDays(1);
            }
            if (hasBaseTable)
                ret.Insert(0, "s_provider_order");
            return ret;
        }

        public async Task<List<string>> GetTableNamesByOperatorIds(DateTime beginDate, DateTime endDate, params string[] operatorIds)
        {
            var filter = new ProviderOrderFilter()
            {
                BeginUtcDate = beginDate,
                EndUtcDate = endDate,
                OperatorIds = operatorIds?.ToList()
            };
            return await GetTableNames(filter);
        }

        #region Utils
        private static Dictionary<int, string> _nameDict = null;
        private static int _minDay = 0;
        private static async Task<Dictionary<int, string>> GetNameDict()
        {
            if (_nameDict != null)
                return _nameDict;
            var ret = new Dictionary<int, string>();
            var tables = await GetAllTableNames();
            var minDay = int.MaxValue;
            foreach (var table in tables)
            {
                if (!table.StartsWith("s_provider_order_"))
                    continue;
                var day = table.Replace("s_provider_order_","").Replace("d", "").ToInt32();
                minDay = Math.Min(minDay, day);
                ret.Add(day, table);
            }
            _nameDict = ret;
            _minDay = minDay == int.MaxValue ? 0: minDay;
            return _nameDict;
        }

        private static async Task<List<string>> GetAllTableNames()
        {
            var db = new MySqlDatabase();
            var sql = $"select TABLE_NAME from information_schema.TABLES where TABLE_SCHEMA= '{db.DatabaseName}' and table_type='BASE TABLE' and TABLE_NAME like 's_provider_order_%' order by TABLE_NAME";
            return await db.ExecSqlListAsync<string>(sql, DataMappingMode.PrimitiveType);
        }
        internal static void Clear()
        {
            _nameDict = null;
        }
        #endregion
    }
    public class ProviderOrderFilter
    {
        /// <summary>
        /// 非空必须UTC时间[包含]
        /// </summary>
        public DateTime BeginUtcDate { get; set; } = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        /// <summary>
        /// 非空必须UTC时间[包含]
        /// </summary>
        public DateTime EndUtcDate { get; set; }

        public List<string> OperatorIds { get; set; }
        public List<string> ProviderIds { get; set; }
        public List<string> AppIds { get; set; }
    }
}
