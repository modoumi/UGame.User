using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.SMS.DAL
{
    ///<summary>
    ///短信商的短信渠道
    ///</summary>
    [SugarTable("sms_sms")]
    public partial class Sms_smsPO
    {
           public Sms_smsPO(){

            this.SmsType =0;

           }
           /// <summary>
           /// Desc:短信商渠道编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string SmsID {get;set;}

           /// <summary>
           /// Desc:短信商编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? SmsBaseID {get;set;}

           /// <summary>
           /// Desc:描述
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Title {get;set;}

           /// <summary>
           /// Desc:渠道类型0-未知1-验证码2-推广
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int SmsType {get;set;}

           /// <summary>
           /// Desc:渠道配置参数信息
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? SmsConfig {get;set;}

    }
}
