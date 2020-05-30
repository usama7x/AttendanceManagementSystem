using System;
using System.Collections.Generic;
using System.Text;

namespace AttendanceManagementSystem.Core.DomainObjects
{
    public class CourseSubject
    {
        public int CourseSubjectId { get; set; }
        public int SubjectId { get; set; }
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
