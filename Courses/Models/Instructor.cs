using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Upload)]
        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Please choose file to upload.")]
        public string ProfilePic { get; set; }
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
