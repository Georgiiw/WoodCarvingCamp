using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using static WoodCarvingCamp.Common.AdminUserValidations.AdminValidations;

namespace WoodCarvingCamp.Web.Infrastructure.Extensions
{
    public static class ClaimsPrincipalExtansions
    {
        public static bool IsAdmin(this ClaimsPrincipal user)
        {
            return user.IsInRole(AdminRoleName);
        }
        public static string? GetId(this ClaimsPrincipal user)
        {
            return user.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
