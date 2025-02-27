using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfAssignment02.DbContexts.Models.ModelConfigrations
{
    internal class StudentConfigration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
         builder.HasKey(S=>S.StudentId);
            builder.Property(S => S.FirstName)
                .HasColumnName("StudentFName")
                .HasMaxLength(20)
                .IsRequired(true);
            builder.Property(S => S.LastName)
                .HasColumnName("StudentLName")
                .IsRequired(false);

                
        }
    }
}
