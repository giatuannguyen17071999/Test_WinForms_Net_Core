using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace QL_Vat_Lieu_Xay_Dung_WebApp.Extensions
{
    public static class IdentityExtensions
    {
        public static string GetSpecificClaim(this ClaimsPrincipal claimsIdentity, string key_claimsIdentity)
        {
            var claim = claimsIdentity.Claims.FirstOrDefault(x => x.Type == key_claimsIdentity);
            return claim != null ? claim.Value : string.Empty;
        }
    }
}
