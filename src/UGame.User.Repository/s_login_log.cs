using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.User.Repository
{
    ///<summary>
    ///原始用户登录日志
	/// 登录登出时都插入数据
    ///</summary>
    [SugarTable("s_login_log")]
    public partial class S_login_logPO
    {
           public S_login_logPO(){

            this.Status =0;
            this.RecDate =DateTime.Now;

           }
           /// <summary>
           /// Desc:日志编码(GUID)
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string LogID {get;set;}

           /// <summary>
           /// Desc:用户编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? UserID {get;set;}

           /// <summary>
           /// Desc:运营商编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? OperatorID {get;set;}

           /// <summary>
           /// Desc:应用编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? AppID {get;set;}

           /// <summary>
           /// Desc:登录时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? LoginDate {get;set;}

           /// <summary>
           /// Desc:退出时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? LogoutDate {get;set;}

           /// <summary>
           /// Desc:App版本号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? VersionID {get;set;}

           /// <summary>
           /// Desc:语言
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? LangID {get;set;}

           /// <summary>
           /// Desc:是否移动端
           /// Default:
           /// Nullable:True
           /// </summary>           
           public bool? IsMobile {get;set;}

           /// <summary>
           /// Desc:系统
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? OS {get;set;}

           /// <summary>
           /// Desc:浏览器
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Browser {get;set;}

           /// <summary>
           /// Desc:状态(0-失败1-成功)
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Status {get;set;}

           /// <summary>
           /// Desc:信息描述（错误原因）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Message {get;set;}

           /// <summary>
           /// Desc:用户IP
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? UserIp {get;set;}

           /// <summary>
           /// Desc:记录时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

    }
}
