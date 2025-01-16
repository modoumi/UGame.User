using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Data;
using UGame.User.Common.Services;
using UGame.User.MQ.Bank;
using UGame.User.MQ.Xxyy; 

namespace UGame.User.Service.Flow
{
    public interface IFlowDealService
    {
        /// <summary>
        /// 用户充值时流水处理
        /// </summary>
        /// <returns></returns>
        Task DealFlowWhenUserPay(UserPayMsg message);

        /// <summary>
        /// 用户下注时流水处理
        /// </summary>
        /// <returns></returns>
        Task DealFlowWhenUserBet(UserBetMsg message);

        /// <summary>
        /// 用户货币变化时流水处理
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        Task DealFlowWhenCurrencyChagne(CurrencyChangeReq req);
    }
}
