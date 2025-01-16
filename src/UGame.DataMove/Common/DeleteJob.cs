using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using AiUo.Logging;
using UGame.DataMove.DAL;

namespace UGame.DataMove.Common
{
    public class DeleteJob : BaseDataMoveJob
    {
        private const int LIMIT_ROWS = 10000;
        public DeleteJob(S_data_movePO option) : base(option)
        {
            if ((HandleMode)option.HandleMode != HandleMode.Delete)
                throw new Exception("HandleMode必须是Delete=0");
        }

        protected override async Task ExecuteJob()
        {
            //实际操作数据：beginDate <= target < endDate
            var endDate = DateTime.UtcNow.AddDays(-_option.KeepValue).Date;
            var beginDate = await GetMinDate(endDate);
            if (beginDate == DateTime.MaxValue)
                return;
            AddLogToExecSQL($"==>开始删除{_option.TableName} {beginDate} => {endDate}");

            _logEo.BeginDate = beginDate;
            _logEo.EndDate = endDate;
            var dateList = GetDayList(beginDate, endDate);
            foreach (var currDate in dateList)
            {
                var sql = $"DELETE FROM `{_option.TableName}` WHERE {GetWhereByDay(currDate)}";
                AddLogToExecSQL($"SQL: {sql}");
                while (true)
                {
                    var rows = await _database.Ado.ExecuteCommandAsync($"{sql} LIMIT {LIMIT_ROWS}");
                    if (rows == 0) break;
                    _logEo.RowNum += rows;
                    await Task.Delay(200);
                }
            }
            AddLogToExecSQL($"==>完成删除{_option.TableName} {beginDate} => {endDate} count: {_logEo.RowNum}");
        }
    }
}
