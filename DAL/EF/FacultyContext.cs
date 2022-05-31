using Faculty.DAL.Configurations;
using Microsoft.EntityFrameworkCore;
using Faculty.DAL.Entities;

namespace Faculty.DAL.EF
{
    public class FacultyContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }

        public FacultyContext(DbContextOptions<FacultyContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new GroupConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
        }
    }
}
