using Org.BouncyCastle.Ocsp;
using SqlSugar;
using System.Diagnostics;
using AiUo;
using AiUo.Data.SqlSugar;
using AiUo.Logging;
using AiUo.Text;
using UGame.DataMove.DAL;

namespace UGame.DataMove.Common
{
    public abstract class BaseDataMoveJob
    {
        public const int DB_TIMEOUT_SECONDS = 1800;
        protected ILogBuilder _logger;
        protected S_data_movePO _option;
        protected ISqlSugarClient _database;
        protected S_data_move_logPO _logEo;

        public BaseDataMoveJob(S_data_movePO option)
        {
            _logger = new LogBuilder("DataMove")
                .AddField("DataMove.Option", SerializerUtil.SerializeJson(option));
            _option = option;
            _database = DbUtil.GetDbById(option.DatabaseName);
            _database.Ado.CommandTimeOut = DB_TIMEOUT_SECONDS;
        }
        public async Task Execute()
        {
            // 有正在执行的任务就退出
            var oldLogEo = DbUtil.GetDb<S_data_move_logPO>().Queryable<S_data_move_logPO>()
                .Where(it => it.DataMoveID == _option.DataMoveID && it.Status == 0)
                .Where("DATE_FORMAT(recdate,'%Y-%m-%d')=DATE_FORMAT(UTC_DATE(),'%Y-%m-%d')")
                .ToList();
            if (oldLogEo != null && oldLogEo.Count > 0)
            {
                LogUtil.Debug($"DataMove时当天有正在执行的任务。dataMoveId:{_option.DataMoveID}");
                return;
            }

            await AddDataMoveLogEo();
            var sw = new Stopwatch();
            sw.Start();
            var logMo = DbUtil.GetRepository<S_data_move_logPO>();
            try
            {
                if (!_database.DbMaintenance.IsAnyTable(_option.TableName))
                    throw new Exception($"DataMove数据表不存在。TableName: {_option.TableName} DataMoveID:{_option.DataMoveID}");
                await ExecuteJob();
                sw.Stop();
                _logEo.ExecTime = (int)sw.Elapsed.TotalSeconds;
                _logEo.Status = 1;
                if (_logEo.RowNum == 0)
                    await logMo.DeleteByIdAsync(_logEo.LogID);
                else
                    await logMo.UpdateAsync(_logEo);
            }
            catch (Exception ex)
            {
                sw.Stop();
                _logger.AddMessage("执行数据备份迁移出现异常")
                    .AddField("DataMove.ElaspedTime", sw.ElapsedMilliseconds)
                    .AddField("DataMove.LogEo", SerializerUtil.SerializeJson(_logEo))
                    .AddException(ex);

                _logEo.Status = 2;
                _logEo.Exception += SerializerUtil.SerializeJsonNet(ex);
                await logMo.UpdateAsync(_logEo);
            }
            _logger.Save();
        }
        protected void AddLogToExecSQL(string msg)
        {
            LogUtil.Debug(msg);
            if ((_logEo.ExecSQL?.Length ?? 0) + msg.Length < DataMoveUtil.SQL_MAX_CHARS)
                _logEo.ExecSQL += msg + Environment.NewLine;
        }

        protected abstract Task ExecuteJob();

        private async Task AddDataMoveLogEo()
        {
            _logEo = new S_data_move_logPO()
            {
                LogID = ObjectId.NewId(),
                DataMoveID = _option.DataMoveID,
                DatabaseName = _option.DatabaseName,
                TableName = _option.TableName,
                HandleMode = _option.HandleMode,
                KeepValue = _option.KeepValue,
                Status = 0, //状态 0-运行中1-成功2-失败
                RecDate = DateTime.UtcNow, //当天仅运行一条
                ExecSQL = string.Empty
            };
            await DbUtil.GetRepository<S_data_move_logPO>().InsertAsync(_logEo);
        }

        protected async Task<DateTime> GetMinDate(DateTime endDate)
        {
            var where = $"`{_option.DateFieldName}` < @EndDate";
            if (!string.IsNullOrEmpty(_option.WhereStatement))
            {
                var stat = _option.WhereStatement.ToUpper().Trim().TrimStart("AND ");
                where = $"{where} AND {stat}";
            }

            var begin =  await _database.Ado.GetScalarAsync($"SELECT MIN(`{_option.DateFieldName}`)"
                + $" FROM `{_option.TableName}` WHERE {where}", new SugarParameter("@EndDate", endDate));
            if (begin is DBNull || begin == null)
            {
                return DateTime.MaxValue;
            }
            else
            {
                var ret = begin.ConvertTo<DateTime>();
                return new DateTime(ret.Year, ret.Month, ret.Day);
            }
        }

        protected List<DateTime> GetDayList(DateTime beginDate, DateTime endDate)
        {
            var ret = new List<DateTime>();
            var currDate = beginDate;
            while (currDate < endDate)
            {
                ret.Add(currDate);
                currDate = currDate.AddDays(1);
            }
            return ret;
        }
        protected string GetWhereByDay(DateTime currDate)
        {
            var ret = $"`{_option.DateFieldName}`>='{currDate.ToString("yyyy-MM-dd")}' AND {_option.DateFieldName}<'{currDate.AddDays(1).ToString("yyyy-MM-dd")}'";
            if (!string.IsNullOrEmpty(_option.WhereStatement))
            {
                var where = _option.WhereStatement.ToUpper().Trim().TrimStart("AND ");
                ret = $"{ret} AND {where}";
            }
            return ret;
        }
    }
}
