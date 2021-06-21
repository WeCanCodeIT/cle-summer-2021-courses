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

        public IActionResult Create()
        {
            return View(new Student());
        }

        [HttpPost]
        public IActionResult Create(Student model)
        {
            studentRepo.Create(model);
            return RedirectToAction("Update", new { id = model.Id });
        }

        public IActionResult Update(int id)
        {
            Student student = studentRepo.GetByID(id);
            return View(student);
        }

    }
}
