﻿using Faculty.Interfaces;
using Faculty.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Faculty.Configurations
{
    public class GroupConfiguration : IEntityTypeConfiguration<Group>, IAllGroups
    {
        public IEnumerable<Group> Groups 
        {
            get
            {
                return new List<Group> {
                            new Group { GroupId = 1, Name ="SR-01", CourseId = 3},
                            new Group { GroupId = 2, Name ="SR-02", CourseId = 2},
                            new Group { GroupId = 3, Name ="SR-03", CourseId = 1},
                            new Group { GroupId = 4, Name ="SR-04", CourseId = 3},
                            new Group { GroupId = 5, Name ="SR-05", CourseId = 2},
                            new Group { GroupId = 6, Name ="SR-06", CourseId = 1}};
            }
        }

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