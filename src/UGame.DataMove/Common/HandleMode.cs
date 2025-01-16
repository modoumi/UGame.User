using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGame.DataMove.Common
{
    public enum HandleMode
    {
        /// <summary>
        /// 删除数据
        /// </summary>
        Delete = 0,
        /// <summary>
        /// 按年生成备份表：tablename_y'yyyy'
        /// </summary>
        Year = 1,
        /// <summary>
        /// 按季度生成备份表：tablename_q'yyyy1,2,3,4'
        /// </summary>
        Quarter = 2,
        /// <summary>
        /// 按月生成备份表：tablename_m'yyyyMM'
        /// </summary>
        Month = 3,
        /// <summary>
        /// 按周生成备份：tablename_w'yyyy52'
        /// </summary>
        Week = 4,
        /// <summary>
        /// 按日生成备份表：tablename_d'yyyyMMdd'
        /// </summary>
        Day = 5,
    }
}
