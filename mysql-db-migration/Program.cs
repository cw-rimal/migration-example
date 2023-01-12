using Microsoft.EntityFrameworkCore;
using studentMigration.Models;

namespace migration
{
    class Program
    {
        public static void Main(string[] args)
        {
            StudentContextFactory p = new StudentContextFactory();

            using (StudentContext sc = p.CreateDbContext(null))
            {
                sc.Database.Migrate();
                sc.SaveChanges();
            }
        }
    }
}