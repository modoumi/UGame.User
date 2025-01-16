using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.User.Repository
{
    ///<summary>
    ///货币定义大写 ISO 4217
    ///</summary>
    [SugarTable("s_currency")]
    public partial class S_currencyPO
    {
           public S_currencyPO(){

            this.BaseUnit =1.000000000000000000m;
            this.CurrencyType =0;
            this.Status =0;

           }
           /// <summary>
           /// Desc:货币编码（ISO 4217大写3位）
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string CurrencyID {get;set;}

           /// <summary>
           /// Desc:货币数字编码（ISO 4217 3位）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? CurrencyCode {get;set;}

           /// <summary>
           /// Desc:基础货币单位（1单位货币等于多少最小币值）
           /// Default:1.000000000000000000
           /// Nullable:False
           /// </summary>           
           public decimal BaseUnit {get;set;}

           /// <summary>
           /// Desc:货币名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Name {get;set;}

           /// <summary>
           /// Desc:货币类型 1-COIN 2--GOLD 3-POINT 4-SWB 8-虚拟货币 9-CASH
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int CurrencyType {get;set;}

           /// <summary>
           /// Desc:状态0-初始1-启用
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Status {get;set;}

    }
}
