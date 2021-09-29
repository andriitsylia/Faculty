using Faculty.Configurations;
using Faculty.Interfaces;
using Faculty.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Faculty
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

            services.AddTransient<IAllCourses, CourseConfiguration>();
            services.AddTransient<IAllGroups, GroupConfiguration>();
            services.AddTransient<IAllStudents, StudentConfiguration>();
            services.AddTransient<CoursesRepository>();
            services.AddTransient<GroupsRepository>();
            services.AddTransient<StudentsRepository>();


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
