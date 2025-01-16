using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.User.Repository
{
    public partial class S_currencyPO
    {
        #region AiUo
        public static implicit operator S_currencyEO(S_currencyPO value)
        {
            if (value==null) return null;
            return new S_currencyEO
            {
		        CurrencyID = value.CurrencyID,
		        CurrencyCode = value.CurrencyCode,
		        BaseUnit = value.BaseUnit,
		        Name = value.Name,
		        CurrencyType = value.CurrencyType,
		        Status = value.Status,
            };
        }
        public static implicit operator S_currencyPO(S_currencyEO value)
        {
            if (value==null) return null;
            return new S_currencyPO
            {
		        CurrencyID = value.CurrencyID,
		        CurrencyCode = value.CurrencyCode,
		        BaseUnit = value.BaseUnit,
		        Name = value.Name,
		        CurrencyType = value.CurrencyType,
		        Status = value.Status,
            };
        }
        #endregion
    }
}