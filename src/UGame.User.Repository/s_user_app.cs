using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.User.Repository
{
    ///<summary>
    ///用户所在应用的数据
    ///</summary>
    [SugarTable("s_user_app")]
    public partial class S_user_appPO
    {
           public S_user_appPO(){

            this.Status =0;
            this.RecDate =DateTime.Now;

           }
           /// <summary>
           /// Desc:用户编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string UserID {get;set;}

           /// <summary>
           /// Desc:应用编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string AppID {get;set;}

           /// <summary>
           /// Desc:最后一次访问时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime LastLoginDate {get;set;}

           /// <summary>
           /// Desc:状态
			///              0-未知
			///              1-有效
			///              2-用户数据异常封闭
			///              9-系统封闭
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Status {get;set;}

           /// <summary>
           /// Desc:记录时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

    }
}
