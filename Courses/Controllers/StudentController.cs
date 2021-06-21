using Courses.Models;
using Courses.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.Controllers
{
    public class StudentController : Controller
    {
        public IRepository<Student> studentRepo;
        public StudentController(IRepository<Student> studentRepo)
        {
            this.studentRepo = studentRepo;
        }

        public ActionResult Index()
        {
            return View(studentRepo.GetAll());
        }
    }
}
