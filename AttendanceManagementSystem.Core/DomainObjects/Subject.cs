using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AttendanceManagementSystem.Core.DomainObjects
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
        [DisplayName("Course Name")]
        public string CourseName{ get; set; }
        [DisplayName("Subject Name")]
        public string Name { get; set; }

        public int Year { get; set; }
        public int Semester { get; set; }
        public DateTime Stamp { get; set; }
        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual ICollection<TeacherSubject> TeacherSubjects { get; set; }
        public virtual ICollection<CourseSubject> CourseSubjects { get; set; }
    }
}
