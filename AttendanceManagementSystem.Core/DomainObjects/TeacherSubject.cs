using System;
using System.Collections.Generic;
using System.Text;

namespace AttendanceManagementSystem.Core.DomainObjects
{
    public class TeacherSubject
    {
        public int TeacherSubjectId { get; set; }
        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }
        public int SubjectId { get; set; }
        public virtual Subject Subject { get; set; }
        public DateTime Stamp { get; set; }

    }
}
