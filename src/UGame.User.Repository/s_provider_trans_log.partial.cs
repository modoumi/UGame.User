using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.User.Repository
{
    public partial class S_provider_trans_logPO
    {
        #region AiUo
        public static implicit operator S_provider_trans_logEO(S_provider_trans_logPO value)
        {
            if (value==null) return null;
            return new S_provider_trans_logEO
            {
		        TransLogID = value.TransLogID,
		        OrderID = value.OrderID,
		        ProviderID = value.ProviderID,
		        OperatorID = value.OperatorID,
		        TransType = value.TransType,
		        TransMark = value.TransMark,
		        RequestTime = value.RequestTime,
		        RequestBody = value.RequestBody,
		        Status = value.Status,
		        RecDate = value.RecDate,
		        ResponseTime = value.ResponseTime,
		        ResponseBody = value.ResponseBody,
		        Exception = value.Exception,
            };
        }
        public static implicit operator S_provider_trans_logPO(S_provider_trans_logEO value)
        {
            if (value==null) return null;
            return new S_provider_trans_logPO
            {
		        TransLogID = value.TransLogID,
		        OrderID = value.OrderID,
		        ProviderID = value.ProviderID,
		        OperatorID = value.OperatorID,
		        TransType = value.TransType,
		        TransMark = value.TransMark,
		        RequestTime = value.RequestTime,
		        RequestBody = value.RequestBody,
		        Status = value.Status,
		        RecDate = value.RecDate,
		        ResponseTime = value.ResponseTime,
		        ResponseBody = value.ResponseBody,
		        Exception = value.Exception,
            };
        }
        #endregion
    }
}