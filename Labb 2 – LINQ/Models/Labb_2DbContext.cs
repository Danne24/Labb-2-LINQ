using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2___LINQ.Models
{
    public class Labb_2DbContext : DbContext
    {
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<StudentSubject> StudentsSubjects { get; set; }
        public DbSet<TeacherSubject> TeachersSubjects { get; set; }
        public DbSet<StudentTeacher> StudentsTeachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = DESKTOP-5CMCK84;Initial Catalog=Labb2-LINQDb;Integrated Security = True;");
        }
    }
}
