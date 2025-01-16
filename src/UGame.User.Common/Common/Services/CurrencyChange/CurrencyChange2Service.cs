using Google.Protobuf.WellKnownTypes;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Data.SqlSugar;
using AiUo.Text;
using UGame.User.Common.Caching;
using UGame.User.Repository;
using UGame.User.MQ.Xxyy;
using Xxyy.Common;

namespace UGame.User.Common.Services
{
    public class CurrencyChange2Service
    {
        public string UserId { get; set; }
        private User2Service _userSvc;
        public CurrencyChange2Service(string userId)
        {
            UserId = userId;
            _userSvc = new User2Service(userId);
        }
        public async Task<CurrencyChangeMsg> Add(CurrencyChangeReq req)
        {
            var ret = await BuildMsg(req);
            if (req.Amount == 0)
            {
                var info = await _userSvc.GetBalanceInfo(true);
                ret.EndBalance = info.Balance;
                ret.EndBonus = info.Bonus;
                ret.EndCoin = info.Coin;
                return ret;
            }
            if (ret.CurrencyType == CurrencyType.Coin)
            {
                return await AddCoin(req, ret);
            }
            else
                return await AddBalance(req, ret);
        }

        public async Task<CurrencyChangeMsg> AddCoin(CurrencyChangeReq req, CurrencyChangeMsg ret)
        {
            if (req.ChangeBalance != CurrencyChangeBalance.None)
                throw new Exception("CurrencyChange2Service.Add时，参数CurrencyChangeReq的CurrencyId是coin则ChangeBalance必须是None");
            
            var app = DbCacheUtil.GetApp(req.AppId);
            // s_user
            var success = await _userSvc.UpdateCoin(ret.Coin, req.DbTM);
            if (!success)
                throw new CustomException(CommonCodes.RS_NOT_ENOUGH_MONEY, $"userId:{req.UserId} CurrencyType:{ret.CurrencyType}");
            
            // s_currency_change
            var eo = new S_currency_changePO
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
                CurrencyType = (int)ret.CurrencyType,
                IsBonus = false, //TODO 已失效
                FlowMultip = req.FlowMultip,
                Reason = req.Reason,
                PlanAmount = 0,
                Meta = SerializerUtil.SerializeJsonNet(req.Meta),
                SourceType = req.SourceType,
                SourceTable = req.SourceTable,
                SourceId = req.SourceId,
                UserIp = req.UserIp,
                Status = (int)OrderStatus.Success,
                RecDate = req.ChangeTime,
                DealTime = req.ChangeTime,
                Amount = 0,
                EndBalance = ret.EndBalance,
                AmountBonus = 0,
                EndBonus = ret.EndBonus,
                AmountCoin = ret.Coin,
                EndCoin = ret.EndCoin
            };
            if (!await GetRepository<S_currency_changePO>(req.DbTM).InsertAsync(eo))
                throw new Exception($"CurrencyChangeService：{req.Reason}，写入表s_currency_change出错");
            return ret;
        }
        public async Task<CurrencyChangeMsg> AddBalance(CurrencyChangeReq req, CurrencyChangeMsg ret)
        {
            var oper = DbCacheUtil.GetOperator(req.OperatorId);
            if (ret.CurrencyType == CurrencyType.Cash)
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
            if (ret.CurrencyType == CurrencyType.Cash)
            {
                var useExClient = GetDb<S_user_exPO>(req.DbTM).Updateable<S_user_exPO>();
                useExClient.SetColumns(it => it.TotalChangeAmount == it.TotalChangeAmount + req.Amount);
                useExClient.SetColumns(it => it.TotalChangeCount == it.TotalChangeCount + 1);
                if (req.ChangeBalance == CurrencyChangeBalance.Bonus || req.ChangeBalance == CurrencyChangeBalance.FirstBonus)
                {
                    bonusChange = req.Amount;
                    if (req.Amount < 0)
                    {
                        var userBonus = await _userSvc.GetBonus();
                        bonusChange = (userBonus + req.Amount >= 0) ? req.Amount : -userBonus;
                    }
                }
                else if (req.ChangeBalance == CurrencyChangeBalance.FirstCash)
                {
                    if (req.Amount < 0)
                    {
                        var userBalance = await _userSvc.GetBalanceInfo();
                        var userCash = userBalance.Balance - userBalance.Bonus;
                        bonusChange = (userCash + req.Amount >= 0) ? 0 : userCash + req.Amount;
                    }
                }

                if (bonusChange != 0)
                {
                    useExClient.SetColumns(it => it.TotalBonus == it.TotalBonus + bonusChange);
                    useExClient.SetColumns(it => it.TotalBonusCount == it.TotalBonusCount + 1);
                }
                if (await useExClient.Where(it => it.UserID == UserId).ExecuteCommandAsync() != 1)
                    throw new Exception($"CurrencyChangeService：{req.Reason}，更新表s_user_ex出错");
            }

            // s_user
            var useBonus = bonusChange != 0;//req.ChangeBalance != CurrencyChangeBalance.None && req.ChangeBalance != CurrencyChangeBalance.Cash;
            var success = await _userSvc.UpdateBalance(req.CurrencyId, req.Amount, bonusChange, req.DbTM);
            if (!success)
                throw new CustomException(CommonCodes.RS_NOT_ENOUGH_MONEY, $"userId:{req.UserId} CurrencyType:{ret.CurrencyType}");
            var balanceInfo = await _userSvc.GetBalanceInfo(true,req.DbTM);
            ret.EndBalance = balanceInfo.Balance;
            ret.EndBonus = balanceInfo.Bonus;
            ret.Amount = req.Amount;
            ret.Bonus = bonusChange;

            // s_currency_change
            var eo = new S_currency_changePO
            {
                ChangeID = ObjectId.NewId(),
                ProviderID = app.ProviderID,
                AppID = req.AppId,
                OperatorID = req.OperatorId,
                UserID = req.UserId,
                FromMode = ret.FromMode,
                FromId = ret.FromId,
                DomainID = ret.DomainId,
                UserKind = (int)ret.UserKind,
                CountryID = ret.CountryId,
                CurrencyID = req.CurrencyId,
                CurrencyType = (int)ret.CurrencyType,
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
            if (!await GetRepository<S_currency_changePO>(req.DbTM).InsertAsync(eo))
                throw new Exception($"CurrencyChangeService：{req.Reason}，写入表s_currency_change出错");
            //// s_requireflow_order
            //if (ret.CurrencyType == CurrencyType.Cash && req.Amount > 0 && req.FlowMultip > 0)
            //{
            //    var orderEo = new S_requireflow_orderPO
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
            //        CurrencyType = (int)ret.CurrencyType,

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
            //    if (!await GetRepository<S_requireflow_orderPO>(req.DbTM).InsertAsync(orderEo))
            //        throw new Exception($"CurrencyChangeService：{req.Reason}，领取bonus时，写入流水表s_requireflow_order出错");
            //}

            return ret;
        }

        private async Task<CurrencyChangeMsg> BuildMsg(CurrencyChangeReq req)
        {
            var userDCache = await GlobalUserDCache.Create(UserId);
            var ret = new CurrencyChangeMsg
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
                SourceId = req.SourceId,
                SourceTable = req.SourceTable,
                Reason = req.Reason,
                FromMode = await userDCache.GetFromModeAsync(),
                FromId = await userDCache.GetFromIdAsync(),
                DomainId = await userDCache.GetDomainIdAsync(),
                Amount = 0,
                EndBalance = 0,
                Bonus = 0,
                EndBonus = 0,
                Coin = 0,
                EndCoin = 0,
            };
            if (ret.CurrencyType == CurrencyType.Coin)
                ret.Coin = req.Amount;
            else
                ret.Amount = req.Amount;
            return ret;
        }

        private ISqlSugarClient GetDb<T>(DbTransactionManager tm)
        {
            return tm != null
                ? tm.GetDb<T>()
                : DbUtil.GetDb<T>();
        }
        private Repository<T> GetRepository<T>(DbTransactionManager tm)
            where T : class, new()
        {
            return tm != null
                ? tm.GetRepository<T>()
                : DbUtil.GetRepository<T>();
        }
    }
}
