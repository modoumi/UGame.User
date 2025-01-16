using EasyNetQ;
using Elasticsearch.Net.Specification.WatcherApi;
using Org.BouncyCastle.Ocsp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Data;
using AiUo.Extensions.RabbitMQ;
using AiUo.Text;
using UGame.User.Common.Caching;
using UGame.User.Repository;
using UGame.User.MQ.Xxyy;
using Xxyy.Common;

namespace UGame.User.Common.Services
{
    [Obsolete]
    public class CurrencyChangeService
    {
        public string UserId { get; }
        private UserService _userSvc;
        private S_currency_changeMO _changeMo = new();
        public CurrencyChangeService(string userId)
        {
            UserId = userId;
            _userSvc = new UserService(userId);
        }
        public async Task<CurrencyChangeMsg> Add(CurrencyChangeReq req)
        {
            var ret = await BuildMsg(req);
            // check
            if (req.Amount == 0)
            {
                var info = await _userSvc.GetBalanceInfo(null, true);
                ret.EndBalance = info.Balance;
                ret.EndBonus = info.Bonus;
                return ret;
            }
            var currencyType = DbCacheUtil.GetCurrencyType(req.CurrencyId);
            var oper = DbCacheUtil.GetOperator(req.OperatorId);
            if (currencyType == CurrencyType.Cash)
            {
                // 当currencyId是现金时，CurrencyChangeBalance不能是None
                if (req.ChangeBalance == CurrencyChangeBalance.None)
                    throw new Exception($"CurrencyChangeService时，当currencyId是现金时，CurrencyChangeBalance不能是None。currencyId:{req.CurrencyId}");
                if (req.Amount > 0)
                {
                    if (req.ChangeBalance != CurrencyChangeBalance.Cash && req.ChangeBalance != CurrencyChangeBalance.Bonus)
                        throw new Exception($"CurrencyChangeService时，当currencyId是现金时，Amount>0 则ChangeBalance必须是Cash或Bonus");
                    // operator未开启bonus，则使用cash
                    req.ChangeBalance = oper.EnableBonus ? req.ChangeBalance : CurrencyChangeBalance.Cash;
                }
                else
                {
                    if (oper.EnableBonus)
                    {
                        // 加减balance模式0-未定义1-优先bonus2-优先真金
                        switch (oper.ChangeBalanceMode)
                        {
                            case 1:
                                req.ChangeBalance = CurrencyChangeBalance.FirstBonus;
                                break;
                            case 2:
                                req.ChangeBalance = CurrencyChangeBalance.FirstCash;
                                break;
                        }
                    }
                    else
                    {
                        //平台不支持bonus时，账户如有bonus先扣bonus
                        if (req.ChangeBalance == CurrencyChangeBalance.Bonus)
                            req.ChangeBalance = CurrencyChangeBalance.FirstBonus;
                    }
                }
            }

            var app = DbCacheUtil.GetApp(req.AppId);
            var bonusChange = 0L;
            // bonusChange & s_user_ex
            if (currencyType == CurrencyType.Cash)
            {
                var userExSet = $"TotalChangeAmount=TotalChangeAmount+{req.Amount},TotalChangeCount=TotalChangeCount+1";
                if (req.ChangeBalance == CurrencyChangeBalance.Bonus || req.ChangeBalance == CurrencyChangeBalance.FirstBonus)
                {
                    bonusChange = req.Amount;
                    if (req.Amount < 0)
                    {
                        var userBonus = await _userSvc.GetBonus(req.TM);
                        bonusChange = (userBonus + req.Amount >= 0) ? req.Amount : -userBonus;
                    }
                }
                else if (req.ChangeBalance == CurrencyChangeBalance.FirstCash)
                {
                    if (req.Amount < 0)
                    {
                        var userBalance = await _userSvc.GetBalanceInfo(req.TM);
                        var userCash = userBalance.Balance - userBalance.Bonus;
                        bonusChange = (userCash + req.Amount >= 0) ? 0 : userCash + req.Amount;
                    }
                }

                if (bonusChange != 0)
                    userExSet += $" ,TotalBonus=TotalBonus+{bonusChange},TotalBonusCount=TotalBonusCount+1";
                if (await _userSvc.GetUserExMo().PutByPKAsync(UserId, userExSet, req.TM) != 1)
                    throw new Exception($"CurrencyChangeService：{req.Reason}，更新表s_user_ex出错");
            }

            // s_user
            var useBonus = bonusChange != 0; //req.ChangeBalance != CurrencyChangeBalance.None && req.ChangeBalance != CurrencyChangeBalance.Cash;
            var success = await _userSvc.UpdateBalance(req.CurrencyId, req.Amount, req.TM, bonusChange);
            if (!success)
                throw new CustomException(CommonCodes.RS_NOT_ENOUGH_MONEY, $"userId:{req.UserId} CurrencyType:{currencyType}");
            var balanceInfo = await _userSvc.GetBalanceInfo(req.TM, true);
            ret.EndBalance = balanceInfo.Balance;
            ret.EndBonus = balanceInfo.Bonus;
            ret.Amount = req.Amount;
            ret.Bonus = bonusChange;

            // s_currency_change
            var eo = new S_currency_changeEO
            {
                ChangeID = ObjectId.NewId(),
                ProviderID = app.ProviderID,
                AppID = req.AppId,
                OperatorID = req.OperatorId,
                UserID = req.UserId,
                FromMode = ret.FromMode,
                FromId = ret.FromId,
                UserKind = (int)ret.UserKind,
                CountryID = ret.CountryId,
                CurrencyID = req.CurrencyId,
                CurrencyType = (int)currencyType,
                IsBonus = useBonus, //TODO 已失效
                FlowMultip = req.FlowMultip,
                Reason = req.Reason,
                PlanAmount = req.Amount,
                Meta = SerializerUtil.SerializeJsonNet(req.Meta),
                SourceType = req.SourceType,
                SourceTable = req.SourceTable,
                SourceId = req.SourceId,
                UserIp = req.UserIp,
                Status = (int)OrderStatus.Success,
                RecDate = req.ChangeTime,
                DealTime = req.ChangeTime,
                Amount = req.Amount,
                EndBalance = ret.EndBalance,
                AmountBonus = ret.Bonus,
                EndBonus = ret.EndBonus,
            };
            if (await _changeMo.AddAsync(eo, req.TM) != 1)
                throw new Exception($"CurrencyChangeService：{req.Reason}，写入流水表s_currency_change出错");
            //// s_requireflow_order
            //if (currencyType == CurrencyType.Cash && req.Amount > 0 && req.FlowMultip > 0)
            //{
            //    var orderEo = new S_requireflow_orderEO
            //    {
            //        OrderID = ObjectId.NewId(),
            //        ProviderID = app.ProviderID,
            //        AppID = app.AppID,
            //        OperatorID = req.OperatorId,
            //        UserID = req.UserId,
            //        FromMode = ret.FromMode,
            //        FromId = ret.FromId,
            //        UserKind = (int)ret.UserKind,
            //        CountryID = ret.CountryId,
            //        CurrencyID = req.CurrencyId,
            //        CurrencyType = (int)currencyType,

            //        IsBonus = useBonus,
            //        BonusReason = req.Reason,
            //        BonusSourceType = req.SourceType,
            //        SourceId = req.SourceId,
            //        SourceTable = req.SourceTable,
            //        FlowMultip = req.FlowMultip,
            //        OrderAmount = req.Amount,
            //        OrderRemain = req.Amount,
            //        RequireFlow = (long)(req.Amount * (decimal)req.FlowMultip),

            //        EndBonus = ret.EndBonus,
            //        EndBalance = ret.EndBalance,
            //        Status = req.FlowMultip > 0 ? 0 : 1,
            //        RecDate = req.ChangeTime,
            //        EndBonusList = useBonus ? $"+{req.Amount}" : string.Empty,
            //        UpdateTime = req.ChangeTime,
            //    };
            //    if (await DbSink.BuildRequireFlowOrderMo(req.UserId).AddAsync(orderEo, req.TM) < 0)
            //        throw new Exception($"CurrencyChangeService：{req.Reason}，领取bonus时，写入流水表s_requireflow_order出错");
            //}

            return ret;
        }

