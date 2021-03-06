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
        public UniversityContext db;
        public StudentRepository(UniversityContext db)
        {
            this.db = db;
        }

        public void Create(Student obj)
        {
            db.Students.Add(obj);
            db.SaveChanges();
        }

        public void Delete(Student obj)
        {
            db.Students.Remove(obj);
            db.SaveChanges();
        }

        public IEnumerable<Student> GetAll()
        {
            return db.Students.ToList();
        }

        public Student GetByID(int id)
        {
            return db.Students.Where(s => s.Id == id).FirstOrDefault();
        }

        public IEnumerable<Course> GetCourses()
        {
            return db.Courses.ToList();
        }

        public Student SearchById(string id)
        {
            //return new Student();
            return db.Students.Where(s => s.WCCIId == id).FirstOrDefault();
        }

        public void Update(Student obj)
        {
            db.Students.Update(obj);
            db.SaveChanges();
        }
    }
}
