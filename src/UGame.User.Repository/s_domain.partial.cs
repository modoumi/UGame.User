using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.User.Repository
{
    public partial class S_domainPO
    {
        #region AiUo
        public static implicit operator S_domainEO(S_domainPO value)
        {
            if (value==null) return null;
            return new S_domainEO
            {
		        DomainID = value.DomainID,
		        OperatorID = value.OperatorID,
		        IsHttps = value.IsHttps,
		        IsStats = value.IsStats,
		        Note = value.Note,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator S_domainPO(S_domainEO value)
        {
            if (value==null) return null;
            return new S_domainPO
            {
		        DomainID = value.DomainID,
		        OperatorID = value.OperatorID,
		        IsHttps = value.IsHttps,
		        IsStats = value.IsStats,
		        Note = value.Note,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}