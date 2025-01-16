using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using AiUo;
using AiUo.Data;
using UGame.DataMove.DAL;

namespace UGame.DataMove.Common
{
    public class BackupJob : BaseDataMoveJob
    {
        private int LIMIT_ROWS = 100000;
        public BackupJob(S_data_movePO option) : base(option)
        {
            if ((HandleMode)option.HandleMode == HandleMode.Delete)
                throw new Exception("HandleMode不能是Delete=0");
            LIMIT_ROWS = option.BathPageSize > 0 ? option.BathPageSize : 100000;
        }

        protected override async Task ExecuteJob()
        {
            var list = await BuildBackupDatas();
            if (list == null || list.Count == 0)
                return;
            _logEo.BeginDate = list.First().BeginDate;
            _logEo.EndDate = list.Last().EndDate;
            for (int i = 0; i < list.Count; i++)
            {
                var item = list[i];
                AddLogToExecSQL($"[任务{i + 1}]-开始备份: [{_option.TableName} => {item.BackTableName}] [{item.BeginDate.ToString("yyyy-MM-dd")} => {item.EndDate.ToString("yyyy-MM-dd")}]");
                _logEo.BackupTableName += $"{item.BackTableName}{Environment.NewLine}";
                //if (_database.DbMaintenance.IsAnyTable(item.BackTableName))
                //    throw new Exception($"备份时数据库表已经存在：{item.BackTableName}");
                await CreateTable(item.BackTableName);

                var dateList = GetDayList(item.BeginDate, item.EndDate);
                foreach (var currDate in dateList)
                {
                    await BackupDayRows(item.BackTableName, currDate);
                    await Task.Delay(100);
                }
                AddLogToExecSQL($"[任务{i + 1}]-完成备份: [{_option.TableName} => {item.BackTableName}] [{item.BeginDate} => {item.EndDate}] count: {_logEo.RowNum} {Environment.NewLine}");
            }
        }

