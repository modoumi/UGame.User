using EasyNetQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UGame.User.Common.Caching;

namespace UGame.User.Service.Flow
{
    public class FlowServiceFactory
    {
        public static IFlowDealService CreateFlowService(string userId, string appId, string operatorId)
        {
            var operatorInfo = DbCacheUtil.GetOperator(operatorId);
            return operatorInfo.FlowMode switch
            {
                1 => new FlowInheritingNoCompletedService(userId, appId, operatorId),
                3 => new FlowNoInheritingNoCompletedService(userId, appId, operatorId),
                _ => new FlowInheritingBalanceService(userId, appId, operatorId),
            };
        }
    }
}
