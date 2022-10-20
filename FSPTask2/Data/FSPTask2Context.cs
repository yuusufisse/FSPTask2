using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FSPTask2.Models;

namespace FSPTask2.Data
{
    public class FSPTask2Context : DbContext
    {
        public FSPTask2Context (DbContextOptions<FSPTask2Context> options)
            : base(options)
        {
        }

        public DbSet<FSPTask2.Models.Teacher> Teacher { get; set; }

        public DbSet<FSPTask2.Models.Course> Course { get; set; }
    }
}
