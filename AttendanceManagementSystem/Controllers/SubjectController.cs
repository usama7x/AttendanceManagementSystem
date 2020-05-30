using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AttendanceManagementSystem.Core.DomainObjects;
using AttendanceManagementSystem.Core.ViewModels;
using AttendanceManagementSystem.Data;
using Microsoft.AspNetCore.Mvc;

namespace AttendanceManagementSystem.Controllers
{
    public class SubjectController : Controller
    {
        readonly ApplicationContext context;
        public SubjectController(ApplicationContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            
            var subjects = context.Subjects.ToList();
            var courses = context.Courses.ToList();
            var subjectView = new SubjectViewModel()
            {
                Subjects = subjects,
                Courses = courses,
                Subject = new Core.DomainObjects.Subject()
            };
            return View(subjectView);
        }

        public async Task<IActionResult> Create(SubjectViewModel model)
        {
            var newSubject = new Subject()
            {
                Name = model.Subject.Name,
                CourseId = model.Subject.CourseId,
                Year = model.Subject.Year,
                Semester = model.Subject.Semester,
                CourseName = context.Courses.FindAsync(model.Subject.CourseId).Result.Name,                
            };
            context.Subjects.Add(newSubject);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var subjectToBeDeleted = context.Subjects.Find(id);
            context.Subjects.Remove(subjectToBeDeleted);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}