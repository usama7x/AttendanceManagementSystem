using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AttendanceManagementSystem.Core.DomainObjects;
using AttendanceManagementSystem.Core.ViewModels;
using AttendanceManagementSystem.Data;
using AttendanceManagementSystem.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace AttendanceManagementSystem.Controllers
{
    public class AttendanceHistoryController : Controller
    {
        readonly ApplicationContext context;
        public AttendanceHistoryController(ApplicationContext context)
        {
            this.context = context;
        }
        public IActionResult Index(DateTime date, int subjectId = -1)
        {
            var teacherSubjects = context.TeacherSubject.Where(x => x.TeacherId == User.GetUserId()).Select(x => new Subject
            {
                SubjectId = x.SubjectId,
                Name = x.Subject.Name
            }).ToList();

            var attendances = new List<StudentAttendanceViewModel>();
            if (subjectId != -1)
            {
                attendances = context.Attendances.Where(x => x.SubjectId == subjectId && x.Stamp.Date == date.Date && x.TeacherId == User.GetUserId()).Select(x => new StudentAttendanceViewModel
                {
                    Name = x.Student.FirstName + " " + x.Student.LastName,
                    RollNo = x.Student.RollNo,
                    IsAbsent = x.IsAbsent,
                    Reason = x.Reason,
                    Stamp = x.Stamp,
                    TotalAbsents = context.Attendances.Where(y => y.StudentId == x.StudentId && y.IsAbsent).Count()
                }).ToList();

            }

            var view = new AttendanceViewModel()
            {
                Subjects = teacherSubjects,
                Attendances = attendances
            };

            return View(view);
        }

        //public async Task<IActionResult> CheckAttendance(int subjectId)
        //{
        //    var attendances = context.Attendances.Where(x => x.SubjectId == subjectId && x.TeacherId == User.GetUserId()).Select(x => new StudentAttendanceViewModel
        //    {
        //        Name = x.Student.FirstName + " " + x.Student.LastName,
        //        RollNo = x.Student.RollNo,
        //        IsAbsent = x.IsAbsent,
        //        Reason = x.Reason,
        //        Stamp = x.Stamp,
        //        TotalAbsents = context.Attendances.Where(x => x.StudentId == x.StudentId).Count()
        //    });
        //    return View(attendances);
        //}
    }
}