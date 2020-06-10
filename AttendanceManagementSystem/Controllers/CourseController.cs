using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AttendanceManagementSystem.Data;
using Microsoft.AspNetCore.Mvc;

namespace AttendanceManagementSystem.Controllers
{
    public class CourseController : Controller
    {

        readonly ApplicationContext context;
        public CourseController(ApplicationContext context)
        {
            this.context = context;
        }
        public async Task<IActionResult> Index()
        {
            var course = context.Courses.ToList();
            return View(course);
        }
        [HttpPost]
        public IActionResult Create(string course)
        {
            context.Courses.Add(new Core.DomainObjects.Course() { Name = course });
            context.SaveChanges();
            return RedirectToActionPermanent("Index");
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