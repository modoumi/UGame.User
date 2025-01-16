using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.User.Repository
{
    ///<summary>
    ///应用提供商调用我方接口订单
    ///</summary>
    [SugarTable("s_provider_order")]
    public partial class S_provider_orderPO
    {
           public S_provider_orderPO(){

            this.FromMode =0;
            this.UserKind =0;
            this.CurrencyType =0;
            this.PromoterType =2;
            this.ReqMark =0;
            this.RoundClosed =true;
            this.IsFree =false;
            this.PlanBet =0;
            this.PlanWin =0;
            this.PlanAmount =0;
            this.Status =0;
            this.RecDate =DateTime.Now;
            this.Amount =0;
            this.EndBalance =0;
            this.BetBonus =0;
            this.WinBonus =0;
            this.EndBonus =0;
            this.AmountBonus =0;
            this.AmountCoin =0;
            this.EndCoin =0;
            this.SettlAmount =0;
            this.SettlStatus =0;

           }
           /// <summary>
           /// Desc:供应商请求生成的订单编码 GUID
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
           /// Desc:用户编码(GUID)
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? UserID {get;set;}

           /// <summary>
           /// Desc:新用户来源方式
			///              0-获得运营商的新用户(s_operator)
			///              1-推广员获得的新用户（userid）
			///              2-推广渠道通过url获得的新用户（s_channel_url)
			///              3-推广渠道通过code获得的新用户（s_channel_code)
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int FromMode {get;set;}

           /// <summary>
           /// Desc:对应的编码（根据FromMode变化）
			///              FromMode=
			///              0-运营商的新用户(s_operator)==> OperatorID
			///              1-推广员获得的新用户（userid） ==> 邀请人的UserID
			///              2-推广渠道通过url获得的新用户（s_channel_url) ==> CUrlID
			///              3-推广渠道通过code获得的新用户（s_channel_code) ==> CCodeID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? FromId {get;set;}

           /// <summary>
           /// Desc:域名（不带http）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? DomainID {get;set;}

           /// <summary>
           /// Desc:用户类型
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int UserKind {get;set;}

           /// <summary>
           /// Desc:国家编码ISO 3166-1三位字母
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? CountryID {get;set;}

           /// <summary>
           /// Desc:货币类型（货币缩写RMB,USD）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? CurrencyID {get;set;}

           /// <summary>
           /// Desc:货币类型 1-COIN 2--GOLD 3-POINT 4-SWB 8-虚拟货币 9-CASH
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int CurrencyType {get;set;}

           /// <summary>
           /// Desc:推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育
           /// Default:2
           /// Nullable:False
           /// </summary>           
           public int PromoterType {get;set;}

           /// <summary>
           /// Desc:请求接口类型（0-balance1-Bet 2-Win 3-BetWin4-Rollback）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int ReqMark {get;set;}

           /// <summary>
           /// Desc:请求唯一号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? RequestUUID {get;set;}

           /// <summary>
           /// Desc:应用提供商订单编码(TransactionUUID)
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? ProviderOrderId {get;set;}

           /// <summary>
           /// Desc:应用提供商原始订单编码(ReferenceTransactionUUID)
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? ReferProviderOrderId {get;set;}

           /// <summary>
           /// Desc:回合是否关闭
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public bool RoundClosed {get;set;}

           /// <summary>
           /// Desc:回合标识
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? RoundId {get;set;}

           /// <summary>
           /// Desc:我方提供的奖励id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? RewardUUID {get;set;}

           /// <summary>
           /// Desc:是否促销产生的交易
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public bool IsFree {get;set;}

           /// <summary>
           /// Desc:计划下注数量（正数）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long PlanBet {get;set;}

           /// <summary>
           /// Desc:计划返奖数量（正数）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long PlanWin {get;set;}

           /// <summary>
           /// Desc:计划账户变化数量（正负数）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long PlanAmount {get;set;}

           /// <summary>
           /// Desc:扩展数据
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Meta {get;set;}

           /// <summary>
           /// Desc:用户IP
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? UserIp {get;set;}

           /// <summary>
           /// Desc:状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Status {get;set;}

           /// <summary>
           /// Desc:订单时间
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
           /// Desc:返回状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? ResponseStatus {get;set;}

           /// <summary>
           /// Desc:实际账户变化数量（正负数）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long Amount {get;set;}

           /// <summary>
           /// Desc:处理后余额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long EndBalance {get;set;}

           /// <summary>
           /// Desc:下注时扣除的bonus
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long BetBonus {get;set;}

           /// <summary>
           /// Desc:返奖时增加的bonus
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long WinBonus {get;set;}

           /// <summary>
           /// Desc:处理后bonus余额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long EndBonus {get;set;}

           /// <summary>
           /// Desc:bonus实际变化数量（正负数）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long AmountBonus {get;set;}

           /// <summary>
           /// Desc:实际coin变化（正负数）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long AmountCoin {get;set;}

           /// <summary>
           /// Desc:处理后coin余额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long EndCoin {get;set;}

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
           /// Desc:结算金额(正负数)
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long SettlAmount {get;set;}

           /// <summary>
           /// Desc:结算状态（0-未结算1-已结算）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int SettlStatus {get;set;}

    }
}