        #region BuildBackupData
        private async Task<List<BackupData>> BuildBackupDatas()
        {
            List<BackupData> list;
            switch ((HandleMode)_option.HandleMode)
            {
                case HandleMode.Year:
                    list = await BuildYearData();
                    break;
                case HandleMode.Quarter:
                    list = await BuildQuarterData();
                    break;
                case HandleMode.Month:
                    list = await BuildMonthData();
                    break;
                case HandleMode.Week:
                    list = await BuildWeekData();
                    break;
                case HandleMode.Day:
                    list = await BuildDayData();
                    break;
                default:
                    throw new Exception($"DataMove不支持此HandleMode: {_option.HandleMode}");
            }
            return list;
        }
        private string GetBackupTablename(HandleMode mode, DateTime beginDate)
        {
            switch ((NameMode)_option.NameMode)
            {
                case NameMode.Normal:
                    switch (mode)
                    {
                        case HandleMode.Year: return GetYearName(beginDate);
                        case HandleMode.Quarter: return GetQuarterName(beginDate);
                        case HandleMode.Month: return GetMonthName(beginDate);
                        case HandleMode.Week: return GetWeekName(beginDate);
                        case HandleMode.Day: return GetDayName(beginDate);
                    }
                    break;
                case NameMode.Year: return GetYearName(beginDate);
                case NameMode.Quarter: return GetQuarterName(beginDate);
                case NameMode.Month: return GetMonthName(beginDate);
                case NameMode.Week: return GetWeekName(beginDate);
                case NameMode.Day: return GetDayName(beginDate);
                case NameMode.Back: return $"{_option.TableName}_back";
                case NameMode.Custom:
                    if (string.IsNullOrEmpty(_option.BackupTableName))
                        throw new Exception($"DataMove: NameMode=Custom时BackupTableName不能为空: table:{_option.TableName}");
                    break;
            }
            throw new Exception($"DataMove: 未知NameMode: {_option.NameMode}");
            string GetYearName(DateTime beginDate)
                => $"{_option.TableName}_y{beginDate:yyyy}";
            string GetQuarterName(DateTime beginDate)
            {
                var quarter = Math.DivRem(beginDate.Month, 3, out int _) + 1;
                return $"{_option.TableName}_q{beginDate:yyyy}{quarter}";
            }
            string GetMonthName(DateTime beginDate)
                => $"{_option.TableName}_m{beginDate:yyyyMM}";
            string GetWeekName(DateTime beginDate)
                => $"{_option.TableName}_w{beginDate:yyyy}{DateTimeUtil.WeekOfYear(beginDate).ToString().PadLeft(2, '0')}";
            string GetDayName(DateTime beginDate)
                => $"{_option.TableName}_d{beginDate:yyyyMMdd}";
        }
        private async Task<List<BackupData>> BuildYearData()
        {
            var ret = new List<BackupData>();
            var endDate = new DateTime(DateTime.UtcNow.Year - _option.KeepValue, 1, 1);
            var minDate = await GetMinDate(endDate);
            while (endDate > minDate)
            {
                var beginDate = endDate.AddYears(-1);
                var item = new BackupData
                {
                    BackTableName = GetBackupTablename(HandleMode.Year, beginDate),
                    BeginDate = beginDate,
                    EndDate = endDate
                };
                ret.Add(item);
                endDate = beginDate;
            }
            ret.Reverse();
            return ret;
        }
        private async Task<List<BackupData>> BuildQuarterData()
        {
            var ret = new List<BackupData>();

            var endDate = DateTime.UtcNow.AddMonths(0 - _option.KeepValue * 3);
            var month = Math.DivRem(endDate.Month - 1, 3, out int _) * 3 + 1;
            endDate = new DateTime(endDate.Year, month, 1);
            var minDate = await GetMinDate(endDate);
            while (endDate > minDate)
            {
                var beginDate = endDate.AddMonths(-3);
                var item = new BackupData
                {
                    BackTableName = GetBackupTablename(HandleMode.Quarter, beginDate),
                    BeginDate = beginDate,
                    EndDate = endDate
                };
                ret.Add(item);
                endDate = beginDate;
            }
            ret.Reverse();
            return ret;
        }
        private async Task<List<BackupData>> BuildMonthData()
        {
            var ret = new List<BackupData>();
            var endDate = DateTime.UtcNow.AddMonths(0 - _option.KeepValue).Date;
            endDate = new DateTime(endDate.Year, endDate.Month, 1);
            var minDate = await GetMinDate(endDate);
            while (endDate > minDate)
            {
                var beginDate = endDate.AddMonths(-1);
                var item = new BackupData
                {
                    BackTableName = GetBackupTablename(HandleMode.Month, beginDate),
                    BeginDate = beginDate,
                    EndDate = endDate
                };
                ret.Add(item);
                endDate = beginDate;
            }
            ret.Reverse();
            return ret;
        }
        private async Task<List<BackupData>> BuildWeekData()
        {
            var ret = new List<BackupData>();
            var endDate = DateTime.Now.AddDays(0 - _option.KeepValue * 7).Date;
            endDate = DateTimeUtil.BeginDayOfWeek(endDate);
            var minDate = await GetMinDate(endDate);
            while (endDate > minDate)
            {
                var beginDate = endDate.AddDays(-7);
                var item = new BackupData
                {
                    BackTableName = GetBackupTablename(HandleMode.Week, beginDate),
                    BeginDate = beginDate,
                    EndDate = endDate
                };
                ret.Add(item);
                endDate = beginDate;
            }
            ret.Reverse();
            return ret;
        }
        private async Task<List<BackupData>> BuildDayData()
        {
            var ret = new List<BackupData>();
            var endDate = DateTime.UtcNow.AddDays(0 - _option.KeepValue).Date;
            var minDate = await GetMinDate(endDate);
            while (endDate > minDate)
            {
                var beginDate = endDate.AddDays(-1);
                var item = new BackupData
                {
                    BackTableName = GetBackupTablename(HandleMode.Day, beginDate),
                    BeginDate = beginDate,
                    EndDate = endDate
                };
                ret.Add(item);
                endDate = beginDate;
            }
            ret.Reverse();
            return ret;
        }
        #endregion

