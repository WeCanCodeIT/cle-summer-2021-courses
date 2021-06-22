using Courses.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.Controllers
{
    public class RegistrationController : Controller
    {
        private UniversityContext db;
        public RegistrationController(UniversityContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View(db.StudentCourses.ToList());
        }

        public IActionResult Create()
        {
            ViewBag.Students = db.Students.ToList();
            ViewBag.Courses = db.Courses.ToList();

            return View(new StudentCourses() { EnrollmentDate = DateTime.Now });
        }

        [HttpPost]
        public IActionResult Create(StudentCourses model)
        {
            model.EnrollmentDate = DateTime.Now;
            db.StudentCourses.Add(model);
            db.SaveChanges();

            return RedirectToAction("Update", new { id = model.Id });
        }

        public IActionResult Update(int id)
        {
            return View(db.StudentCourses.Find(id));
        }
    }
}
