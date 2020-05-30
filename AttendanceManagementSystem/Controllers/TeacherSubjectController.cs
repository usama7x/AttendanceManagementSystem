using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AttendanceManagementSystem.Core.DomainObjects;
using AttendanceManagementSystem.Core.ViewModels;
using AttendanceManagementSystem.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AttendanceManagementSystem.Controllers
{
    public class TeacherSubjectController : Controller
    {
        readonly ApplicationContext context;
        readonly UserManager<Teacher> userManager;
        public TeacherSubjectController(ApplicationContext context,UserManager<Teacher> userManager)
        {
            this.userManager = userManager;
            this.context = context;
        }
        public IActionResult Index()
        {
            var teacherSubjects = context.TeacherSubject.OrderByDescending(x => x.Stamp).ToList();
            var teacherSubjectView =  teacherSubjects.Select(x => new TeacherSubjectViewModel
            {
                Course = context.Subjects.Find(x.SubjectId).CourseName,
                Teacher = context.Teachers.Find(x.TeacherId).FirstName + " " + context.Teachers.Find(x.TeacherId).LastName,
                Semester = context.Subjects.Find(x.SubjectId).Semester,
                Subject = context.Subjects.Find(x.SubjectId).Name,
                Year = context.Subjects.Find(x.SubjectId).Year               
            }).ToList();

            var view = new AllocateSubjectViewModel()
            {
                TeacherSubjects = teacherSubjectView,
                TeacherSubject = new TeacherSubject(),
                Teachers = context.Teachers.ToList(),
                Courses = context.Courses.ToList(),
                Subjects = context.Subjects.OrderByDescending(x => x.Stamp).ToList()
            };

            return View(view);
        }

        public async Task<IActionResult> CreateAsync(int subjectId, int teacherId)
        {
            var teacherSubject = new TeacherSubject()
            {
                SubjectId = subjectId,
                TeacherId = teacherId
            };
             context.TeacherSubject.Add(teacherSubject);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}