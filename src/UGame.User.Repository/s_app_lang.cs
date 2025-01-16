using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.User.Repository
{
    ///<summary>
    ///app多语言定义
    ///</summary>
    [SugarTable("s_app_lang")]
    public partial class S_app_langPO
    {
           public S_app_langPO(){


           }
           /// <summary>
           /// Desc:应用编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string AppID {get;set;}

           /// <summary>
           /// Desc:语言(空字符串表示默认)
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string LangID {get;set;}

           /// <summary>
           /// Desc:是否支持
           /// Default:
           /// Nullable:False
           /// </summary>           
           public bool IsSupport {get;set;}

           /// <summary>
           /// Desc:应用名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? AppName {get;set;}

           /// <summary>
           /// Desc:应用详细描述
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? AppDesc {get;set;}

    }
}
