using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSPTask2.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string TeacherName { get; set; }
        public List<Course>? Courses { get; set; }

    }
}
