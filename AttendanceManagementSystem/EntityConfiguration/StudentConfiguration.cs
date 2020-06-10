using AttendanceManagementSystem.Core.DomainObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AttendanceManagementSystem.EntityConfiguration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasMany<Attendance>(a => a.Attendances).WithOne(s => s.Student).HasForeignKey(f => f.StudentId);
            builder.HasMany<StudentSubject>(x => x.StudentSubjects).WithOne(x => x.Student).HasForeignKey(x => x.StudentId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
