using System;
using System.Collections.Generic;
using System.Text;
using AiUo.Data.MySql;
using UGame.User.Repository;

namespace UGame.User.Common
{
    public static class DbSink
    {
        private static MySqlDatabase _mainDb;
        public static MySqlDatabase MainDb
        {
            get
            {
                if (_mainDb == null)
                    _mainDb = new MySqlDatabase();
                return _mainDb;
            }
        }

        private static MySqlDatabase _gameDb;
        public static MySqlDatabase GameDb
        {
            get
            {
                if (_gameDb == null)
                {
                    var section = ConfigUtil.GetSection<DataSection>();
                    if (section == null || section.ConnectionStrings == null
                        || !section.ConnectionStrings.TryGetValue("game", out var _))
                        throw new Exception("配置文件中数据库连接名game不存在！");
                    _gameDb = new MySqlDatabase("game");
                }
                return _gameDb;
            }
        }

        #region S_userMO
        public static S_userMO BuildUserMo(string userId)
        {
            return new S_userMO();
        }
        public static List<S_userMO> GetUserMoList()
        {
            return new List<S_userMO>() { new S_userMO() };
        }
        #endregion

        #region S_user_exMO
        public static S_user_exMO BuildUserExMo(string userId)
        {
            return new S_user_exMO();
        }
        public static List<S_user_exMO> GetUserExMoList()
        {
            return new List<S_user_exMO> { new S_user_exMO() };
        }
        #endregion

        #region S_user_appMO
        public static S_user_appMO BuildUserAppMo(string userId)
        {
            return new S_user_appMO();
        }
        public static List<S_user_appMO> GetUserAppMoList()
        {
            return new List<S_user_appMO> { new S_user_appMO() };
        }
        #endregion

        #region S_requireflow_orderMO
        public static S_requireflow_orderMO BuildRequireFlowOrderMo(string userId)
        {
            return new S_requireflow_orderMO();
        }
        public static List<S_requireflow_orderMO> GetRequireFlowOrderList()
        {
            return new List<S_requireflow_orderMO> { new S_requireflow_orderMO() };
        }
        #endregion

        #region S_user_promoterMO
        public static S_user_promoterMO BuildUserPromoterMo(string pUserId)
        {
            return new S_user_promoterMO();
        }
        public static List<S_user_promoterMO> GetUserPromoterMoList()
        {
            return new List<S_user_promoterMO> { new S_user_promoterMO() };
        }
        #endregion
    }
}
