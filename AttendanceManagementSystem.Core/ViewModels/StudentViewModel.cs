using AttendanceManagementSystem.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace AttendanceManagementSystem.Core.ViewModels
{
    public class StudentViewModel
    {
        public int StudentId { get; set; }
        public int RollNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime Dob { get; set; }
        public string City { get; set; }
        public char Gender { get; set; }
        public string Course { get; set; }
        public int Semester { get; set; }
        public DateTime Stamp { get; set; }


    }
}
