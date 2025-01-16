using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.User.Repository
{
    public partial class S_user_promoterPO
    {
        #region AiUo
        public static implicit operator S_user_promoterEO(S_user_promoterPO value)
        {
            if (value==null) return null;
            return new S_user_promoterEO
            {
		        PUserID = value.PUserID,
		        IUserID = value.IUserID,
		        PromoteTime = value.PromoteTime,
		        UserKind = value.UserKind,
		        OperatorID = value.OperatorID,
		        FromMode = value.FromMode,
		        FromId = value.FromId,
		        CountryID = value.CountryID,
		        CurrencyID = value.CurrencyID,
		        CurrencyType = value.CurrencyType,
            };
        }
        public static implicit operator S_user_promoterPO(S_user_promoterEO value)
        {
            if (value==null) return null;
            return new S_user_promoterPO
            {
		        PUserID = value.PUserID,
		        IUserID = value.IUserID,
		        PromoteTime = value.PromoteTime,
		        UserKind = value.UserKind,
		        OperatorID = value.OperatorID,
		        FromMode = value.FromMode,
		        FromId = value.FromId,
		        CountryID = value.CountryID,
		        CurrencyID = value.CurrencyID,
		        CurrencyType = value.CurrencyType,
            };
        }
        #endregion
    }
}