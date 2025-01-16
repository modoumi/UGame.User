using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.User.Repository
{
    public partial class S_user_appPO
    {
        #region AiUo
        public static implicit operator S_user_appEO(S_user_appPO value)
        {
            if (value==null) return null;
            return new S_user_appEO
            {
		        UserID = value.UserID,
		        AppID = value.AppID,
		        LastLoginDate = value.LastLoginDate,
		        Status = value.Status,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator S_user_appPO(S_user_appEO value)
        {
            if (value==null) return null;
            return new S_user_appPO
            {
		        UserID = value.UserID,
		        AppID = value.AppID,
		        LastLoginDate = value.LastLoginDate,
		        Status = value.Status,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}