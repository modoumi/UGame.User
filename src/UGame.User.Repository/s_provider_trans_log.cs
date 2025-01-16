using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.User.Repository
{
    ///<summary>
    ///与应用提供商通讯日志
    ///</summary>
    [SugarTable("s_provider_trans_log")]
    public partial class S_provider_trans_logPO
    {
           public S_provider_trans_logPO(){

            this.TransType =0;
            this.Status =0;
            this.RecDate =DateTime.Now;

           }
           /// <summary>
           /// Desc:请求应答日志编码(GUID)
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string TransLogID {get;set;}

           /// <summary>
           /// Desc:供应商请求生成的订单编码 GUID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? OrderID {get;set;}

           /// <summary>
           /// Desc:应用提供商编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? ProviderID {get;set;}

           /// <summary>
           /// Desc:运营商编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? OperatorID {get;set;}

           /// <summary>
           /// Desc:通讯类型(0-我方发起1-对方发起)
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int TransType {get;set;}

           /// <summary>
           /// Desc:通讯标记（接口标识）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? TransMark {get;set;}

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
           /// Desc:消息状态（0-初始1-返回成功2-返回失败）
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

    }
}
