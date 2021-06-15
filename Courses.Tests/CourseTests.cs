using Courses.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Courses.Tests
{
    public class CourseTests
    {
        // sut is Single Unit Test
        Course sut;

        public CourseTests()
        {

        }

        [Fact]
        public void CourseConstructor_Sets_Id_On_Course()
        {
            // Arrange

            // Act
            sut = new Course(42, "");

            // Assert
            Assert.Equal(42, sut.Id);
        }

        [Fact]
        public void CourseConstructor_Sets_Name_On_Course()
        {
            // Arrange

            // Act
            sut = new Course(24, "Math 101");

            // Assert
            Assert.Equal("Math 101", sut.Name);

        }

    }
}
