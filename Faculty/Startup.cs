using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Faculty.DAL.Repositories;
using Faculty.DAL.EF;
using Faculty.DAL.Interfaces;
using Faculty.DAL.Entities;
using Faculty.BLL.Services;
using Faculty.BLL.Interfaces;
using Faculty.BLL.DTO;

namespace Faculty.WEB
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public IConfiguration dbConnectionBuilder;

        public void ConfigureServices(IServiceCollection services)
        {
            dbConnectionBuilder = new ConfigurationBuilder().AddJsonFile("dbsettings.json").Build();
            string dbConnection = dbConnectionBuilder.GetConnectionString("DefaultConnection");
            services.AddDbContext<AppContext>(options => options.UseSqlServer(dbConnection));

            services.AddTransient<IFacultyRepository<Course>, FacultyRepository<Course>>();
            services.AddTransient<IFacultyRepository<Group>, FacultyRepository<Group>>();
            services.AddTransient<IFacultyRepository<Student>, FacultyRepository<Student>>();
            services.AddTransient<IFacultyServices<CourseDTO>, CoursesServices>();
            services.AddTransient<IFacultyServices<GroupDTO>, GroupsServices>();
            services.AddTransient<IFacultyServices<StudentDTO>, StudentsServices>();

            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStatusCodePages();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
