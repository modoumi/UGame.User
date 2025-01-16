using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.User.Repository
{
    public partial class S_operator_appPO
    {
        #region AiUo
        public static implicit operator S_operator_appEO(S_operator_appPO value)
        {
            if (value==null) return null;
            return new S_operator_appEO
            {
		        AppID = value.AppID,
		        OperatorID = value.OperatorID,
		        OperatorAppId = value.OperatorAppId,
		        UseBonus = value.UseBonus,
		        CashLimit = value.CashLimit,
		        PayLimit = value.PayLimit,
		        ActivityIds = value.ActivityIds,
		        AppUrl = value.AppUrl,
		        AppUrlStaging = value.AppUrlStaging,
		        AppUrlDebug = value.AppUrlDebug,
		        Status = value.Status,
		        EffectStatus = value.EffectStatus,
		        OperatorThumb = value.OperatorThumb,
		        OperatorBg = value.OperatorBg,
		        OperatorRoundUrl = value.OperatorRoundUrl,
            };
        }
        public static implicit operator S_operator_appPO(S_operator_appEO value)
        {
            if (value==null) return null;
            return new S_operator_appPO
            {
		        AppID = value.AppID,
		        OperatorID = value.OperatorID,
		        OperatorAppId = value.OperatorAppId,
		        UseBonus = value.UseBonus,
		        CashLimit = value.CashLimit,
		        PayLimit = value.PayLimit,
		        ActivityIds = value.ActivityIds,
		        AppUrl = value.AppUrl,
		        AppUrlStaging = value.AppUrlStaging,
		        AppUrlDebug = value.AppUrlDebug,
		        Status = value.Status,
		        EffectStatus = value.EffectStatus,
		        OperatorThumb = value.OperatorThumb,
		        OperatorBg = value.OperatorBg,
		        OperatorRoundUrl = value.OperatorRoundUrl,
            };
        }
        #endregion
    }
}