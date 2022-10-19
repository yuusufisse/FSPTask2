using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FSPTask2.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
