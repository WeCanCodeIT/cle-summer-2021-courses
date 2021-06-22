using Courses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.Repositories
{
    public class CourseRepository : IRepository<Course>
    {
        public UniversityContext db;

        public CourseRepository(UniversityContext db)
        {
            this.db = db;
        }

        public void Create(Course obj)
        {
            db.Courses.Add(obj);
            db.SaveChanges();
        }

        public void Delete(Course obj)
        {
            db.Courses.Remove(obj);
            db.SaveChanges();
        }

        public IEnumerable<Course> GetAll()
        {
            return db.Courses.ToList();
        }

        public Course GetByID(int id)
        {
            return db.Courses.Where(c => c.Id == id).FirstOrDefault();
        }

        public IEnumerable<Course> GetCourses()
        {
            throw new NotImplementedException();
        }

        public void Update(Course obj)
        {
            db.Courses.Update(obj);
            db.SaveChanges();
        }
    }
}
