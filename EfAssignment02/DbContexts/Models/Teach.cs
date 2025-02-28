using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfAssignment02.DbContexts.Models
{
    internal class Teach
    {
        public int CourseId { get; set; }
        public int InstructorId { get; set; }
        public int Evaluate { get; set; }
    }
}
