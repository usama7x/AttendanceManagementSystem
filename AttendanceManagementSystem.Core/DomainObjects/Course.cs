using System;
using System.Collections.Generic;
using System.Text;

namespace AttendanceManagementSystem.Core.DomainObjects
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<CourseSubject> CourseSubjects { get; set; }

    }
}
