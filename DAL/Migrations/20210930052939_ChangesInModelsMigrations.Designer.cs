﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Faculty.DAL.EF;

namespace Faculty.WEB.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20210930052939_ChangesInModelsMigrations")]
    partial class ChangesInModelsMigrations
    {
        protected void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WEB.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("CourseId");

                    b.ToTable("Course");

                    b.HasData(
                        new
                        {
                            CourseId = 1,
                            Description = "Course of the algebra",
                            Name = "Algebra"
                        },
                        new
                        {
                            CourseId = 2,
                            Description = "Course of the math analysis",
                            Name = "Math analysis"
                        },
                        new
                        {
                            CourseId = 3,
                            Description = "Course of the discrete mathematics",
                            Name = "Discrete mathematics"
                        });
                });

            modelBuilder.Entity("WEB.Models.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("GroupId");

                    b.HasIndex("CourseId");

                    b.ToTable("Group");

                    b.HasData(
                        new
                        {
                            GroupId = 1,
                            CourseId = 3,
                            Name = "SR-01"
                        },
                        new
                        {
                            GroupId = 2,
                            CourseId = 2,
                            Name = "SR-02"
                        },
                        new
                        {
                            GroupId = 3,
                            CourseId = 1,
                            Name = "SR-03"
                        },
                        new
                        {
                            GroupId = 4,
                            CourseId = 3,
                            Name = "SR-04"
                        },
                        new
                        {
                            GroupId = 5,
                            CourseId = 2,
                            Name = "SR-05"
                        },
                        new
                        {
                            GroupId = 6,
                            CourseId = 1,
                            Name = "SR-06"
                        });
                });

            modelBuilder.Entity("WEB.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("StudentId");

                    b.HasIndex("GroupId");

                    b.ToTable("Student");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            FirstName = "Andy_01",
                            GroupId = 2,
                            LastName = "Jones_G_02"
                        },
                        new
                        {
                            StudentId = 2,
                            FirstName = "Andy_02",
                            GroupId = 2,
                            LastName = "Jones_G_02"
                        },
                        new
                        {
                            StudentId = 3,
                            FirstName = "Andy_03",
                            GroupId = 3,
                            LastName = "Jones_G_03"
                        },
                        new
                        {
                            StudentId = 4,
                            FirstName = "Andy_04",
                            GroupId = 6,
                            LastName = "Jones_G_06"
                        },
                        new
                        {
                            StudentId = 5,
                            FirstName = "Andy_05",
                            GroupId = 5,
                            LastName = "Jones_G_05"
                        },
                        new
                        {
                            StudentId = 6,
                            FirstName = "Andy_06",
                            GroupId = 3,
                            LastName = "Jones_G_03"
                        },
                        new
                        {
                            StudentId = 7,
                            FirstName = "Andy_07",
                            GroupId = 5,
                            LastName = "Jones_G_05"
                        },
                        new
                        {
                            StudentId = 8,
                            FirstName = "Andy_08",
                            GroupId = 6,
                            LastName = "Jones_G_06"
                        },
                        new
                        {
                            StudentId = 9,
                            FirstName = "Andy_09",
                            GroupId = 2,
                            LastName = "Jones_G_02"
                        },
                        new
                        {
                            StudentId = 10,
                            FirstName = "Andy_10",
                            GroupId = 1,
                            LastName = "Jones_G_01"
                        },
                        new
                        {
                            StudentId = 11,
                            FirstName = "Andy_11",
                            GroupId = 1,
                            LastName = "Jones_G_01"
                        },
                        new
                        {
                            StudentId = 12,
                            FirstName = "Andy_12",
                            GroupId = 5,
                            LastName = "Jones_G_05"
                        },
                        new
                        {
                            StudentId = 13,
                            FirstName = "Andy_13",
                            GroupId = 3,
                            LastName = "Jones_G_03"
                        },
                        new
                        {
                            StudentId = 14,
                            FirstName = "Andy_14",
                            GroupId = 6,
                            LastName = "Jones_G_06"
                        },
                        new
                        {
                            StudentId = 15,
                            FirstName = "Andy_15",
                            GroupId = 3,
                            LastName = "Jones_G_03"
                        },
                        new
                        {
                            StudentId = 16,
                            FirstName = "Andy_16",
                            GroupId = 4,
                            LastName = "Jones_G_04"
                        },
                        new
                        {
                            StudentId = 17,
                            FirstName = "Andy_17",
                            GroupId = 2,
                            LastName = "Jones_G_02"
                        },
                        new
                        {
                            StudentId = 18,
                            FirstName = "Andy_18",
                            GroupId = 5,
                            LastName = "Jones_G_05"
                        },
                        new
                        {
                            StudentId = 19,
                            FirstName = "Andy_19",
                            GroupId = 4,
                            LastName = "Jones_G_04"
                        },
                        new
                        {
                            StudentId = 20,
                            FirstName = "Andy_20",
                            GroupId = 5,
                            LastName = "Jones_G_05"
                        },
                        new
                        {
                            StudentId = 21,
                            FirstName = "Andy_21",
                            GroupId = 4,
                            LastName = "Jones_G_04"
                        },
                        new
                        {
                            StudentId = 22,
                            FirstName = "Andy_22",
                            GroupId = 3,
                            LastName = "Jones_G_03"
                        },
                        new
                        {
                            StudentId = 23,
                            FirstName = "Andy_23",
                            GroupId = 3,
                            LastName = "Jones_G_03"
                        },
                        new
                        {
                            StudentId = 24,
                            FirstName = "Andy_24",
                            GroupId = 1,
                            LastName = "Jones_G_01"
                        },
                        new
                        {
                            StudentId = 25,
                            FirstName = "Andy_25",
                            GroupId = 6,
                            LastName = "Jones_G_06"
                        },
                        new
                        {
                            StudentId = 26,
                            FirstName = "Andy_26",
                            GroupId = 2,
                            LastName = "Jones_G_02"
                        },
                        new
                        {
                            StudentId = 27,
                            FirstName = "Andy_27",
                            GroupId = 5,
                            LastName = "Jones_G_05"
                        },
                        new
                        {
                            StudentId = 28,
                            FirstName = "Andy_28",
                            GroupId = 2,
                            LastName = "Jones_G_02"
                        },
                        new
                        {
                            StudentId = 29,
                            FirstName = "Andy_29",
                            GroupId = 2,
                            LastName = "Jones_G_02"
                        },
                        new
                        {
                            StudentId = 30,
                            FirstName = "Andy_30",
                            GroupId = 2,
                            LastName = "Jones_G_02"
                        },
                        new
                        {
                            StudentId = 31,
                            FirstName = "Andy_31",
                            GroupId = 6,
                            LastName = "Jones_G_06"
                        },
                        new
                        {
                            StudentId = 32,
                            FirstName = "Andy_32",
                            GroupId = 2,
                            LastName = "Jones_G_02"
                        },
                        new
                        {
                            StudentId = 33,
                            FirstName = "Andy_33",
                            GroupId = 2,
                            LastName = "Jones_G_02"
                        },
                        new
                        {
                            StudentId = 34,
                            FirstName = "Andy_34",
                            GroupId = 5,
                            LastName = "Jones_G_05"
                        },
                        new
                        {
                            StudentId = 35,
                            FirstName = "Andy_35",
                            GroupId = 6,
                            LastName = "Jones_G_06"
                        },
                        new
                        {
                            StudentId = 36,
                            FirstName = "Andy_36",
                            GroupId = 1,
                            LastName = "Jones_G_01"
                        },
                        new
                        {
                            StudentId = 37,
                            FirstName = "Andy_37",
                            GroupId = 1,
                            LastName = "Jones_G_01"
                        },
                        new
                        {
                            StudentId = 38,
                            FirstName = "Andy_38",
                            GroupId = 3,
                            LastName = "Jones_G_03"
                        },
                        new
                        {
                            StudentId = 39,
                            FirstName = "Andy_39",
                            GroupId = 4,
                            LastName = "Jones_G_04"
                        },
                        new
                        {
                            StudentId = 40,
                            FirstName = "Andy_40",
                            GroupId = 6,
                            LastName = "Jones_G_06"
                        },
                        new
                        {
                            StudentId = 41,
                            FirstName = "Andy_41",
                            GroupId = 5,
                            LastName = "Jones_G_05"
                        },
                        new
                        {
                            StudentId = 42,
                            FirstName = "Andy_42",
                            GroupId = 5,
                            LastName = "Jones_G_05"
                        },
                        new
                        {
                            StudentId = 43,
                            FirstName = "Andy_43",
                            GroupId = 6,
                            LastName = "Jones_G_06"
                        },
                        new
                        {
                            StudentId = 44,
                            FirstName = "Andy_44",
                            GroupId = 1,
                            LastName = "Jones_G_01"
                        },
                        new
                        {
                            StudentId = 45,
                            FirstName = "Andy_45",
                            GroupId = 2,
                            LastName = "Jones_G_02"
                        },
                        new
                        {
                            StudentId = 46,
                            FirstName = "Andy_46",
                            GroupId = 5,
                            LastName = "Jones_G_05"
                        },
                        new
                        {
                            StudentId = 47,
                            FirstName = "Andy_47",
                            GroupId = 1,
                            LastName = "Jones_G_01"
                        },
                        new
                        {
                            StudentId = 48,
                            FirstName = "Andy_48",
                            GroupId = 3,
                            LastName = "Jones_G_03"
                        },
                        new
                        {
                            StudentId = 49,
                            FirstName = "Andy_49",
                            GroupId = 1,
                            LastName = "Jones_G_01"
                        },
                        new
                        {
                            StudentId = 50,
                            FirstName = "Andy_50",
                            GroupId = 6,
                            LastName = "Jones_G_06"
                        },
                        new
                        {
                            StudentId = 51,
                            FirstName = "Andy_51",
                            GroupId = 6,
                            LastName = "Jones_G_06"
                        },
                        new
                        {
                            StudentId = 52,
                            FirstName = "Andy_52",
                            GroupId = 3,
                            LastName = "Jones_G_03"
                        },
                        new
                        {
                            StudentId = 53,
                            FirstName = "Andy_53",
                            GroupId = 6,
                            LastName = "Jones_G_06"
                        },
                        new
                        {
                            StudentId = 54,
                            FirstName = "Andy_54",
                            GroupId = 1,
                            LastName = "Jones_G_01"
                        },
                        new
                        {
                            StudentId = 55,
                            FirstName = "Andy_55",
                            GroupId = 4,
                            LastName = "Jones_G_04"
                        },
                        new
                        {
                            StudentId = 56,
                            FirstName = "Andy_56",
                            GroupId = 6,
                            LastName = "Jones_G_06"
                        },
                        new
                        {
                            StudentId = 57,
                            FirstName = "Andy_57",
                            GroupId = 1,
                            LastName = "Jones_G_01"
                        },
                        new
                        {
                            StudentId = 58,
                            FirstName = "Andy_58",
                            GroupId = 5,
                            LastName = "Jones_G_05"
                        },
                        new
                        {
                            StudentId = 59,
                            FirstName = "Andy_59",
                            GroupId = 3,
                            LastName = "Jones_G_03"
                        },
                        new
                        {
                            StudentId = 60,
                            FirstName = "Andy_60",
                            GroupId = 2,
                            LastName = "Jones_G_02"
                        });
                });

            modelBuilder.Entity("WEB.Models.Group", b =>
                {
                    b.HasOne("WEB.Models.Course", "Course")
                        .WithMany("Groups")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("WEB.Models.Student", b =>
                {
                    b.HasOne("WEB.Models.Group", "Group")
                        .WithMany("Students")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");
                });

            modelBuilder.Entity("WEB.Models.Course", b =>
                {
                    b.Navigation("Groups");
                });

            modelBuilder.Entity("WEB.Models.Group", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
