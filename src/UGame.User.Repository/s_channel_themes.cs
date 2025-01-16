using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.User.Repository
{
    ///<summary>
    ///渠道+域名前端主题
    ///</summary>
    [SugarTable("s_channel_themes")]
    public partial class S_channel_themesPO
    {
           public S_channel_themesPO(){

            this.FlagType =0;

           }
           /// <summary>
           /// Desc:样式编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string ThemesID {get;set;}

           /// <summary>
           /// Desc:标识类型1-channelId 2-domain
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int FlagType {get;set;}

           /// <summary>
           /// Desc:标识内容
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string FlagValue {get;set;}

           /// <summary>
           /// Desc:Logo路径
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? LogoUrl {get;set;}

    }
}
