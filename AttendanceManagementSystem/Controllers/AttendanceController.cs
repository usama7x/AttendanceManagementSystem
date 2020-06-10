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
    public class AttendanceController : Controller
    {
        readonly ApplicationContext context;
        public AttendanceController(ApplicationContext context)
        {
            this.context = context;
        }
        public IActionResult Index(int subjectId = -1)
        {

            var teacherId = User.GetUserId();
            var teacherSubjects = context.TeacherSubject.Where(x => x.TeacherId == teacherId).Select(x => new Subject
            {
                SubjectId = x.SubjectId,
                Name = x.Subject.Name
            }).ToList();

            var students = context.StudentSubjects.Where(x => x.SubjectId == subjectId).Select(x => new StudentAttendanceViewModel()
            {
                Id = x.StudentId,
                Name = x.Student.FirstName + " " + x.Student.LastName,
                RollNo = x.Student.RollNo,
                IsAbsent = false,
                Reason = String.Empty,
                TotalAbsents = context.Attendances.Where(y => y.StudentId == x.StudentId && x.SubjectId == subjectId && y.IsAbsent).Count()
            }).OrderBy(x => x.RollNo).ToArray();


            var view = new AttendanceViewModel()
            {
                Subjects = teacherSubjects,
                Students = students,
                SubjectId = subjectId
            };
            return View(view);
        }
       
        [HttpPost]
        public async Task<IActionResult> Create(AttendanceViewModel model)
        {
            var attendances = model.Students.Select(x => new Attendance
            {
                IsAbsent = x.IsAbsent,
                Reason = x.Reason,
                Stamp = DateTime.Now,
                StudentId = x.Id,
                TeacherId = User.GetUserId(),
                SubjectId = (int)model.SubjectId
            });
            context.Attendances.AddRange(attendances);
            await context.SaveChangesAsync();
            
            return RedirectToActionPermanent("Index");
        }
    }
}