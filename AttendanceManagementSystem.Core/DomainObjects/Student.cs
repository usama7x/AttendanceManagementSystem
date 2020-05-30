using System;
using System.Collections.Generic;
using System.Text;

namespace AttendanceManagementSystem.Core.DomainObjects
{
    public class Student
    {
        public int StudentId { get; set; }
        public int RollNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public DateTime Dob { get; set; }
        public char Gender { get; set; }
        public string Address { get; set; }        
        public string City { get; set; }
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
        public int Year { get; set; }
        public int Semester { get; set; }
        public DateTime Stamp { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Attendance> Attendances { get; set; }



    }
}

