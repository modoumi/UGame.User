using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.User.Repository
{
    public partial class S_operatorPO
    {
        #region AiUo
        public static implicit operator S_operatorEO(S_operatorPO value)
        {
            if (value==null) return null;
            return new S_operatorEO
            {
		        OperatorID = value.OperatorID,
		        OperatorBaseID = value.OperatorBaseID,
		        OperatorVersion = value.OperatorVersion,
		        CountryID = value.CountryID,
		        Langs = value.Langs,
		        CurrencyID = value.CurrencyID,
		        MapDomain = value.MapDomain,
		        LobbyUrl = value.LobbyUrl,
		        LobbyUrlStaging = value.LobbyUrlStaging,
		        LobbyUrlDebug = value.LobbyUrlDebug,
		        BankUrl = value.BankUrl,
		        BankUrlStaging = value.BankUrlStaging,
		        BankUrlDebug = value.BankUrlDebug,
		        BranchKey = value.BranchKey,
		        GAKey = value.GAKey,
		        Title = value.Title,
		        Note = value.Note,
		        EnableBonus = value.EnableBonus,
		        ChangeBalanceMode = value.ChangeBalanceMode,
		        FlowMode = value.FlowMode,
		        FirstPayFlowMultip = value.FirstPayFlowMultip,
		        PayFlowMultip = value.PayFlowMultip,
		        FlowBalance = value.FlowBalance,
		        FlowDevideBalance = value.FlowDevideBalance,
		        ClientThemes = value.ClientThemes,
		        WithdrawAmountMode = value.WithdrawAmountMode,
		        WithdrawRuleMode = value.WithdrawRuleMode,
		        Status = value.Status,
		        RecDate = value.RecDate,
		        OrderNum = value.OrderNum,
		        BetRatioOfWithdrawAmount = value.BetRatioOfWithdrawAmount,
		        WinRatioOfWithdrawAmount = value.WinRatioOfWithdrawAmount,
            };
        }
        public static implicit operator S_operatorPO(S_operatorEO value)
        {
            if (value==null) return null;
            return new S_operatorPO
            {
		        OperatorID = value.OperatorID,
		        OperatorBaseID = value.OperatorBaseID,
		        OperatorVersion = value.OperatorVersion,
		        CountryID = value.CountryID,
		        Langs = value.Langs,
		        CurrencyID = value.CurrencyID,
		        MapDomain = value.MapDomain,
		        LobbyUrl = value.LobbyUrl,
		        LobbyUrlStaging = value.LobbyUrlStaging,
		        LobbyUrlDebug = value.LobbyUrlDebug,
		        BankUrl = value.BankUrl,
		        BankUrlStaging = value.BankUrlStaging,
		        BankUrlDebug = value.BankUrlDebug,
		        BranchKey = value.BranchKey,
		        GAKey = value.GAKey,
		        Title = value.Title,
		        Note = value.Note,
		        EnableBonus = value.EnableBonus,
		        ChangeBalanceMode = value.ChangeBalanceMode,
		        FlowMode = value.FlowMode,
		        FirstPayFlowMultip = value.FirstPayFlowMultip,
		        PayFlowMultip = value.PayFlowMultip,
		        FlowBalance = value.FlowBalance,
		        FlowDevideBalance = value.FlowDevideBalance,
		        ClientThemes = value.ClientThemes,
		        WithdrawAmountMode = value.WithdrawAmountMode,
		        WithdrawRuleMode = value.WithdrawRuleMode,
		        Status = value.Status,
		        RecDate = value.RecDate,
		        OrderNum = value.OrderNum,
		        BetRatioOfWithdrawAmount = value.BetRatioOfWithdrawAmount,
		        WinRatioOfWithdrawAmount = value.WinRatioOfWithdrawAmount,
            };
        }
        #endregion
    }
}