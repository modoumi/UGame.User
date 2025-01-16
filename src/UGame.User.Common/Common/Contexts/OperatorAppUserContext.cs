using Elasticsearch.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UGame.User.Common.Caching;
using UGame.User.Common;
using UGame.User.Repository;

namespace UGame.User.Common.Contexts
{
    public class OperatorAppUserContext : AppUserContext
    {
        public string OperatorId { get; }
        public V_s_operatorEO OperatorEo { get; }
        public OperatorType OperatorType => (OperatorType)OperatorEo.OperatorType;
        public bool IsOwnOperator => OperatorType == OperatorType.Own;
        public string OperatorPublicKey => OperatorEo.OperPublicKey;

        public string CountryId => OperatorEo.CountryID;
        public S_countryEO CountryEo { get; }

        public string OperatorCurrencyId => OperatorEo.CurrencyID;
        public S_currencyEO OperatorCurrencyEo { get; }

        public S_operator_appEO OperatorAppEo { get; }
        public string OperatorAppId => OperatorAppEo.OperatorAppId;
        public bool UseBonus => OperatorAppEo.UseBonus;

        public OperatorAppUserContext(string operatorId, string appId, string userId) : base(appId, userId)
        {
            //if (string.IsNullOrEmpty(appId))
            //    throw new Exception("OperatorAppUserContext: operatorId不能为空");
            OperatorId = operatorId;
            OperatorEo = DbCacheUtil.GetOperator(operatorId, true, CommonCodes.RS_INVALID_OPERATOR);
            CountryEo = DbCacheUtil.GetCountry(CountryId);
            OperatorCurrencyEo = DbCacheUtil.GetCurrency(OperatorCurrencyId);
            OperatorAppEo = DbCacheUtil.GetOperatorApp(operatorId, appId, true, CommonCodes.RS_INVALID_OPERATOR);
        }
    }
}
