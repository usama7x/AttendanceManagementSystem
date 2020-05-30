using AttendanceManagementSystem.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace AttendanceManagementSystem.Core.ViewModels
{
    public class AllocateSubjectViewModel
    {
       public List<TeacherSubjectViewModel> TeacherSubjects { get; set; }
        public TeacherSubject TeacherSubject { get; set; }
        public IEnumerable<Teacher> Teachers { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Subject> Subjects { get; set; }
        public int Year { get; set; }
        public int Semester { get; set; }
    }
}
