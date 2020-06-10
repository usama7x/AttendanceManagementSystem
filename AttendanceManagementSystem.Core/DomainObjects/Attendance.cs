using System;
using System.Collections.Generic;
using System.Text;

namespace AttendanceManagementSystem.Core.DomainObjects
{
    public class Attendance
    {
        public int AttendanceId { get; set; }
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
        public int SubjectId { get; set; }
        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual Subject Subject { get; set; }
        public DateTime Stamp { get; set; }
        public bool IsAbsent { get; set; }
        public string Reason { get; set; }
    }
}
