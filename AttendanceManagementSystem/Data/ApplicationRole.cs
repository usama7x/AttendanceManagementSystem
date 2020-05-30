using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AttendanceManagementSystem.Data
{
    public class ApplicationRole:IdentityRole<int>
    {
        public const string Admin = "admin"; 
    }
}
