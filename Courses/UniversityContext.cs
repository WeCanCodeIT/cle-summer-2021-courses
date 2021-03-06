using Courses.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses
{
    public class UniversityContext : IdentityDbContext
    {
        public DbSet<Course> Courses { get; set;}
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<StudentCourses> StudentCourses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb; Database=UniversityDB_062021; Trusted_Connection=True";

            optionsBuilder.UseSqlServer(connectionString).UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasData(
                new Course(1, "Psychology 101") { InstructorId = 1},
                new Course(2, "Sociology 101") { InstructorId = 2 },
                new Course(3, "Political Science 101") { InstructorId = 3 }
            );
            modelBuilder.Entity<Student>().HasData(
                new Student(1, "Carlos", "Lopez") { WCCIId = "W4657864" },
                new Student(2, "Davis", "Murphy") { WCCIId = "W6889555" },
                new Student(3, "John", "Doe") { WCCIId = "W98856855" }
            );
            modelBuilder.Entity<StudentCourses>().HasData(
                new StudentCourses() { Id = 1, CourseId = 3, StudentId = 1 },
                new StudentCourses() { Id = 2, CourseId = 2, StudentId = 3 }
            );
            modelBuilder.Entity<Instructor>().HasData(
                new Instructor() { Id = 1, Name = "Davis Murphy", ProfilePic = "demopic.jpg" },
                new Instructor() { Id = 2, Name = "Carlos Lopez", ProfilePic = "demopic.jpg" },
                new Instructor() { Id = 3, Name = "Kevin McDonald", ProfilePic = "demopic.jpg" }
            );

            base.OnModelCreating(modelBuilder);
        }

        

    }
}
