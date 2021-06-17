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
    }
}
