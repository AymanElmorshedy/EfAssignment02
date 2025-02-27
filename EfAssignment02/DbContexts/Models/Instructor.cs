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

    }
}
