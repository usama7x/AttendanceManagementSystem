using AttendanceManagementSystem.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace AttendanceManagementSystem.Core.ViewModels
{
    public class TeacherViewModel
    {
        public IList<Teacher> Teachers { get; set; }
        public Teacher Teacher { get; set; }
    }
}
