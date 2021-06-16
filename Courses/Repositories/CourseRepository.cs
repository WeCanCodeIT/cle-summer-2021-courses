using Courses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.Repositories
{
    public class CourseRepository : IRepository<Course>
    {
        public List<Course> courseList;

        public CourseRepository()
        {
            courseList = new List<Course>()
            {
                new Course(156, "Psychology 101"),
                new Course(259, "Sociology 101"),
                new Course(458, "Political Science 101")
            };
        }

        public IEnumerable<Course> GetAll()
        {
            return courseList;
        }

        public Course GetByID(int id)
        {
            return courseList.Where(c => c.Id == id).FirstOrDefault();
        }
    }
}
