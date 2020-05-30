using AttendanceManagementSystem.Core.DomainObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AttendanceManagementSystem.EntityConfiguration
{
    public class AttendanceConfiguration : IEntityTypeConfiguration<Attendance>
    {
        public void Configure(EntityTypeBuilder<Attendance> builder)
        {
            builder.HasOne(x => x.Student).WithMany(x => x.Attendances).HasForeignKey(x => x.StudentId)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Subject).WithMany(x => x.Attendances).HasForeignKey(x => x.SubjectId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
