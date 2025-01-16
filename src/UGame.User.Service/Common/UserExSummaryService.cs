using Serilog.Enrichers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Data;
using UGame.User.Common; 
using UGame.User.MQ.Xxyy;
using UGame.User.MQ.Bank;

namespace UGame.User.Service.Common
{
    internal class UserExSummaryService
    {
        public async Task<int> AddTotalBetWin(string userId, long betAmount, long winAmount, TransactionManager tm)
        {
            var set = $"TotalBetAmount=TotalBetAmount+{betAmount},TotalWinAmount=TotalWinAmount+{winAmount}";
            if (betAmount > 0)
                set += $",TotalBetCount=TotalBetCount+1";
            if (winAmount > 0 || (betAmount == 0 && winAmount == 0))
                set += $",TotalWinCount=TotalWinCount+1";
            return await DbSink.BuildUserExMo(userId)
                .PutByPKAsync(userId, set, tm);
        }

        /// <summary>
        /// 累计totalbet，taotalwin并计算新货币算法的可提现额
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="betRatioOfWithdrawAmount">用户bet的计算比例,介于0和1</param>
        /// <param name="winRatioOfWithdrawAmount">用户reward的计算比例,介于0和1</param>
        /// <param name="tm"></param>
        /// <returns></returns>
        public async Task<int> AddTotalBetWin(UserBetMsg msg,decimal betRatioOfWithdrawAmount,decimal winRatioOfWithdrawAmount, TransactionManager tm)
        {
            string userId = msg.UserId;
            long betAmount = msg.BetAmount; 
            long winAmount=msg.WinAmount;
            var set = $"TotalBetAmount=TotalBetAmount+{betAmount},TotalWinAmount=TotalWinAmount+{winAmount}";
            if (betAmount > 0)
                set += $",TotalBetCount=TotalBetCount+1";
            if (winAmount > 0 || (betAmount == 0 && winAmount == 0))
                set += $",TotalWinCount=TotalWinCount+1";
            //计算可提现额
            //真金下注
            var betCashAmount = msg.BetAmount - msg.BetBonus;
            if (betCashAmount>0)
                set += $",BetCashAmount=BetCashAmount+{betCashAmount}";
            //真金返奖
            var winCashAmount = msg.WinAmount- msg.WinBonus;
            if(winCashAmount > 0)
                set += $",WinCashAmount=WinCashAmount+{winCashAmount}";
            //真金balance
            var balanceCashAmount = msg.EndBalance - msg.EndBonus;
            if(balanceCashAmount < 0)
                balanceCashAmount = 0;
            set += $",BalanceCashAmount={balanceCashAmount}";

            var setWithdrawAmountFunc = (int flag) => flag switch { 
            0 => (betRatioOfWithdrawAmount, winRatioOfWithdrawAmount) switch
            {
                (0m, 0m) => "BalanceCashAmount",
                (0m, _) => $"LEAST(WinCashAmount*{winRatioOfWithdrawAmount},BalanceCashAmount)",
                (_, 0m) => $"LEAST(BetCashAmount*{betRatioOfWithdrawAmount},BalanceCashAmount)",
                _ => $"LEAST(BetCashAmount*{betRatioOfWithdrawAmount},WinCashAmount*{winRatioOfWithdrawAmount},BalanceCashAmount)"
            },
            1 => (betRatioOfWithdrawAmount, winRatioOfWithdrawAmount) switch
            {
                (0m, 0m) => "BalanceCashAmount-TempWithdrawAmount",
                (0m, _) => $"LEAST(WinCashAmount*{winRatioOfWithdrawAmount},BalanceCashAmount-TempWithdrawAmount)",
                (_, 0m) => $"LEAST(BetCashAmount*{betRatioOfWithdrawAmount},BalanceCashAmount-TempWithdrawAmount)",
                _ => $"LEAST(BetCashAmount*{betRatioOfWithdrawAmount},WinCashAmount*{winRatioOfWithdrawAmount},BalanceCashAmount-TempWithdrawAmount)"
            },
            _=>throw new ArgumentException($"{nameof(flag)}参数错误！不支持的值：{flag}") 
        };

            set += $",WithdrawAmount=case when TempWithdrawAmount=0 then {setWithdrawAmountFunc(0)} when TempWithdrawAmount>0 and BalanceCashAmount>TempWithdrawAmount then TempWithdrawAmount+{setWithdrawAmountFunc(1)} when TempWithdrawAmount>0 and BalanceCashAmount<=TempWithdrawAmount then {setWithdrawAmountFunc(0)} end,TempWithdrawAmount=case when TempWithdrawAmount>0 and BalanceCashAmount<=TempWithdrawAmount then 0 else TempWithdrawAmount end";
            return await DbSink.BuildUserExMo(userId)
                .PutByPKAsync(userId, set, tm);
        }
        public async Task AddTotalPay(string userId, long payAmount, bool isFirst, TransactionManager tm)
        {
            var set = $"TotalPayAmount=TotalPayAmount+{payAmount},TotalPayCount=TotalPayCount+1";
            if (isFirst)
                set += $", FirstPayAmount={payAmount}";
            await DbSink.BuildUserExMo(userId)
                .PutByPKAsync(userId, set, tm);
        }

        public async Task AddTotalPay(UserPayMsg message, TransactionManager tm)
        {
            string userId = message.UserId;
            long payAmount = message.PayAmount;
            bool isFirst = message.IsFirst;
            var set = $"TotalPayAmount=TotalPayAmount+{payAmount},TotalPayCount=TotalPayCount+1";
            if (isFirst)
                set += $", FirstPayAmount={payAmount}";
            //更新新货币算法计算可提现额字段
            var cashBalance = message.EndBalance - message.EndBonus;
            set += $",BetCashAmount=0,WinCashAmount=0,BalanceCashAmount={(cashBalance<0?0:cashBalance)},TempWithdrawAmount=WithdrawAmount";
            await DbSink.BuildUserExMo(userId)
                .PutByPKAsync(userId, set, tm);
        }

        public async Task AddTotalCash(string userId, long cashAmount, TransactionManager tm)
        {
            await DbSink.BuildUserExMo(userId)
                .PutByPKAsync(userId, $"TotalCashAmount=TotalCashAmount+{cashAmount},TotalCashCount=TotalCashCount+1", tm);
        }
    }
}