        private async Task CreateTable(string backTableName)
        {
            var createSql = $"CREATE TABLE if not exists `{backTableName}` like `{_option.TableName}`";
            AddLogToExecSQL($"==> 创建备份表SQL: {createSql}");
            await _database.Ado.ExecuteCommandAsync(createSql);
        }
        protected async Task<int> BackupDayRows(string backTableName, DateTime currDate)
        {
            var where = GetWhereByDay(currDate);
            var watch = new Stopwatch();

            // 1) 获取备份的数据
            // SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;
            var selectSql = $"SELECT * FROM `{_option.TableName}`";
            var selectCount = await _database.SqlQueryable<object>(selectSql).Where(where).CountAsync();
            if (selectCount == 0)
                return 0;
            // page
            var dtList = new List<DataTable>();
            int pageCount = (selectCount + LIMIT_ROWS - 1) / LIMIT_ROWS;
            AddLogToExecSQL($"==> [{currDate.ToString("yyyy-MM-dd")}]备份天数据开始: {_option.TableName} rowCount:{selectCount} pageSize:{LIMIT_ROWS} pageCount:{pageCount}");
            AddLogToExecSQL($"  1) 读取备份数据开始...");
            var readCount = 0;
            for (int idx = 1; idx <= pageCount; idx++)
            {
                watch.Restart();
                var dt = _database.SqlQueryable<object>(selectSql).Where(where).ToDataTablePage(idx, LIMIT_ROWS);
                if (dt == null || dt.Rows.Count == 0)
                    break;
                readCount += dt.Rows.Count;
                dtList.Add(dt);
                watch.Stop();
                AddLogToExecSQL($"  SQL:[{(int)watch.Elapsed.TotalSeconds}秒] {selectSql} pageSize:{LIMIT_ROWS} pageCount:{dtList.Count}");
                await Task.Delay(100);
            }
            if (readCount != selectCount)
                throw new Exception($"分页读取时行记录不一致: {selectSql} selectCount:{selectCount} readCount:{readCount}");
            AddLogToExecSQL($"  1) 读取备份数据结束... readCount:{readCount}");

            try
            {
                AddLogToExecSQL($"  ======== 事务开始 ========");
                _database.Ado.BeginTran();

                // 2) 删除备份表旧数据
                AddLogToExecSQL($"  2) 删除备份表旧数据开始: {backTableName}");
                var oldDeleteSql = $"DELETE FROM `{backTableName}` WHERE {where}";
                watch.Restart();
                var oldDeleteCount = await _database.Ado.ExecuteCommandAsync(oldDeleteSql);
                watch.Stop();
                AddLogToExecSQL($"  SQL:[{(int)watch.Elapsed.TotalSeconds}秒] {oldDeleteSql}");
                AddLogToExecSQL($"  2) 删除备份表旧数据结束: {backTableName} deleteCount: {oldDeleteCount}");

                // 3) 插入数据
                AddLogToExecSQL($"  3) 插入备份表数据开始: {backTableName}");
                var insertCount = 0;
                foreach (var dt in dtList)
                {
                    watch.Restart();
                    insertCount += await _database.Fastest<DataTable>().AS(backTableName).BulkCopyAsync(dt);
                    watch.Stop();
                    AddLogToExecSQL($"  SQL:[{(int)watch.Elapsed.TotalSeconds}秒] INSERT INTO `{backTableName}` total: {insertCount}");
                    await Task.Delay(100);
                }
                if (selectCount != insertCount)
                    throw new Exception($"DataMove插入时总记录数不相同。fromTable: {_option.TableName} toTable:{backTableName}");
                AddLogToExecSQL($"  3) 插入备份表数据结束: {backTableName} insertCount: {insertCount}");

                // 4) 删除原始表数据
                AddLogToExecSQL($"  4) 删除原始表数据开始: {_option.TableName}");
                var deleteSql = $"DELETE FROM `{_option.TableName}` WHERE {where}";
                var deleteCount = 0;
                while (true)
                {
                    watch.Restart();
                    var rows = await _database.Ado.ExecuteCommandAsync($"{deleteSql} LIMIT {LIMIT_ROWS * 5}");
                    watch.Stop();
                    AddLogToExecSQL($"  SQL:[{(int)watch.Elapsed.TotalSeconds}秒] {deleteSql} LIMIT {LIMIT_ROWS * 5}");

                    if (rows == 0) break;
                    deleteCount += rows;
                    await Task.Delay(100);
                }
                if (deleteCount != selectCount)
                    throw new Exception($"DataMove删除记录数不等于插入记录数。{_option.TableName} => {backTableName} currDate: {currDate} insertCount: {selectCount} deleteCount: {deleteCount}");
                AddLogToExecSQL($"  4) 删除原始表数据结束: {_option.TableName} deleteCount: {deleteCount}");
                _logEo.RowNum += deleteCount;
                _database.Ado.CommitTran();
                AddLogToExecSQL($"  ======== 事务提交 ========");
            }
            catch
            {
                _database.Ado.RollbackTran();
                AddLogToExecSQL($"  ==>事务失败: {_option.TableName} => {backTableName} currDate: {currDate} count: {selectCount}");
                throw;
            }
            AddLogToExecSQL($"==> [{currDate.ToString("yyyy-MM-dd")}]备份天数据结束: rowCount:{selectCount} pageSize:{LIMIT_ROWS} pageCount:{pageCount}");
            return selectCount;
        }
    }
}
