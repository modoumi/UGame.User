using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.User.Repository
{
    public partial class S_countryPO
    {
        #region AiUo
        public static implicit operator S_countryEO(S_countryPO value)
        {
            if (value==null) return null;
            return new S_countryEO
            {
		        CountryID = value.CountryID,
		        CountryID2 = value.CountryID2,
		        CountryCode = value.CountryCode,
		        CurrencyID = value.CurrencyID,
		        CallingCode = value.CallingCode,
		        Name = value.Name,
		        EnName = value.EnName,
		        LangName = value.LangName,
		        TimeZone = value.TimeZone,
		        Status = value.Status,
            };
        }
        public static implicit operator S_countryPO(S_countryEO value)
        {
            if (value==null) return null;
            return new S_countryPO
            {
		        CountryID = value.CountryID,
		        CountryID2 = value.CountryID2,
		        CountryCode = value.CountryCode,
		        CurrencyID = value.CurrencyID,
		        CallingCode = value.CallingCode,
		        Name = value.Name,
		        EnName = value.EnName,
		        LangName = value.LangName,
		        TimeZone = value.TimeZone,
		        Status = value.Status,
            };
        }
        #endregion
    }
}