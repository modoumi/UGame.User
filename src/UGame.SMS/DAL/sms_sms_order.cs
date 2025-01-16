using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.SMS.DAL
{
    ///<summary>
    ///sms订单
    ///</summary>
    [SugarTable("sms_sms_order")]
    public partial class Sms_sms_orderPO
    {
           public Sms_sms_orderPO(){

            this.Status =0;
            this.RecDate =DateTime.Now;
            this.SettlStatus =0;

           }
           /// <summary>
           /// Desc:订单ID GUID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string OrderID {get;set;}

           /// <summary>
           /// Desc:应用提供商编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? ProviderID {get;set;}

           /// <summary>
           /// Desc:应用编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? AppID {get;set;}

           /// <summary>
           /// Desc:运营商编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? OperatorID {get;set;}

           /// <summary>
           /// Desc:国家编码ISO 3166-1三位字母
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? CountryID {get;set;}

           /// <summary>
           /// Desc:短信商渠道编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? SmsID {get;set;}

           /// <summary>
           /// Desc:短信商编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string SmsBaseID {get;set;}

           /// <summary>
           /// Desc:手机号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Mobile {get;set;}

           /// <summary>
           /// Desc:模板ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int TemplateID {get;set;}

           /// <summary>
           /// Desc:语言
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? LangID {get;set;}

           /// <summary>
           /// Desc:内容
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Content {get;set;}

           /// <summary>
           /// Desc:请求时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime RequestTime {get;set;}

           /// <summary>
           /// Desc:请求消息（我方请求或对方请求）json
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? RequestBody {get;set;}

           /// <summary>
           /// Desc:状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理
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

           /// <summary>
           /// Desc:返回时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ResponseTime {get;set;}

           /// <summary>
           /// Desc:响应消息（对方响应或我方响应）json
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? ResponseBody {get;set;}

           /// <summary>
           /// Desc:异常消息
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Exception {get;set;}

           /// <summary>
           /// Desc:短信商返回码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? SmsCode {get;set;}

           /// <summary>
           /// Desc:短信商订单编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? SmsOrderId {get;set;}

           /// <summary>
           /// Desc:结算表名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? SettlTable {get;set;}

           /// <summary>
           /// Desc:结算编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? SettlId {get;set;}

           /// <summary>
           /// Desc:结算状态（0-未结算1-已结算）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int SettlStatus {get;set;}

    }
}
