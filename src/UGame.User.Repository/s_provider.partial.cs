using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.User.Repository
{
    public partial class S_providerPO
    {
        #region AiUo
        public static implicit operator S_providerEO(S_providerPO value)
        {
            if (value==null) return null;
            return new S_providerEO
            {
		        ProviderID = value.ProviderID,
		        ProviderName = value.ProviderName,
		        ProviderType = value.ProviderType,
		        UseBonus = value.UseBonus,
		        ApiUrl = value.ApiUrl,
		        ApiUrlStaging = value.ApiUrlStaging,
		        ApiUrlDebug = value.ApiUrlDebug,
		        ProvPublicKey = value.ProvPublicKey,
		        ProvPrivateKey = value.ProvPrivateKey,
		        OwnPublicKey = value.OwnPublicKey,
		        OwnPrivateKey = value.OwnPrivateKey,
		        ProviderConfig = value.ProviderConfig,
		        Mobile = value.Mobile,
		        Email = value.Email,
		        Note = value.Note,
		        SettlDayNum = value.SettlDayNum,
		        Status = value.Status,
		        RecDate = value.RecDate,
		        AdminUser = value.AdminUser,
		        AdminPwd = value.AdminPwd,
		        ProvAdminUrl = value.ProvAdminUrl,
		        ProvAdminUser = value.ProvAdminUser,
		        ProvAdminPwd = value.ProvAdminPwd,
            };
        }
        public static implicit operator S_providerPO(S_providerEO value)
        {
            if (value==null) return null;
            return new S_providerPO
            {
		        ProviderID = value.ProviderID,
		        ProviderName = value.ProviderName,
		        ProviderType = value.ProviderType,
		        UseBonus = value.UseBonus,
		        ApiUrl = value.ApiUrl,
		        ApiUrlStaging = value.ApiUrlStaging,
		        ApiUrlDebug = value.ApiUrlDebug,
		        ProvPublicKey = value.ProvPublicKey,
		        ProvPrivateKey = value.ProvPrivateKey,
		        OwnPublicKey = value.OwnPublicKey,
		        OwnPrivateKey = value.OwnPrivateKey,
		        ProviderConfig = value.ProviderConfig,
		        Mobile = value.Mobile,
		        Email = value.Email,
		        Note = value.Note,
		        SettlDayNum = value.SettlDayNum,
		        Status = value.Status,
		        RecDate = value.RecDate,
		        AdminUser = value.AdminUser,
		        AdminPwd = value.AdminPwd,
		        ProvAdminUrl = value.ProvAdminUrl,
		        ProvAdminUser = value.ProvAdminUser,
		        ProvAdminPwd = value.ProvAdminPwd,
            };
        }
        #endregion
    }
}