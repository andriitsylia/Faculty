using Faculty.Interfaces;
using Faculty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Faculty.Services
{
    public class PrepareAllCoursesListToInsertToDatabase : IAllCourses
    {
        public IEnumerable<Course> Courses
        {
            get 
            {
                return new List<Course> {
                            new Course { Name = "Algebra", 
                                         Description = "Course of the algebra" },
                            new Course { Name = "Math analysis", 
                                         Description = "Course of the math analysis" },
                            new Course { Name = "Discrete mathematics", 
                                         Description = "Course of the discrete mathematics" } };
            }
        }
    }
}
