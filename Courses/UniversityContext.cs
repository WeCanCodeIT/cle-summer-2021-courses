using Courses.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses
{
    public class UniversityContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb; Database=UniversityDB_062021; Trusted_Connection=True";
            
            optionsBuilder.UseSqlServer(connectionString).UseLazyLoadingProxies();
            
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasData(
                new Course(1, "Psychology 101"),
                new Course(2, "Sociology 101"),
                new Course(3, "Political Science 101")
            );
        }

    }
}
