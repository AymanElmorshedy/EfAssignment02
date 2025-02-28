using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfAssignment02.DbContexts.Models
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Address { get; set; } = null!;
        public int Age { get; set; }
        public int DepartmentId { get; set; }
        [InverseProperty(nameof(Department.Students))]
        public Department StudentDepartment { get; set; } = null!;
        public ICollection<Course> Courses { get; set; }
    }
}
