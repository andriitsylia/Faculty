using Faculty.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Faculty.Data.Configurations
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
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
