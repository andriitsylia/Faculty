using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using Faculty.DAL.EF;

namespace Faculty.DAL.Configurations
{
    public static class MigrationManager
    {
        public static IHost MigrateDatabase(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                using (var facultyContext = scope.ServiceProvider.GetRequiredService<FacultyContext>())
                {
                    try
                    {
                        facultyContext.Database.Migrate();
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
            return host;
        }
    }
}
