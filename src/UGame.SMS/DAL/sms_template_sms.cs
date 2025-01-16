using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.SMS.DAL
{
    ///<summary>
    ///短信渠道和模板
    ///</summary>
    [SugarTable("sms_template_sms")]
    public partial class Sms_template_smsPO
    {
           public Sms_template_smsPO(){

            this.OrderNum =0;
            this.Weight =0;
            this.Status =0;

           }
           /// <summary>
           /// Desc:运营商编码（小写，唯一）
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string OperatorID {get;set;}

           /// <summary>
           /// Desc:模板ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int TemplateID {get;set;}

           /// <summary>
           /// Desc:短信商编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string SmsID {get;set;}

           /// <summary>
           /// Desc:排序，从小到大
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int OrderNum {get;set;}

           /// <summary>
           /// Desc:权重
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Weight {get;set;}

           /// <summary>
           /// Desc:状态(0-无效1-有效)
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Status {get;set;}

    }
}
