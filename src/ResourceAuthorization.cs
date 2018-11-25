using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace Schematic.Core
{
    public static class ResourceAuthorization
    {
        public static bool IsAuthorized(this ClaimsPrincipal user, Type type)
        {
            string requiredRole = type.GetAttributeValue((SchematicAuthorizeAttribute a) => a.Role);

            ClaimsIdentity ClaimsIdentity = user.Identity as ClaimsIdentity;
            List<Claim> roles = ClaimsIdentity.FindAll(ClaimTypes.Role).ToList();

            foreach (Claim role in roles)
            {
                if (role.Value == requiredRole)
                {
                    return true;
                }
            }

            return false;
        }
    }
}