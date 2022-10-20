using FSPTask2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSPTask2.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new FSPTask2Context(serviceProvider.GetRequiredService<
                    DbContextOptions<FSPTask2Context>>()))
            {
                // Look for any techerss.
                if (context.Teacher.Any())
                {
                    return;   // DB has been seeded
                }

                var teachers = new List<Teacher>
                {
                    new Teacher{TeacherName = "Gyro Gearloose"},
                    new Teacher{TeacherName = "Mickey Mouse"},
                    new Teacher{TeacherName = "Elmer Elephant"}
                };



                teachers.ForEach(d => context.Teacher.Add(d));
                context.SaveChanges();

                var courses = new List<Course>
                {
                    new Course{CourseName="Databases", StartDate=new DateTime(2022, 08, 23), TeacherId=1 },
                    new Course{CourseName="Math", StartDate=new DateTime(2022, 08, 23), TeacherId=1 },
                    new Course{CourseName="English", StartDate=new DateTime(2022, 08, 24), TeacherId=2 },
                    new Course{CourseName="Finnish", StartDate=new DateTime(2022, 08, 24), TeacherId=3 },
                    new Course{CourseName="Physics", StartDate=new DateTime(2022, 08, 25), TeacherId=2 },
                    new Course{CourseName="Networking", StartDate=new DateTime(2022, 08, 29), TeacherId=3 }
                };
                foreach (var item in courses)
                {
                    context.Course.Add(item);
                }

                //urses.ForEach(p => context.Course.Add(p));
                context.SaveChanges();
            }
        }
    }
}
