using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string WCCIId { get; set; }
        [DataType(DataType.Upload)]
        [Display(Name = "Profile Picture")]
        public string ProfilePic { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public virtual List<StudentCourses> Courses { get; set; }

        public Student()
        {

        }

        public Student(int id, string firstname, string lastname)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
        }
    }
}
