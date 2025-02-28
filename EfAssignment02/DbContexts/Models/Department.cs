using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfAssignment02.DbContexts.Models
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateOnly HiringDate { get; set; }
        [InverseProperty(nameof(Student.StudentDepartment))]
        public ICollection<Student> Students { get; set; }
        [InverseProperty(nameof(Instructor.InstructorDepartment))]
        public ICollection<Instructor> Instructors { get; set; }
        public int ManegerId { get; set; }
        [InverseProperty(nameof(Instructor.ManegedDepartment))]
        public Instructor Maneger { get; set; } = null!;

    }
}
