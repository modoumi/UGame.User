﻿using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.DataMove.DAL
{
    ///<summary>
    ///数据迁移策略定义，就解决大表数据清理
    ///</summary>
    [SugarTable("s_data_move")]
    public partial class S_data_movePO
    {
           public S_data_movePO(){

            this.HandleMode =0;
            this.NameMode =0;
            this.HandleOrder =0;
            this.KeepValue =0;
            this.BathPageSize =0;
            this.Status =0;

           }
           /// <summary>
           /// Desc:数据迁移编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int DataMoveID {get;set;}

           /// <summary>
           /// Desc:数据库名（配置文件连接名或连接字符串）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? DatabaseName {get;set;}

           /// <summary>
           /// Desc:表名
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string TableName {get;set;}

           /// <summary>
           /// Desc:时间字段名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? DateFieldName {get;set;}

           /// <summary>
           /// Desc:索引名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? IndexName {get;set;}

           /// <summary>
           /// Desc:处理方式
			///              0-删除数据
			///              1-按年生成备份表：tablename_yyyy
			///              2-按季度生成备份表：tablename_yyyy1,2,3,4
			///              3-按月生成备份表：tablename_yyyyMM
			///              4-按日生成备份表：tablename_yyyyMMdd
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int HandleMode {get;set;}

           /// <summary>
           /// Desc:备份表名处理规则
			/// 0-按处理方式默认规则
			/// 1-按年生成备份表：tablename_y'yyyy'
			/// 2-按季度生成备份表：tablename_q'yyyy1,2,3,4'
			/// 3-按月生成备份表：tablename_m'yyyyMM'
			/// 4-按周生成备份：tablename_w'yyyy52'
			/// 5-按日生成备份表：tablename_d'yyyyMMdd'
			/// 6-源表名_back
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int NameMode {get;set;}

           /// <summary>
           /// Desc:指定备份表名称（NameMode=7）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? BackupTableName {get;set;}

           /// <summary>
           /// Desc:处理顺序(小到大)
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int HandleOrder {get;set;}

           /// <summary>
           /// Desc:保留数据长度（根据HandleMode值不同）
			///              0-删除数据 ==> 表示保留的天数
			///              1-按年生成备份表：tablename_yyyy => 表示保留的年数
			///              2-按季度生成备份表：tablename_yyyy1,2,3,4 ==> 表示保留的季节数
			///              3-按月生成备份表：tablename_yyyyMM ==> 表示保留的月份数
			///              4-按日生成备份表：tablename_yyyyMMdd ==> 表示保留的天数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int KeepValue {get;set;}

           /// <summary>
           /// Desc:迁移数据的条件
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? WhereStatement {get;set;}

           /// <summary>
           /// Desc:批处理分页行数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int BathPageSize {get;set;}

           /// <summary>
           /// Desc:状态(0-无效1-有效)
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Status {get;set;}

    }
}
