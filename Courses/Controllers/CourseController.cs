using Courses.Models;
using Courses.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.Controllers
{
    public class CourseController : Controller
    {
        public IRepository<Course> courseRepo;
        public CourseController(IRepository<Course> courseRepo)
        {
            this.courseRepo = courseRepo;
        }

        public ViewResult Index()
        {
            
            return View(courseRepo.GetAll());
        }

        public ViewResult Details(int id)
        {

            return View(courseRepo.GetByID(id));
        }

        public IActionResult Create()
        {
            return View(new Course());
        }

        [HttpPost]
        public ActionResult Create(Course course)
        {
            courseRepo.Create(course);
            ViewBag.ResultMessage = "This course was successfully added.";
            return View(course);
        }

        public IActionResult Update(int id)
        {
            Course course = courseRepo.GetByID(id);
            return View(course);
        }

        [HttpPost]
        public IActionResult Update(Course course)
        {
            courseRepo.Update(course);
            return View(course);
        }

    }
}
