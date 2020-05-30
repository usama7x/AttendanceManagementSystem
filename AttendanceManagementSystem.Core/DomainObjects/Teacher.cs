using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;


namespace AttendanceManagementSystem.Core.DomainObjects
{
    public class Teacher: IdentityUser<int>
    {
        public int TeacherId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNo { get; set; }       
        public string Password { get; set; }
        public string Address1 { get; set; }        
        public string Address2 { get; set; }
        public string City { get; set; }
        public DateTime Stamp { get; set; }
        [DisplayName("Name")]
        public string FullName => FirstName + " " + LastName;
        public virtual ICollection<TeacherSubject> Subjects { get; set; }

    }
}
