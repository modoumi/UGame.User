using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo;
using UGame.DataMove.Common;

namespace UGame.DataMove
{
    public static class DataMoveUtil
    {
        /// <summary>
        /// 存储sql最大文本字符数量
        /// Text 21845 MEDIUMTEXT 5592405 LONGTEXT 143165576
        /// </summary>
        internal const int SQL_MAX_CHARS = 143165576;

        /// <summary>
        /// 执行数据迁移
        /// </summary>
        /// <returns></returns>
        public static Task MoveData()
        {
            return new DataMoveService().Execute();
        }

        public static BackupTableNameInfo ParseTableName(string backupTableName)
        {
            var values = backupTableName.Split('_');
            if (values == null || values.Length < 2)
                return null;

            var ret = new BackupTableNameInfo();
            ret.TableName = string.Join('_', values.SkipLast(1));
            var suffix = values.Last();
            switch (suffix[0])
            {
                case 'y':
                    ret.HandleMode = HandleMode.Year; break;
                case 'q':
                    ret.HandleMode = HandleMode.Quarter; break;
                case 'm':
                    ret.HandleMode = HandleMode.Month; break;
                case 'w':
                    ret.HandleMode = HandleMode.Week; break;
                case 'd':
                    ret.HandleMode = HandleMode.Day; break;
                default:
                    return null;
            }
            ret.Year = suffix.Substring(1, 4).ToInt32();
            ret.Suffix = suffix.Substring(5);
            return ret;
        }
    }
    public class BackupTableNameInfo
    {
        public string TableName { get; set; }
        public HandleMode HandleMode { get; set; }
        public int Year { get; set; }
        public string Suffix { get; set; }
    }
}
