using EfAssignment02.DbContexts.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfAssignment02.DbContexts
{
    internal class ITTDbContext : DbContext
    {
        public ITTDbContext() :base() 
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer("Server=.;Database=ITIDb;Trusted_Connection=true;TrustServerCertificate=true");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasOne(S => S.StudentDepartment)
                .WithMany(D => D.Students)
                .HasForeignKey(S => S.DepartmentId)
                .IsRequired(true);

            modelBuilder.Entity<Department>()
                .HasMany(D=>D.Instructors)
                .WithOne(I=>I.InstructorDepartment)
                .HasForeignKey(I=>I.DepartmentId)
                .IsRequired(true);

            modelBuilder.Entity<Course>()
                .HasOne(C => C.CourseTopic)
                .WithMany(T => T.Courses)
                .HasForeignKey(c => c.TopicId)
                .IsRequired(false);
            modelBuilder.Entity<Department>()
                .HasOne(D=>D.Maneger)
                .WithOne(I=>I.ManegedDepartment)
                .HasForeignKey<Department>(D=>D.ManegerId)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Student>()
                .HasMany(s => s.Courses)
                .WithMany(C => C.Students)
                .UsingEntity<Enrollment>();
            modelBuilder.Entity<Instructor>()
                .HasMany(i => i.Courses)
                .WithMany(C => C.Instructors)
                .UsingEntity<Teach>();

                //.OnDelete(DeleteBehavior.NoAction);

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Topic> Topics { get; set; }
    }
    
}
