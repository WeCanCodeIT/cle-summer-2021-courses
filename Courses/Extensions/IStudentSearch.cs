using Courses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.Extensions
{
    public interface IStudentSearch
    {
        Student SearchById(string id);
    }
}
