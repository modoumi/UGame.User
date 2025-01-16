using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Data;
using AiUo.Data.SqlSugar;

namespace UGame.User.Common.Services
{
    public class CurrencyChangeReq
    {
        public string UserId { get; set; }
        public string AppId { get; set; }
        public string OperatorId { get; set; }
        public string CurrencyId { get; set; }
        /// <summary>
        /// 货币变化模式
        /// </summary>
        public CurrencyChangeBalance ChangeBalance { get; set; } = CurrencyChangeBalance.Bonus;
        /// <summary>
        /// bonus提现时需要的流水倍数
        /// </summary>
        public float FlowMultip { get; set; }

        public string Reason { get; set; }
        public long Amount { get; set; }

        /// <summary>
        /// bonus变化额
        /// </summary>
        public long BonusAmount { get; set; }
        public object Meta { get; set; }
        /// <summary>
        /// 业务类型（统计维度）与平台统一分配
        /// </summary>
        public int SourceType { get; set; }
        public string SourceTable { get; set; }
        public string SourceId { get; set; }
        public DateTime ChangeTime { get; set; }
        public TransactionManager TM { get; set; }
        public DbTransactionManager DbTM { get; set; }
        public string UserIp { get; set; }
    }

}
