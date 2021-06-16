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
        public CourseRepository repo;
        public CourseController()
        {
            repo = new CourseRepository();
        }

        public ViewResult Index()
        {
            
            return View(repo.GetAll());
        }

        public ViewResult Details(int id)
        {

            return View(repo.GetByID(id));
        }
    }
}
