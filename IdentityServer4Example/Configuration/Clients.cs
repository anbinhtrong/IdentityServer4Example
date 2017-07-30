using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4.Models;
using static IdentityServer4.IdentityServerConstants;

namespace IdentityServer4Example.Configuration
{
    public class Clients
    {
        public static List<Client> Get()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientName = "Resource owner Client",
                    ClientId = "roclient",
                    ClientSecrets = new List<Secret>
                    {
                        new Secret("madeupsecret".Sha256())
                    },

                    AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,

                    AllowedScopes = new List<string>
                    {
                        "customAPI.read"
                    }
                }
            };
        }
    }
}
