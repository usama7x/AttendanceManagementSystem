using AttendanceManagementSystem.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace AttendanceManagementSystem.Core.ViewModels
{
    public class AttendanceViewModel
    {
        public ICollection<Subject> Subjects { get; set; }
       
        public StudentAttendanceViewModel[] Students { get; set; }
        public StudentAttendanceViewModel Student { get; set; }
        public IList<StudentAttendanceViewModel> Attendances { get; set; }
        public int SubjectId { get; set; }

    }
}
