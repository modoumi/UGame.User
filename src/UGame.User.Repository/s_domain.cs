using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.User.Repository
{
    ///<summary>
    ///域名
    ///</summary>
    [SugarTable("s_domain")]
    public partial class S_domainPO
    {
           public S_domainPO(){

            this.IsHttps =true;
            this.IsStats =false;
            this.RecDate =DateTime.Now;

           }
           /// <summary>
           /// Desc:域名（不带http）
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string DomainID {get;set;}

           /// <summary>
           /// Desc:运营商编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? OperatorID {get;set;}

           /// <summary>
           /// Desc:是否是https(跨域)
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public bool IsHttps {get;set;}

           /// <summary>
           /// Desc:是否统计
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public bool IsStats {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Note {get;set;}

           /// <summary>
           /// Desc:记录时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

    }
}
