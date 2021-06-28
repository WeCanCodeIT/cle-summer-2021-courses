using Courses.Controllers;
using Courses.Models;
using Courses.Repositories;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using System;
using System.Collections.Generic;
using Xunit;

namespace Courses.Tests
{
    public class CourseControllerTests
    {
        CourseController sut; // single unit test
        IRepository<Course> courseRepo;

        public CourseControllerTests()
        {
            courseRepo = Substitute.For<IRepository<Course>>();
            sut = new CourseController(courseRepo);
        }

        [Fact]
        public void Index_Returns_A_View(){
            // Arrange
            var result = sut.Index();
            //Act

            //Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Create_Returns_A_View()
        {
            // Arrange
            var result = sut.Create();
            //Act

            //Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Model_Is_A_List_Of_Courses()
        {
            // Arrange
            var expectedCourses = new List<Course>();
            courseRepo.GetAll().Returns(expectedCourses);

            //Act
            var result = sut.Index();

            //Assert
            Assert.IsType<List<Course>>(result.Model);
        }

        [Fact]
        public void Index_Passes_A_List_Of_Courses_To_View()
        {
            // Arrange
            var expectedCourses = new List<Course>();
            courseRepo.GetAll().Returns(expectedCourses);

            //Act
            var result = sut.Index();

            //Assert
            Assert.Equal(expectedCourses, result.Model);
        }
    }
}
