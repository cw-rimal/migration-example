using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using studentMigration.Models;

namespace migration
{

    public class StudentContextFactory : IDesignTimeDbContextFactory<StudentContext>
    {
        public StudentContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<StudentContext>();
            optionsBuilder.UseMySql("Server=localhost;Database=test;User=root;Password=admin;", MySqlServerVersion.LatestSupportedServerVersion, 
                assembly => assembly.MigrationsAssembly(typeof(StudentContext).Assembly.FullName));

            return new StudentContext(optionsBuilder.Options);
        }
    }
}