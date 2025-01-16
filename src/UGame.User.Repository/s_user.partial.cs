using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.User.Repository
{
    public partial class S_userPO
    {
        #region AiUo
        public static implicit operator S_userEO(S_userPO value)
        {
            if (value==null) return null;
            return new S_userEO
            {
		        UserID = value.UserID,
		        UserMode = value.UserMode,
		        OAuthType = value.OAuthType,
		        OAuthID = value.OAuthID,
		        Nickname = value.Nickname,
		        FromMode = value.FromMode,
		        FromId = value.FromId,
		        OperatorID = value.OperatorID,
		        OperatorUserId = value.OperatorUserId,
		        CountryID = value.CountryID,
		        CurrencyID = value.CurrencyID,
		        Cash = value.Cash,
		        Bonus = value.Bonus,
		        Coin = value.Coin,
		        Gold = value.Gold,
		        SWB = value.SWB,
		        Point = value.Point,
		        VIP = value.VIP,
		        PUserID1 = value.PUserID1,
		        PUserID2 = value.PUserID2,
		        UserProfile = value.UserProfile,
		        UserKind = value.UserKind,
		        IMEI = value.IMEI,
		        GAID = value.GAID,
		        UserIp = value.UserIp,
		        ClientUrl = value.ClientUrl,
		        DomainID = value.DomainID,
		        ThemesID = value.ThemesID,
		        Status = value.Status,
		        RecDate = value.RecDate,
		        RegistDate = value.RegistDate,
		        LastLoginDate = value.LastLoginDate,
		        Mobile = value.Mobile,
		        Email = value.Email,
		        Username = value.Username,
		        Password = value.Password,
		        PasswordSalt = value.PasswordSalt,
		        HasBet = value.HasBet,
		        HasPay = value.HasPay,
		        HasCash = value.HasCash,
            };
        }
        public static implicit operator S_userPO(S_userEO value)
        {
            if (value==null) return null;
            return new S_userPO
            {
		        UserID = value.UserID,
		        UserMode = value.UserMode,
		        OAuthType = value.OAuthType,
		        OAuthID = value.OAuthID,
		        Nickname = value.Nickname,
		        FromMode = value.FromMode,
		        FromId = value.FromId,
		        OperatorID = value.OperatorID,
		        OperatorUserId = value.OperatorUserId,
		        CountryID = value.CountryID,
		        CurrencyID = value.CurrencyID,
		        Cash = value.Cash,
		        Bonus = value.Bonus,
		        Coin = value.Coin,
		        Gold = value.Gold,
		        SWB = value.SWB,
		        Point = value.Point,
		        VIP = value.VIP,
		        PUserID1 = value.PUserID1,
		        PUserID2 = value.PUserID2,
		        UserProfile = value.UserProfile,
		        UserKind = value.UserKind,
		        IMEI = value.IMEI,
		        GAID = value.GAID,
		        UserIp = value.UserIp,
		        ClientUrl = value.ClientUrl,
		        DomainID = value.DomainID,
		        ThemesID = value.ThemesID,
		        Status = value.Status,
		        RecDate = value.RecDate,
		        RegistDate = value.RegistDate,
		        LastLoginDate = value.LastLoginDate,
		        Mobile = value.Mobile,
		        Email = value.Email,
		        Username = value.Username,
		        Password = value.Password,
		        PasswordSalt = value.PasswordSalt,
		        HasBet = value.HasBet,
		        HasPay = value.HasPay,
		        HasCash = value.HasCash,
            };
        }
        #endregion
    }
}