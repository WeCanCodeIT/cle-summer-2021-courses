using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Course> Courses { get; set; }

        public Instructor()
        {

        }

        public Instructor(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
