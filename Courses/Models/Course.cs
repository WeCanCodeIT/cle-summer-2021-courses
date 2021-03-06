using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<StudentCourses> Students { get; set; }
        public int InstructorId { get; set; }
        public virtual Instructor Instructor { get; set; }
        public Course()
        {
            Name = "Unnamed Course";
        }
        public Course(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
