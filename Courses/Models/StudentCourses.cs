using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.Models
{
    public class StudentCourses
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }
}
