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

        public IEnumerable<Course> GetAll()
        {
            return db.Courses.ToList();
        }

        public Course GetByID(int id)
        {
            return db.Courses.Where(c => c.Id == id).FirstOrDefault();
        }
    }
}
