using AttendanceManagementSystem.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace AttendanceManagementSystem.Core.ViewModels
{
    public class SubjectViewModel
    {
        public IList<Subject> Subjects { get; set; }
        public Subject Subject { get; set; }
        public IEnumerable<Course> Courses { get; set; }
    }
}
