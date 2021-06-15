using Courses.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.Controllers
{
    public class CourseController : Controller
    {
        public ViewResult Index()
        {
            List<Course> sampleList = new List<Course>();

            sampleList.Add(new Course(156, "Psychology 101"));
            sampleList.Add(new Course(259, "Sociology 101"));
            sampleList.Add(new Course(458, "Political Science 101"));


            return View(sampleList);
        }

        public ViewResult Details(int id)
        {
            List<Course> sampleList = new List<Course>();

            sampleList.Add(new Course(156, "Psychology 101"));
            sampleList.Add(new Course(259, "Sociology 101"));
            sampleList.Add(new Course(458, "Political Science 101"));

            // LINQ
            Course myCourse = sampleList.Where(c => c.Id == id).FirstOrDefault();

            return View(myCourse);
        }
    }
}
