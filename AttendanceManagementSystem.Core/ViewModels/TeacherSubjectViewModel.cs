using AttendanceManagementSystem.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace AttendanceManagementSystem.Core.ViewModels
{
    public class TeacherSubjectViewModel
    {       
        public string Teacher { get; set; }
        public string Course { get; set; }
        public int Year { get; set; }
        public int Semester { get; set; }
        public string Subject { get; set; }
        public TeacherSubject TeacherSubject { get; set; }
        public IEnumerable<Teacher> Teachers { get; set; }
    }
}