        /// <summary>
        /// 目前新版货币算法提现时用
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        /// <exception cref="CustomException"></exception>
        public async Task<CurrencyChangeMsg> Change(CurrencyChangeReq req)
        {
            var ret = await BuildMsg(req);
            // check
            if (req.Amount == 0)
            {
                var info = await _userSvc.GetBalanceInfo(null, true);
                ret.EndBalance = info.Balance;
                ret.EndBonus = info.Bonus;
                return ret;
            }
            var currencyType = DbCacheUtil.GetCurrencyType(req.CurrencyId);
            
            var app = DbCacheUtil.GetApp(req.AppId);
            var bonusChange = req.BonusAmount;
            // bonusChange & s_user_ex
            if (currencyType == CurrencyType.Cash)
            {
                var userExSet = $"TotalChangeAmount=TotalChangeAmount+{req.Amount},TotalChangeCount=TotalChangeCount+1";
                
                if (bonusChange != 0)
                    userExSet += $" ,TotalBonus=TotalBonus+{bonusChange},TotalBonusCount=TotalBonusCount+1";
                if (await _userSvc.GetUserExMo().PutByPKAsync(UserId, userExSet, req.TM) != 1)
                    throw new Exception($"CurrencyChangeService：{req.Reason}，更新表s_user_ex出错");
            }

            // s_user
            var useBonus = bonusChange != 0; //req.ChangeBalance != CurrencyChangeBalance.None && req.ChangeBalance != CurrencyChangeBalance.Cash;
            var success = await _userSvc.UpdateBalance(req.CurrencyId, req.Amount, req.TM, bonusChange);
            if (!success)
                throw new CustomException(CommonCodes.RS_NOT_ENOUGH_MONEY, $"userId:{req.UserId} CurrencyType:{currencyType}");
            var balanceInfo = await _userSvc.GetBalanceInfo(req.TM, true);
            ret.EndBalance = balanceInfo.Balance;
            ret.EndBonus = balanceInfo.Bonus;
            ret.Amount = req.Amount;
            ret.Bonus = bonusChange;

            // s_currency_change
            var eo = new S_currency_changeEO
            {
                ChangeID = ObjectId.NewId(),
                ProviderID = app.ProviderID,
                AppID = req.AppId,
                OperatorID = req.OperatorId,
                UserID = req.UserId,
                FromMode = ret.FromMode,
                FromId = ret.FromId,
                UserKind = (int)ret.UserKind,
                CountryID = ret.CountryId,
                CurrencyID = req.CurrencyId,
                CurrencyType = (int)currencyType,
                IsBonus = useBonus, //TODO 已失效
                FlowMultip = req.FlowMultip,
                Reason = req.Reason,
                PlanAmount = req.Amount,
                Meta = SerializerUtil.SerializeJsonNet(req.Meta),
                SourceType = req.SourceType,
                SourceTable = req.SourceTable,
                SourceId = req.SourceId,
                UserIp = req.UserIp,
                Status = (int)OrderStatus.Success,
                RecDate = req.ChangeTime,
                DealTime = req.ChangeTime,
                Amount = req.Amount,
                EndBalance = ret.EndBalance,
                AmountBonus = ret.Bonus,
                EndBonus = ret.EndBonus,
            };
            if (await _changeMo.AddAsync(eo, req.TM) != 1)
                throw new Exception($"CurrencyChangeService：{req.Reason}，写入流水表s_currency_change出错");

            return ret;
        }

        private async Task<CurrencyChangeMsg> BuildMsg(CurrencyChangeReq req)
        {
            var userDCache = await GlobalUserDCache.Create(UserId);
            return new CurrencyChangeMsg
            {
                UserId = req.UserId,
                UserKind = await userDCache.GetUserKindAsync(),
                AppId = req.AppId,
                OperatorId = req.OperatorId,
                CountryId = await userDCache.GetCountryIdAsync(),
                CurrencyId = req.CurrencyId,
                FlowMultip = req.FlowMultip,
                CurrencyType = DbCacheUtil.GetCurrencyType(req.CurrencyId),
                ChangeTime = req.ChangeTime,
                SourceType = req.SourceType,
                SourceId= req.SourceId,
                SourceTable= req.SourceTable,
                Reason = req.Reason,
                Amount = req.Amount,
                FromMode = await userDCache.GetFromModeAsync(),
                FromId = await userDCache.GetFromIdAsync(),
                Bonus = 0,
                EndBalance = 0,
                EndBonus = 0
            };
        }
    }
}
