using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configurations
{
    public class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.HasData(new Group { GroupId = 1, Name = "SR-01", CourseId = 3 },
                            new Group { GroupId = 2, Name = "SR-02", CourseId = 2 },
                            new Group { GroupId = 3, Name = "SR-03", CourseId = 1 },
                            new Group { GroupId = 4, Name = "SR-04", CourseId = 3 },
                            new Group { GroupId = 5, Name = "SR-05", CourseId = 2 },
                            new Group { GroupId = 6, Name = "SR-06", CourseId = 1 });
        }
    }
}