using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Linq;

namespace AttendanceManagementSystem.Core.ViewModels
{
    public class StudentAttendanceViewModel
    {
        public int Id { get; set; }       
        public string Name { get; set; }
        [Display(Name = "Roll No")]
        public int RollNo { get; set; }
        [Display(Name = "Status")]
        public bool IsAbsent { get; set; }
        public string Reason { get; set; }
        [Display(Name = "Date")]
        public DateTime Stamp { get; set; }
        [Display(Name = "Total Absents")]
        public int TotalAbsents { get; set; }        
    }
}
