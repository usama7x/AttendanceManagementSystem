using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AttendanceManagementSystem.Core.DomainObjects;
using AttendanceManagementSystem.Core.ViewModels;
using AttendanceManagementSystem.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AttendanceManagementSystem.Controllers
{
    public class StudentController : Controller
    {
        readonly ApplicationContext context;
        public StudentController(ApplicationContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var courses = context.Courses.ToList();
            ViewBag.courses = courses.Select(x => new SelectListItem() { Text = x.Name, Value = x.CourseId.ToString() });
            var students = context.Students.ToList();
            var studentView = students.Select(x => new StudentViewModel()
            {
                StudentId = x.StudentId,
                FirstName = x.FirstName,
                LastName = x.LastName,
                City = x.City,
                Phone = x.Phone,
                Course = x.Course.Name,
                Dob = x.Dob,
                Email = x.Email,
                FatherName = x.FatherName,
                Gender = x.Gender,
                RollNo = x.RollNo
            }).OrderByDescending(x => x.Stamp).ToList();            
            
            return View(studentView);
        }

        public async Task<IActionResult> CreateAsync(StudentViewModel model)
        {
            var student = new Student()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                City = model.City,
                Phone = model.Phone,
                Course = context.Courses.Where(x => x.CourseId == int.Parse(model.Course)).FirstOrDefault(),
                Dob = model.Dob,
                Email = model.Email,
                FatherName = model.FatherName,               
                RollNo = model.RollNo,
                Stamp = DateTime.Now,
                Semester = model.Semester               
            };
            context.Students.Add(student);
            await context.SaveChangesAsync();
            var subjects = context.CourseSubjects.Where(x => x.CourseId == int.Parse(model.Course)).ToList();
            subjects.ForEach(x => 
            {
                context.StudentSubjects.Add(new StudentSubject 
                {
                    StudentId = student.StudentId,
                    SubjectId = x.SubjectId
                });                
            });
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var student = context.Students.Find(id);
            context.Students.Remove(student);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}