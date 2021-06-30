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
            //ViewBag.ResultMessage = "This course was successfully added.";
            //return View(course);
            return RedirectToAction("Update", new { id = course.Id });
        }

        public ViewResult Update(int id)
        {
            Course course = courseRepo.GetByID(id);
            return View(course);
        }

        [HttpPost]
        public ViewResult Update(Course course)
        {
            if (String.IsNullOrEmpty(course.Name))
            {
                ViewBag.ResultMessage = "You cannot leave the course name blank.";
            }
            else
            {
                courseRepo.Update(course);
                ViewBag.ResultMessage = "This course was successfully updated.";
            }
            
            return View(course);
        }

        public ViewResult Delete(int id)
        {
            Course course = courseRepo.GetByID(id);
            return View(course);
        }

        [HttpPost]
        public IActionResult Delete(Course obj)
        {
            //Course course = courseRepo.GetByID(obj.Id);
            courseRepo.Delete(obj);

            return RedirectToAction("Index");
        }

    }
}
