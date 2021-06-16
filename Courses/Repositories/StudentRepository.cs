using Courses.Extensions;
using Courses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.Repositories
{
    public class StudentRepository : IRepository<Student>, IStudentSearch
    {
        public List<Student> studentList;
        public StudentRepository()
        {
            studentList = new List<Student>()
            {
                new Student(){ Id=235, FirstName = "Carlos", LastName = "Lopez" },
                new Student(){ Id=546, FirstName = "Davis", LastName = "Murphy" }
            };
        }

        public IEnumerable<Student> GetAll()
        {
            return studentList;
        }

        public Student GetByID(int id)
        {
            return studentList.Where(s => s.Id == id).FirstOrDefault();
        }

        public Student SearchById(string id)
        {
            return studentList.Where(s => s.StudentId == id).FirstOrDefault();
        }
    }
}
