using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.User.Repository
{
    ///<summary>
    ///运营商
    ///</summary>
    [SugarTable("s_operator")]
    public partial class S_operatorPO
    {
           public S_operatorPO(){

            this.OperatorVersion =0;
            this.EnableBonus =true;
            this.ChangeBalanceMode =1;
            this.FlowMode =1;
            this.FirstPayFlowMultip =1;
            this.PayFlowMultip =1;
            this.FlowBalance =0;
            this.FlowDevideBalance =0;
            this.WithdrawAmountMode =0;
            this.WithdrawRuleMode =0;
            this.Status =0;
            this.RecDate =DateTime.Now;
            this.OrderNum =0;
            this.BetRatioOfWithdrawAmount =0.00m;
            this.WinRatioOfWithdrawAmount =0.00m;

           }
           /// <summary>
           /// Desc:运营商编码（小写，唯一）
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string OperatorID {get;set;}

           /// <summary>
           /// Desc:运营商基础编码（小写，唯一）
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string OperatorBaseID {get;set;}

           /// <summary>
           /// Desc:运营商逻辑版本0-基础版本1-长效版本
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int OperatorVersion {get;set;}

           /// <summary>
           /// Desc:国家编码ISO 3166-1三位字母
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? CountryID {get;set;}

           /// <summary>
           /// Desc:平台支持的语言。|分割
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Langs {get;set;}

           /// <summary>
           /// Desc:货币类型（货币缩写USD）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? CurrencyID {get;set;}

           /// <summary>
           /// Desc:对应的主域名如: 777gana.com
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? MapDomain {get;set;}

           /// <summary>
           /// Desc:大厅客户端线上URL
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? LobbyUrl {get;set;}

           /// <summary>
           /// Desc:大厅客户端仿真URL
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? LobbyUrlStaging {get;set;}

           /// <summary>
           /// Desc:大厅客户端调试URL
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? LobbyUrlDebug {get;set;}

           /// <summary>
           /// Desc:银行客户端线上URL
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? BankUrl {get;set;}

           /// <summary>
           /// Desc:银行客户端仿真URL
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? BankUrlStaging {get;set;}

           /// <summary>
           /// Desc:银行客户端调试URL
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? BankUrlDebug {get;set;}

           /// <summary>
           /// Desc:branch关键字
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? BranchKey {get;set;}

           /// <summary>
           /// Desc:GA关键字
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? GAKey {get;set;}

           /// <summary>
           /// Desc:运营商标题描述
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Title {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Note {get;set;}

           /// <summary>
           /// Desc:是否启用bonus（用户是否有bonus账户）
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public bool EnableBonus {get;set;}

           /// <summary>
           /// Desc:扣减balance模式1-优先bonus2-优先真金
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public int ChangeBalanceMode {get;set;}

           /// <summary>
           /// Desc:流水计算方式（不同的执行类）1-仅流水+充值2-下注-返奖；3:新的Bonus流水
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public int FlowMode {get;set;}

           /// <summary>
           /// Desc:首充流水倍数，如20倍
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public int FirstPayFlowMultip {get;set;}

           /// <summary>
           /// Desc:充值流水倍数，如20倍
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public int PayFlowMultip {get;set;}

           /// <summary>
           /// Desc:用户余额大于此值则流水需继承
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long FlowBalance {get;set;}

           /// <summary>
           /// Desc:流水除以用户余额的倍数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int FlowDevideBalance {get;set;}

           /// <summary>
           /// Desc:客户端样式配置
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? ClientThemes {get;set;}

           /// <summary>
           /// Desc:可提现金额模式0-真金余额 1-根据固定算法调整
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int WithdrawAmountMode {get;set;}

           /// <summary>
           /// Desc:提现规则模式0-短版本 1-长版本 2-新货币算法 3-自动提现审核
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int WithdrawRuleMode {get;set;}

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
           /// Desc:排序号
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? OrderNum {get;set;}

           /// <summary>
           /// Desc:用户bet的计算比例,0<=X<=1
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal BetRatioOfWithdrawAmount {get;set;}

           /// <summary>
           /// Desc:用户reward的计算比例,0<=Y<=1
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal WinRatioOfWithdrawAmount {get;set;}

    }
}
