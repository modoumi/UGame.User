using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.User.Repository
{
    public partial class S_currency_changePO
    {
        #region AiUo
        public static implicit operator S_currency_changeEO(S_currency_changePO value)
        {
            if (value==null) return null;
            return new S_currency_changeEO
            {
		        ChangeID = value.ChangeID,
		        ProviderID = value.ProviderID,
		        AppID = value.AppID,
		        OperatorID = value.OperatorID,
		        UserID = value.UserID,
		        FromMode = value.FromMode,
		        FromId = value.FromId,
		        DomainID = value.DomainID,
		        UserKind = value.UserKind,
		        CountryID = value.CountryID,
		        CurrencyID = value.CurrencyID,
		        CurrencyType = value.CurrencyType,
		        IsBonus = value.IsBonus,
		        FlowMultip = value.FlowMultip,
		        Reason = value.Reason,
		        PlanAmount = value.PlanAmount,
		        Meta = value.Meta,
		        SourceType = value.SourceType,
		        SourceTable = value.SourceTable,
		        SourceId = value.SourceId,
		        UserIp = value.UserIp,
		        Status = value.Status,
		        RecDate = value.RecDate,
		        DealTime = value.DealTime,
		        DealStatus = value.DealStatus,
		        Amount = value.Amount,
		        EndBalance = value.EndBalance,
		        AmountBonus = value.AmountBonus,
		        EndBonus = value.EndBonus,
		        AmountCoin = value.AmountCoin,
		        EndCoin = value.EndCoin,
		        SettlStatus = value.SettlStatus,
		        SettlTable = value.SettlTable,
		        SettlId = value.SettlId,
		        SettlAmount = value.SettlAmount,
            };
        }
        public static implicit operator S_currency_changePO(S_currency_changeEO value)
        {
            if (value==null) return null;
            return new S_currency_changePO
            {
		        ChangeID = value.ChangeID,
		        ProviderID = value.ProviderID,
		        AppID = value.AppID,
		        OperatorID = value.OperatorID,
		        UserID = value.UserID,
		        FromMode = value.FromMode,
		        FromId = value.FromId,
		        DomainID = value.DomainID,
		        UserKind = value.UserKind,
		        CountryID = value.CountryID,
		        CurrencyID = value.CurrencyID,
		        CurrencyType = value.CurrencyType,
		        IsBonus = value.IsBonus,
		        FlowMultip = value.FlowMultip,
		        Reason = value.Reason,
		        PlanAmount = value.PlanAmount,
		        Meta = value.Meta,
		        SourceType = value.SourceType,
		        SourceTable = value.SourceTable,
		        SourceId = value.SourceId,
		        UserIp = value.UserIp,
		        Status = value.Status,
		        RecDate = value.RecDate,
		        DealTime = value.DealTime,
		        DealStatus = value.DealStatus,
		        Amount = value.Amount,
		        EndBalance = value.EndBalance,
		        AmountBonus = value.AmountBonus,
		        EndBonus = value.EndBonus,
		        AmountCoin = value.AmountCoin,
		        EndCoin = value.EndCoin,
		        SettlStatus = value.SettlStatus,
		        SettlTable = value.SettlTable,
		        SettlId = value.SettlId,
		        SettlAmount = value.SettlAmount,
            };
        }
        #endregion
    }
}