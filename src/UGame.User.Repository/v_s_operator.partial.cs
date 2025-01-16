using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.User.Repository
{
    public partial class V_s_operatorPO
    {
        #region AiUo
        public static implicit operator V_s_operatorEO(V_s_operatorPO value)
        {
            if (value==null) return null;
            return new V_s_operatorEO
            {
		        OperatorID = value.OperatorID,
		        OperatorBaseID = value.OperatorBaseID,
		        OperatorName = value.OperatorName,
		        OperatorType = value.OperatorType,
		        OperatorMode = value.OperatorMode,
		        AllowVisitor = value.AllowVisitor,
		        OperPublicKey = value.OperPublicKey,
		        OperPrivateKey = value.OperPrivateKey,
		        OwnPublicKey = value.OwnPublicKey,
		        OwnPrivateKey = value.OwnPrivateKey,
		        OperatorConfig = value.OperatorConfig,
		        SettlDayNum = value.SettlDayNum,
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
		        EnableBonus = value.EnableBonus,
		        ChangeBalanceMode = value.ChangeBalanceMode,
		        FlowMode = value.FlowMode,
		        FirstPayFlowMultip = value.FirstPayFlowMultip,
		        PayFlowMultip = value.PayFlowMultip,
		        FlowBalance = value.FlowBalance,
		        FlowDevideBalance = value.FlowDevideBalance,
		        ClientThemes = value.ClientThemes,
		        WithdrawAmountMode = value.WithdrawAmountMode,
		        Status = value.Status,
		        CashAudit = value.CashAudit,
		        BetRatioOfWithdrawAmount = value.BetRatioOfWithdrawAmount,
		        WinRatioOfWithdrawAmount = value.WinRatioOfWithdrawAmount,
		        WithdrawRuleMode = value.WithdrawRuleMode,
		        Meta = value.Meta,
            };
        }
        public static implicit operator V_s_operatorPO(V_s_operatorEO value)
        {
            if (value==null) return null;
            return new V_s_operatorPO
            {
		        OperatorID = value.OperatorID,
		        OperatorBaseID = value.OperatorBaseID,
		        OperatorName = value.OperatorName,
		        OperatorType = value.OperatorType,
		        OperatorMode = value.OperatorMode,
		        AllowVisitor = value.AllowVisitor,
		        OperPublicKey = value.OperPublicKey,
		        OperPrivateKey = value.OperPrivateKey,
		        OwnPublicKey = value.OwnPublicKey,
		        OwnPrivateKey = value.OwnPrivateKey,
		        OperatorConfig = value.OperatorConfig,
		        SettlDayNum = value.SettlDayNum,
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
		        EnableBonus = value.EnableBonus,
		        ChangeBalanceMode = value.ChangeBalanceMode,
		        FlowMode = value.FlowMode,
		        FirstPayFlowMultip = value.FirstPayFlowMultip,
		        PayFlowMultip = value.PayFlowMultip,
		        FlowBalance = value.FlowBalance,
		        FlowDevideBalance = value.FlowDevideBalance,
		        ClientThemes = value.ClientThemes,
		        WithdrawAmountMode = value.WithdrawAmountMode,
		        Status = value.Status,
		        CashAudit = value.CashAudit,
		        BetRatioOfWithdrawAmount = value.BetRatioOfWithdrawAmount,
		        WinRatioOfWithdrawAmount = value.WinRatioOfWithdrawAmount,
		        WithdrawRuleMode = value.WithdrawRuleMode,
		        Meta = value.Meta,
            };
        }
        #endregion
    }
}