using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.User.Repository
{
    public partial class S_appPO
    {
        #region AiUo
        public static implicit operator S_appEO(S_appPO value)
        {
            if (value==null) return null;
            return new S_appEO
            {
		        AppID = value.AppID,
		        ProviderID = value.ProviderID,
		        ProviderAppId = value.ProviderAppId,
		        AppName = value.AppName,
		        AppType = value.AppType,
		        PromoterType = value.PromoterType,
		        ServerType = value.ServerType,
		        ServerUrl = value.ServerUrl,
		        ServerUrl2 = value.ServerUrl2,
		        ServerUrl3 = value.ServerUrl3,
		        ServerUrlStaging = value.ServerUrlStaging,
		        ServerUrlDebug = value.ServerUrlDebug,
		        FlowRatio = value.FlowRatio,
		        Langs = value.Langs,
		        Note = value.Note,
		        Status = value.Status,
		        HasJackpot = value.HasJackpot,
            };
        }
        public static implicit operator S_appPO(S_appEO value)
        {
            if (value==null) return null;
            return new S_appPO
            {
		        AppID = value.AppID,
		        ProviderID = value.ProviderID,
		        ProviderAppId = value.ProviderAppId,
		        AppName = value.AppName,
		        AppType = value.AppType,
		        PromoterType = value.PromoterType,
		        ServerType = value.ServerType,
		        ServerUrl = value.ServerUrl,
		        ServerUrl2 = value.ServerUrl2,
		        ServerUrl3 = value.ServerUrl3,
		        ServerUrlStaging = value.ServerUrlStaging,
		        ServerUrlDebug = value.ServerUrlDebug,
		        FlowRatio = value.FlowRatio,
		        Langs = value.Langs,
		        Note = value.Note,
		        Status = value.Status,
		        HasJackpot = value.HasJackpot,
            };
        }
        #endregion
    }
}