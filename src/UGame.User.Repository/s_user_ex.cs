using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.User.Repository
{
    ///<summary>
    ///用户实时数据
    ///</summary>
    [SugarTable("s_user_ex")]
    public partial class S_user_exPO
    {
           public S_user_exPO(){

            this.UserKind =0;
            this.TotalBonus =0;
            this.TotalBonusCount =0;
            this.TotalChangeAmount =0;
            this.TotalChangeCount =0;
            this.TotalBetAmount =0;
            this.TotalBetCount =0;
            this.TotalWinAmount =0;
            this.TotalWinCount =0;
            this.TotalPayAmount =0;
            this.TotalPayCount =0;
            this.TotalCashAmount =0;
            this.TotalCashCount =0;
            this.FirstPayAmount =0;
            this.BetCashAmount =0;
            this.WinCashAmount =0;
            this.BalanceCashAmount =0;
            this.TempWithdrawAmount =0;
            this.WithdrawAmount =0;

           }
           /// <summary>
           /// Desc:用户编码(GUID)
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string UserID {get;set;}

           /// <summary>
           /// Desc:用户类型
			///              0-未知
			///              1-普通用户
			///              2-开发用户
			///              3-线上测试用户（调用第三方扣减）
			///              4-线上测试用户（不调用第三方扣减）
			///              5-仿真用户
			///              6-接口联调用户
			///              9-管理员
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int UserKind {get;set;}

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
           /// Desc:货币类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? CurrencyID {get;set;}

           /// <summary>
           /// Desc:赠金总额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long TotalBonus {get;set;}

           /// <summary>
           /// Desc:赠金次数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int TotalBonusCount {get;set;}

           /// <summary>
           /// Desc:变化总额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long TotalChangeAmount {get;set;}

           /// <summary>
           /// Desc:变化次数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int TotalChangeCount {get;set;}

           /// <summary>
           /// Desc:下注总额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long TotalBetAmount {get;set;}

           /// <summary>
           /// Desc:下注次数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int TotalBetCount {get;set;}

           /// <summary>
           /// Desc:返奖总额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long TotalWinAmount {get;set;}

           /// <summary>
           /// Desc:返奖次数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int TotalWinCount {get;set;}

           /// <summary>
           /// Desc:充值总额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long TotalPayAmount {get;set;}

           /// <summary>
           /// Desc:充值次数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int TotalPayCount {get;set;}

           /// <summary>
           /// Desc:提现总额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long TotalCashAmount {get;set;}

           /// <summary>
           /// Desc:提现次数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int TotalCashCount {get;set;}

           /// <summary>
           /// Desc:第一次充值金额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int FirstPayAmount {get;set;}

           /// <summary>
           /// Desc:真金下注总额(计算可提现金额,会重置)
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long BetCashAmount {get;set;}

           /// <summary>
           /// Desc:真金返奖总额(计算可提现金额,会重置)
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long WinCashAmount {get;set;}

           /// <summary>
           /// Desc:真金余额(计算可提现金额)
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long BalanceCashAmount {get;set;}

           /// <summary>
           /// Desc:充值后的临时可提现真金金额(计算可提现金额)
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long TempWithdrawAmount {get;set;}

           /// <summary>
           /// Desc:可提现真金金额(计算可提现金额)
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long WithdrawAmount {get;set;}

    }
}
