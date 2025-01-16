using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.User.Repository
{
    ///<summary>
    ///供应商基础定义
    ///</summary>
    [SugarTable("s_operator_base")]
    public partial class S_operator_basePO
    {
           public S_operator_basePO(){

            this.OperatorType =1;
            this.AllowVisitor =false;
            this.SettlDayNum =0;
            this.Status =0;
            this.RecDate =DateTime.Now;
            this.CashAudit =1;
            this.LowestCashAmount =0;

           }
           /// <summary>
           /// Desc:运营商基础编码（小写，唯一）
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string OperatorBaseID {get;set;}

           /// <summary>
           /// Desc:运营商名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? OperatorName {get;set;}

           /// <summary>
           /// Desc:运营商类型
			///              0-自有
			///              1-第三方有用户有充值
			///              2-第三方有用户无充值
			///              3-第三方无用户无充值
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public int OperatorType {get;set;}

           /// <summary>
           /// Desc:独服混服类型(0-混服1-独服)
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? OperatorMode {get;set;}

           /// <summary>
           /// Desc:是否允许游客
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public bool AllowVisitor {get;set;}

           /// <summary>
           /// Desc:运营商公钥
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? OperPublicKey {get;set;}

           /// <summary>
           /// Desc:运营商私钥（仅测试）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? OperPrivateKey {get;set;}

           /// <summary>
           /// Desc:我方的公钥
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? OwnPublicKey {get;set;}

           /// <summary>
           /// Desc:我方的私钥
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? OwnPrivateKey {get;set;}

           /// <summary>
           /// Desc:运营商的配置信息
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? OperatorConfig {get;set;}

           /// <summary>
           /// Desc:备注信息
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Note {get;set;}

           /// <summary>
           /// Desc:结算日，如5表示每月结算包含5号
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int SettlDayNum {get;set;}

           /// <summary>
           /// Desc:状态(0-无效1-有效)
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
           /// Desc:运营商后台地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? OperAdminUrl {get;set;}

           /// <summary>
           /// Desc:运营商后台账号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? OperAdminUser {get;set;}

           /// <summary>
           /// Desc:运营商后台密码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? OperAdminPwd {get;set;}

           /// <summary>
           /// Desc:提现审计模式0-不审计1-审计
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public int CashAudit {get;set;}

           /// <summary>
           /// Desc:最低提现额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long LowestCashAmount {get;set;}

    }
}
