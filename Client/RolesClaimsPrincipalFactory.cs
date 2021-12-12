using System.Linq;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication.Internal;

namespace OpenAir.Client
{
    public class RolesClaimsPrincipalFactory
        : AccountClaimsPrincipalFactory<RemoteUserAccount>
    {
        public RolesClaimsPrincipalFactory(IAccessTokenProviderAccessor accessor)
            : base(accessor)
        {
        }




        public async override ValueTask<ClaimsPrincipal> CreateUserAsync(
        RemoteUserAccount account,
        RemoteAuthenticationUserOptions options)
        {
            var user = await base.CreateUserAsync(account, options);
            var claimsIdentity = (ClaimsIdentity)user.Identity;
            if (account != null)
            {
                MapArrayClaimsToMultipleSeparateClaims(account, claimsIdentity);
            }
            return user;
        }
        private void MapArrayClaimsToMultipleSeparateClaims(RemoteUserAccount account, ClaimsIdentity claimsIdentity)
        {
            foreach (var prop in account.AdditionalProperties)
            {
                var key = prop.Key;
                var value = prop.Value;
                if (value != null &&
                    (value is JsonElement element && element.ValueKind == JsonValueKind.Array))
                {
                    claimsIdentity.RemoveClaim(claimsIdentity.FindFirst(prop.Key));
                    var claims = element.EnumerateArray()
                        .Select(x => new Claim(prop.Key, x.ToString()));
                    claimsIdentity.AddClaims(claims);
                }
            }






            //public override async ValueTask<ClaimsPrincipal> CreateUserAsync(
            //    RemoteUserAccount account,
            //    RemoteAuthenticationUserOptions options)
            //{
            //    var user = await base.CreateUserAsync(account, options);

            //    if (user.Identity.IsAuthenticated)
            //    {
            //        var identity = (ClaimsIdentity)user.Identity;
            //        var roleClaims = identity.FindAll(identity.RoleClaimType).ToArray();

            //        if (roleClaims.Any())
            //        {
            //            foreach (var existingClaim in roleClaims)
            //            {
            //                identity.RemoveClaim(existingClaim);
            //            }

            //            var rolesElem = account.AdditionalProperties[identity.RoleClaimType];

            //            if (rolesElem is JsonElement roles)
            //            {
            //                if (roles.ValueKind == JsonValueKind.Array)
            //                {
            //                    foreach (var role in roles.EnumerateArray())
            //                    {
            //                        identity.AddClaim(new Claim(options.RoleClaim, role.GetString()));
            //                    }
            //                }
            //                else
            //                {
            //                    identity.AddClaim(new Claim(options.RoleClaim, roles.GetString()));
            //                }
            //            }
            //        }
            //    }

            //    return user;
            }
        }
}
