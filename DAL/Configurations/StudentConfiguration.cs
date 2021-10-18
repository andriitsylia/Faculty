using Faculty.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Faculty.DAL.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasData(
                new Student { StudentId = 1, FirstName = "Andy_01", LastName = "Jones_G_02", GroupId = 2 },
                new Student { StudentId = 2, FirstName = "Andy_02", LastName = "Jones_G_02", GroupId = 2 },
                new Student { StudentId = 3, FirstName = "Andy_03", LastName = "Jones_G_03", GroupId = 3 },
                new Student { StudentId = 4, FirstName = "Andy_04", LastName = "Jones_G_06", GroupId = 6 },
                new Student { StudentId = 5, FirstName = "Andy_05", LastName = "Jones_G_05", GroupId = 5 },
                new Student { StudentId = 6, FirstName = "Andy_06", LastName = "Jones_G_03", GroupId = 3 },
                new Student { StudentId = 7, FirstName = "Andy_07", LastName = "Jones_G_05", GroupId = 5 },
                new Student { StudentId = 8, FirstName = "Andy_08", LastName = "Jones_G_06", GroupId = 6 },
                new Student { StudentId = 9, FirstName = "Andy_09", LastName = "Jones_G_02", GroupId = 2 },
                new Student { StudentId = 10, FirstName = "Andy_10", LastName = "Jones_G_01", GroupId = 1 },
                new Student { StudentId = 11, FirstName = "Andy_11", LastName = "Jones_G_01", GroupId = 1 },
                new Student { StudentId = 12, FirstName = "Andy_12", LastName = "Jones_G_05", GroupId = 5 },
                new Student { StudentId = 13, FirstName = "Andy_13", LastName = "Jones_G_03", GroupId = 3 },
                new Student { StudentId = 14, FirstName = "Andy_14", LastName = "Jones_G_06", GroupId = 6 },
                new Student { StudentId = 15, FirstName = "Andy_15", LastName = "Jones_G_03", GroupId = 3 },
                new Student { StudentId = 16, FirstName = "Andy_16", LastName = "Jones_G_04", GroupId = 4 },
                new Student { StudentId = 17, FirstName = "Andy_17", LastName = "Jones_G_02", GroupId = 2 },
                new Student { StudentId = 18, FirstName = "Andy_18", LastName = "Jones_G_05", GroupId = 5 },
                new Student { StudentId = 19, FirstName = "Andy_19", LastName = "Jones_G_04", GroupId = 4 },
                new Student { StudentId = 20, FirstName = "Andy_20", LastName = "Jones_G_05", GroupId = 5 },
                new Student { StudentId = 21, FirstName = "Andy_21", LastName = "Jones_G_04", GroupId = 4 },
                new Student { StudentId = 22, FirstName = "Andy_22", LastName = "Jones_G_03", GroupId = 3 },
                new Student { StudentId = 23, FirstName = "Andy_23", LastName = "Jones_G_03", GroupId = 3 },
                new Student { StudentId = 24, FirstName = "Andy_24", LastName = "Jones_G_01", GroupId = 1 },
                new Student { StudentId = 25, FirstName = "Andy_25", LastName = "Jones_G_06", GroupId = 6 },
                new Student { StudentId = 26, FirstName = "Andy_26", LastName = "Jones_G_02", GroupId = 2 },
                new Student { StudentId = 27, FirstName = "Andy_27", LastName = "Jones_G_05", GroupId = 5 },
                new Student { StudentId = 28, FirstName = "Andy_28", LastName = "Jones_G_02", GroupId = 2 },
                new Student { StudentId = 29, FirstName = "Andy_29", LastName = "Jones_G_02", GroupId = 2 },
                new Student { StudentId = 30, FirstName = "Andy_30", LastName = "Jones_G_02", GroupId = 2 },
                new Student { StudentId = 31, FirstName = "Andy_31", LastName = "Jones_G_06", GroupId = 6 },
                new Student { StudentId = 32, FirstName = "Andy_32", LastName = "Jones_G_02", GroupId = 2 },
                new Student { StudentId = 33, FirstName = "Andy_33", LastName = "Jones_G_02", GroupId = 2 },
                new Student { StudentId = 34, FirstName = "Andy_34", LastName = "Jones_G_05", GroupId = 5 },
                new Student { StudentId = 35, FirstName = "Andy_35", LastName = "Jones_G_06", GroupId = 6 },
                new Student { StudentId = 36, FirstName = "Andy_36", LastName = "Jones_G_01", GroupId = 1 },
                new Student { StudentId = 37, FirstName = "Andy_37", LastName = "Jones_G_01", GroupId = 1 },
                new Student { StudentId = 38, FirstName = "Andy_38", LastName = "Jones_G_03", GroupId = 3 },
                new Student { StudentId = 39, FirstName = "Andy_39", LastName = "Jones_G_04", GroupId = 4 },
                new Student { StudentId = 40, FirstName = "Andy_40", LastName = "Jones_G_06", GroupId = 6 },
                new Student { StudentId = 41, FirstName = "Andy_41", LastName = "Jones_G_05", GroupId = 5 },
                new Student { StudentId = 42, FirstName = "Andy_42", LastName = "Jones_G_05", GroupId = 5 },
                new Student { StudentId = 43, FirstName = "Andy_43", LastName = "Jones_G_06", GroupId = 6 },
                new Student { StudentId = 44, FirstName = "Andy_44", LastName = "Jones_G_01", GroupId = 1 },
                new Student { StudentId = 45, FirstName = "Andy_45", LastName = "Jones_G_02", GroupId = 2 },
                new Student { StudentId = 46, FirstName = "Andy_46", LastName = "Jones_G_05", GroupId = 5 },
                new Student { StudentId = 47, FirstName = "Andy_47", LastName = "Jones_G_01", GroupId = 1 },
                new Student { StudentId = 48, FirstName = "Andy_48", LastName = "Jones_G_03", GroupId = 3 },
                new Student { StudentId = 49, FirstName = "Andy_49", LastName = "Jones_G_01", GroupId = 1 },
                new Student { StudentId = 50, FirstName = "Andy_50", LastName = "Jones_G_06", GroupId = 6 },
                new Student { StudentId = 51, FirstName = "Andy_51", LastName = "Jones_G_06", GroupId = 6 },
                new Student { StudentId = 52, FirstName = "Andy_52", LastName = "Jones_G_03", GroupId = 3 },
                new Student { StudentId = 53, FirstName = "Andy_53", LastName = "Jones_G_06", GroupId = 6 },
                new Student { StudentId = 54, FirstName = "Andy_54", LastName = "Jones_G_01", GroupId = 1 },
                new Student { StudentId = 55, FirstName = "Andy_55", LastName = "Jones_G_04", GroupId = 4 },
                new Student { StudentId = 56, FirstName = "Andy_56", LastName = "Jones_G_06", GroupId = 6 },
                new Student { StudentId = 57, FirstName = "Andy_57", LastName = "Jones_G_01", GroupId = 1 },
                new Student { StudentId = 58, FirstName = "Andy_58", LastName = "Jones_G_05", GroupId = 5 },
                new Student { StudentId = 59, FirstName = "Andy_59", LastName = "Jones_G_03", GroupId = 3 },
                new Student { StudentId = 60, FirstName = "Andy_60", LastName = "Jones_G_02", GroupId = 2 });
        }
    }
}
