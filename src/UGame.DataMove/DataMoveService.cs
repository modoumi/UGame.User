using Microsoft.Extensions.Logging;
using AiUo.Data.SqlSugar;
using AiUo.Logging;
using UGame.DataMove.Common;
using UGame.DataMove.DAL;

namespace UGame.DataMove
{
    public class DataMoveService
    {
        private ILogger<DataMoveService> _logger;
        public DataMoveService()
        {
            _logger = LogUtil.CreateLogger<DataMoveService>();
        }

        public async Task Execute()
        {
            var list = await DbUtil.GetRepository<S_data_movePO>().AsQueryable()
                .Where(it => it.Status == 1).OrderBy(it => it.HandleOrder).ToListAsync();
            foreach (var item in list)
            {
                try
                {
                    var mode = (HandleMode)item.HandleMode;
                    switch (mode)
                    {
                        case HandleMode.Delete:
                            await new DeleteJob(item).Execute();
                            break;
                        default:
                            await new BackupJob(item).Execute();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "执行数据备份迁移出现异常");
                }
            }
        }
    }
}
