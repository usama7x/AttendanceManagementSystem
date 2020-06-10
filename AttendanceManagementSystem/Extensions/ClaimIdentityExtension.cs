using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
namespace AttendanceManagementSystem.Extensions
{
    public static class ClaimIdentityExtension
    {
        public static int GetUserId(this ClaimsPrincipal principal)
        {
            if (principal is null)
                throw new ArgumentNullException(nameof(principal));
            var value = principal.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            return int.Parse(value);
        } 
    }
}
