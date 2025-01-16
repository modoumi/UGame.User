using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.SMS.DAL
{
    ///<summary>
    ///短信模板
    ///</summary>
    [SugarTable("sms_template")]
    public partial class Sms_templatePO
    {
           public Sms_templatePO(){

            this.SelectSmsMode =0;
            this.RecDate =DateTime.Now;

           }
           /// <summary>
           /// Desc:模板ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int TemplateID {get;set;}

           /// <summary>
           /// Desc:名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Name {get;set;}

           /// <summary>
           /// Desc:模板类型0-模板短信 1-内容短信
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int TemplateType {get;set;}

           /// <summary>
           /// Desc:应用编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? AppID {get;set;}

           /// <summary>
           /// Desc:应用模板编码（应用内唯一）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? AppCode {get;set;}

           /// <summary>
           /// Desc:选取sms渠道规则1-OrderNum1-weight权重2-平均
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int SelectSmsMode {get;set;}

           /// <summary>
           /// Desc:记录时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

    }
}
