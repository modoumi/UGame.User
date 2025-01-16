using Microsoft.AspNetCore.Http.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.AspNet;
using AiUo.AspNet.Hosting;
using UGame.User.Repository;

namespace UGame.User.Common
{
    public class CorsProvider : DbCachingCorsProvider<S_operatorPO>
    {
        protected override List<CorsPolicyElement> GetPolicies(List<S_operatorPO> list)
        {
            var ret = new List<CorsPolicyElement>();
            var domainDict = new HashSet<string>();
            foreach (var policy in list)
            {
                var domains = policy.MapDomain?.Split('|', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
                if (domains == null)
                    continue;
                foreach (var domain in domains)
                {
                    if (!domainDict.Contains(domain))
                        domainDict.Add(domain);
                }
            }
            ret.Add(new CorsPolicyElement
            {
                Name = "default",
                Headers = "*",
                Methods = "*",
                Origins = string.Join(';', domainDict)
            });
            return ret;
        }

        protected override object GetSplitDbKey()
        {
            return null;
        }
    }
}
