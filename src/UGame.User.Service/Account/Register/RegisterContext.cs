using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.AspNet;
using AiUo.Text;
using UGame.User.Service.Common;
using UGame.User.Common;
using UGame.User.Common.Caching; 
using UGame.User.Repository;

namespace UGame.User.Service.Account.Register
{
    internal class RegisterContext
    {
        public RegisterIpo Ipo { get; }
        public V_s_operatorEO OperatorEo { get; }
        public S_appEO AppEo { get; }
        public S_countryEO CountryEo { get; }
        public DateTime CurrentUtcTime { get; }
        public string UserIp { get; }

        public S_userEO PUserEo { get; set; }
        public RegisterContext(RegisterIpo ipo)
        {
            Ipo = ipo;
            OperatorEo = DbCacheUtil.GetOperator(Ipo.OperatorId);
            AppEo = DbCacheUtil.GetApp(Ipo.AppId);
            CountryEo = DbCacheUtil.GetCountry(OperatorEo.CountryID);
            CurrentUtcTime = DateTime.UtcNow;
            UserIp = AspNetUtil.GetRemoteIpString();
        }
    }
}
