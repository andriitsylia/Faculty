using Faculty.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using Faculty.Services.Repositories;

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
            services.AddDbContext<Data.AppContext>(options => options.UseSqlServer(dbConnection));

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
