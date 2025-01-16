using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.User.Repository
{
    public partial class S_operator_basePO
    {
        #region AiUo
        public static implicit operator S_operator_baseEO(S_operator_basePO value)
        {
            if (value==null) return null;
            return new S_operator_baseEO
            {
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
		        Note = value.Note,
		        SettlDayNum = value.SettlDayNum,
		        Status = value.Status,
		        RecDate = value.RecDate,
		        OperAdminUrl = value.OperAdminUrl,
		        OperAdminUser = value.OperAdminUser,
		        OperAdminPwd = value.OperAdminPwd,
		        CashAudit = value.CashAudit,
		        LowestCashAmount = value.LowestCashAmount,
            };
        }
        public static implicit operator S_operator_basePO(S_operator_baseEO value)
        {
            if (value==null) return null;
            return new S_operator_basePO
            {
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
		        Note = value.Note,
		        SettlDayNum = value.SettlDayNum,
		        Status = value.Status,
		        RecDate = value.RecDate,
		        OperAdminUrl = value.OperAdminUrl,
		        OperAdminUser = value.OperAdminUser,
		        OperAdminPwd = value.OperAdminPwd,
		        CashAudit = value.CashAudit,
		        LowestCashAmount = value.LowestCashAmount,
            };
        }
        #endregion
    }
}