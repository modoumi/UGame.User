using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.User.Repository
{
    public partial class S_provider_orderPO
    {
        #region AiUo
        public static implicit operator S_provider_orderEO(S_provider_orderPO value)
        {
            if (value==null) return null;
            return new S_provider_orderEO
            {
		        OrderID = value.OrderID,
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
		        PromoterType = value.PromoterType,
		        ReqMark = value.ReqMark,
		        RequestUUID = value.RequestUUID,
		        ProviderOrderId = value.ProviderOrderId,
		        ReferProviderOrderId = value.ReferProviderOrderId,
		        RoundClosed = value.RoundClosed,
		        RoundId = value.RoundId,
		        RewardUUID = value.RewardUUID,
		        IsFree = value.IsFree,
		        PlanBet = value.PlanBet,
		        PlanWin = value.PlanWin,
		        PlanAmount = value.PlanAmount,
		        Meta = value.Meta,
		        UserIp = value.UserIp,
		        Status = value.Status,
		        RecDate = value.RecDate,
		        ResponseTime = value.ResponseTime,
		        ResponseStatus = value.ResponseStatus,
		        Amount = value.Amount,
		        EndBalance = value.EndBalance,
		        BetBonus = value.BetBonus,
		        WinBonus = value.WinBonus,
		        EndBonus = value.EndBonus,
		        AmountBonus = value.AmountBonus,
		        AmountCoin = value.AmountCoin,
		        EndCoin = value.EndCoin,
		        SettlTable = value.SettlTable,
		        SettlId = value.SettlId,
		        SettlAmount = value.SettlAmount,
		        SettlStatus = value.SettlStatus,
            };
        }
        public static implicit operator S_provider_orderPO(S_provider_orderEO value)
        {
            if (value==null) return null;
            return new S_provider_orderPO
            {
		        OrderID = value.OrderID,
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
		        PromoterType = value.PromoterType,
		        ReqMark = value.ReqMark,
		        RequestUUID = value.RequestUUID,
		        ProviderOrderId = value.ProviderOrderId,
		        ReferProviderOrderId = value.ReferProviderOrderId,
		        RoundClosed = value.RoundClosed,
		        RoundId = value.RoundId,
		        RewardUUID = value.RewardUUID,
		        IsFree = value.IsFree,
		        PlanBet = value.PlanBet,
		        PlanWin = value.PlanWin,
		        PlanAmount = value.PlanAmount,
		        Meta = value.Meta,
		        UserIp = value.UserIp,
		        Status = value.Status,
		        RecDate = value.RecDate,
		        ResponseTime = value.ResponseTime,
		        ResponseStatus = value.ResponseStatus,
		        Amount = value.Amount,
		        EndBalance = value.EndBalance,
		        BetBonus = value.BetBonus,
		        WinBonus = value.WinBonus,
		        EndBonus = value.EndBonus,
		        AmountBonus = value.AmountBonus,
		        AmountCoin = value.AmountCoin,
		        EndCoin = value.EndCoin,
		        SettlTable = value.SettlTable,
		        SettlId = value.SettlId,
		        SettlAmount = value.SettlAmount,
		        SettlStatus = value.SettlStatus,
            };
        }
        #endregion
    }
}