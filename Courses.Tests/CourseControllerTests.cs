using Courses.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace Courses.Tests
{
    public class CourseControllerTests
    {
        [Fact]
        public void Index_Returns_A_View()
        {
            var underTest = new CourseController();

            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }
    }
}
