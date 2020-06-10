using System;
using System.Collections.Generic;
using System.Text;

namespace AttendanceManagementSystem.Core.DomainObjects
{
    public class StudentSubject
    {
        public int StudentSubjectId { get; set; }
        public int SubjectId { get; set; }
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
