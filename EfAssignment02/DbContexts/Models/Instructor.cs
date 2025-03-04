﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfAssignment02.DbContexts.Models
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Bouns { get; set; }
        [Column("InstructorSalary",TypeName ="decimal(10,2)")]
        public decimal Salary { get; set; }
        public string Address { get; set; }
        public int HoursRate { get; set; }
        public int DepartmentId { get; set; }
        [InverseProperty(nameof(Department.Instructors))]
        public Department InstructorDepartment { get; set; } = null!;
        [InverseProperty(nameof(Department.Maneger))]
        public Department? ManegedDepartment { get; set; }
        public ICollection<Course> Courses { get; set; }

    }
}
