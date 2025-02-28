using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EfAssignment02.DbContexts.Models
{
    internal class Course
    {
      
        public int CourseId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Duration { get; set; }
        public int TopicId { get; set; }
        public Topic CourseTopic { get; set; } = null!;
        public ICollection<Student> Students { get; set; }
        public ICollection<Instructor> Instructors { get; set; }
    }
}
