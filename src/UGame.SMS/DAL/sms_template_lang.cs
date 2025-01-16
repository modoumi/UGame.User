using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.SMS.DAL
{
    ///<summary>
    ///短信运营商发送的语言和内容
    ///</summary>
    [SugarTable("sms_template_lang")]
    public partial class Sms_template_langPO
    {
           public Sms_template_langPO(){


           }
           /// <summary>
           /// Desc:模板ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int TemplateID {get;set;}

           /// <summary>
           /// Desc:语言
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string LangID {get;set;}

           /// <summary>
           /// Desc:内容
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Content {get;set;}

    }
}
