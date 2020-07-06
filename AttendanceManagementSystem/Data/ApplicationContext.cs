using AttendanceManagementSystem.Core.DomainObjects;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AttendanceManagementSystem.Core.ViewModels;

namespace AttendanceManagementSystem.Data
{
    public class ApplicationContext: IdentityDbContext<Teacher,ApplicationRole,int>
    {
        public ApplicationContext(DbContextOptions options):base(options) { }

        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }        
        public DbSet<TeacherSubject> TeacherSubject { get; set; }
        public DbSet<StudentSubject> StudentSubjects { get; set; }
        public DbSet<CourseSubject> CourseSubjects { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<TeacherSubjectViewModel>().HasNoKey();
            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly);
            base.OnModelCreating(builder);
        }

      

    }

}
