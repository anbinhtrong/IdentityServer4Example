using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4;
using IdentityServer4.Models;

namespace IdentityServer4Example.Configuration
{
    public class Scopes
    {
        public static IEnumerable<Scope> Get()
        {
            return new List<Scope>
            {
                //IdentityServerConstants.StandardScopes.OpenId,
                //IdentityServerConstants.StandardScopes.Profile,
                new Scope
                {
                    Name = "api1",
                    DisplayName = "API 1",
                    Description = "API 1 features and data"//,
                    //Type = ScopeType.Resource
                }
            };
        }
    }
}
