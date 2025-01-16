using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.User.Repository
{
    public partial class S_user_exPO
    {
        #region AiUo
        public static implicit operator S_user_exEO(S_user_exPO value)
        {
            if (value==null) return null;
            return new S_user_exEO
            {
		        UserID = value.UserID,
		        UserKind = value.UserKind,
		        OperatorID = value.OperatorID,
		        CountryID = value.CountryID,
		        CurrencyID = value.CurrencyID,
		        TotalBonus = value.TotalBonus,
		        TotalBonusCount = value.TotalBonusCount,
		        TotalChangeAmount = value.TotalChangeAmount,
		        TotalChangeCount = value.TotalChangeCount,
		        TotalBetAmount = value.TotalBetAmount,
		        TotalBetCount = value.TotalBetCount,
		        TotalWinAmount = value.TotalWinAmount,
		        TotalWinCount = value.TotalWinCount,
		        TotalPayAmount = value.TotalPayAmount,
		        TotalPayCount = value.TotalPayCount,
		        TotalCashAmount = value.TotalCashAmount,
		        TotalCashCount = value.TotalCashCount,
		        FirstPayAmount = value.FirstPayAmount,
		        BetCashAmount = value.BetCashAmount,
		        WinCashAmount = value.WinCashAmount,
		        BalanceCashAmount = value.BalanceCashAmount,
		        TempWithdrawAmount = value.TempWithdrawAmount,
		        WithdrawAmount = value.WithdrawAmount,
            };
        }
        public static implicit operator S_user_exPO(S_user_exEO value)
        {
            if (value==null) return null;
            return new S_user_exPO
            {
		        UserID = value.UserID,
		        UserKind = value.UserKind,
		        OperatorID = value.OperatorID,
		        CountryID = value.CountryID,
		        CurrencyID = value.CurrencyID,
		        TotalBonus = value.TotalBonus,
		        TotalBonusCount = value.TotalBonusCount,
		        TotalChangeAmount = value.TotalChangeAmount,
		        TotalChangeCount = value.TotalChangeCount,
		        TotalBetAmount = value.TotalBetAmount,
		        TotalBetCount = value.TotalBetCount,
		        TotalWinAmount = value.TotalWinAmount,
		        TotalWinCount = value.TotalWinCount,
		        TotalPayAmount = value.TotalPayAmount,
		        TotalPayCount = value.TotalPayCount,
		        TotalCashAmount = value.TotalCashAmount,
		        TotalCashCount = value.TotalCashCount,
		        FirstPayAmount = value.FirstPayAmount,
		        BetCashAmount = value.BetCashAmount,
		        WinCashAmount = value.WinCashAmount,
		        BalanceCashAmount = value.BalanceCashAmount,
		        TempWithdrawAmount = value.TempWithdrawAmount,
		        WithdrawAmount = value.WithdrawAmount,
            };
        }
        #endregion
    }
}