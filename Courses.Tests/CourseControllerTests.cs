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
        public void Delete_Displays_Course_To_Delete_Successfully()
        {
            // Arrange
            var course = new Course() { Id = 1, InstructorId = 1, Students = new List<StudentCourses>() };
            courseRepo.GetByID(1).Returns(course);
            courseRepo.GetAll().Returns(new List<Course>());

            // Act
            var result = sut.Delete(1);

            // Assert
            Assert.Equal(course, result.Model);
            //Assert.IsType<RedirectToActionResult>(result);
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
        public void Create_Adds_A_Model()
        {
            // Arrange
            Course model = new Course() { Name = "Sample Course", InstructorId = 1 };

            // Act
            var result = sut.Create(model);

            // Assert
            Assert.IsType<RedirectToActionResult>(result);
        }

        [Fact]
        public void Update_Returns_A_View()
        {
            // Arrange
            var courseToUpdate = new Course();
            courseRepo.GetByID(1).Returns(courseToUpdate);

            // Act
            var result = sut.Update(1);

            // Assert
            Assert.IsType<ViewResult>(result);
            //Assert.Equal(courseToUpdate, result.Model);
        }

        [Fact]
        public void Update_Passes_Course_To_View()
        {
            // Arrange
            var courseToUpdate = new Course() { Name = "Test Course" };
            courseRepo.GetByID(1).Returns(courseToUpdate);

            // Act
            var result = sut.Update(courseToUpdate);

            // Assert
            Assert.Equal("This course was successfully updated.", result.ViewData["ResultMessage"]);
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
