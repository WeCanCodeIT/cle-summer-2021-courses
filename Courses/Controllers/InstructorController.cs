using Courses.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.Controllers
{
    public class InstructorController : Controller
    {
        public UniversityContext db;

        public InstructorController(UniversityContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View(db.Instructors.ToList());
        }

        public IActionResult Details(int id)
        {
            return View(db.Instructors.Where(i => i.Id == id).FirstOrDefault());
        }

        public IActionResult Create()
        {
            return View(new Instructor());
        }

        [HttpPost]
        public IActionResult Create(Instructor model)
        {
            db.Instructors.Add(model);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
