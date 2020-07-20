using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AttendanceManagementSystem.Core.DomainObjects;
using AttendanceManagementSystem.Core.ViewModels;
using AttendanceManagementSystem.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AttendanceManagementSystem.Controllers
{
    public class TeacherController : Controller
    {
        readonly ApplicationContext context;
        readonly UserManager<Teacher> userManager;
        public TeacherController(ApplicationContext context, UserManager<Teacher> userManager)
        {
            this.userManager = userManager;
            this.context = context;
        }
        public IActionResult Index()
        {
            var teacher = context.Teachers.OrderByDescending(x => x.Stamp).ToList();
            var teacherView = new TeacherViewModel()
            {
                Teachers = teacher,
                Teacher = new Core.DomainObjects.Teacher()
            };
            return View(teacherView);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(Teacher teacher)
        {
            teacher.UserName = teacher.Email;
            var result = await userManager.CreateAsync(teacher, teacher.Password);
            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(teacher, "teacher");
                return RedirectToAction("Index");
            } else
            {
                return NotFound();
            }

        }

        public IActionResult Delete(int id)
        {
            var course = context.Courses.Find(id);
            context.Courses.Remove(course);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}