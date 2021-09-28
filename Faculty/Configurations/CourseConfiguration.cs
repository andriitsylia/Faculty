using Faculty.Interfaces;
using Faculty.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Faculty.Configurations
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>, IAllCourses
    {
        
        public IEnumerable<Course> Courses
        {
            get 
            {
                return new List<Course> {
                            new Course { CourseId = 1,
                                         Name = "Algebra", 
                                         Description = "Course of the algebra" },
                            new Course { CourseId = 2,
                                         Name = "Math analysis", 
                                         Description = "Course of the math analysis" },
                            new Course { CourseId = 3,
                                         Name = "Discrete mathematics", 
                                         Description = "Course of the discrete mathematics" } };
            }
        }

        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasData(new Course { CourseId = 1,
                                         Name = "Algebra", 
                                         Description = "Course of the algebra" },
                            new Course { CourseId = 2,
                                         Name = "Math analysis", 
                                         Description = "Course of the math analysis" },
                            new Course { CourseId = 3,
                                         Name = "Discrete mathematics", 
                                         Description = "Course of the discrete mathematics" });
        }
    }
}
