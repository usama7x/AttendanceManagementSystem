using AttendanceManagementSystem.Core.DomainObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AttendanceManagementSystem.EntityConfiguration
{
    public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.HasMany<TeacherSubject>(x => x.TeacherSubjects).WithOne(x => x.Subject).HasForeignKey(x => x.SubjectId);
            builder.HasMany<CourseSubject>(x => x.CourseSubjects).WithOne(x => x.Subject).HasForeignKey(x => x.SubjectId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
