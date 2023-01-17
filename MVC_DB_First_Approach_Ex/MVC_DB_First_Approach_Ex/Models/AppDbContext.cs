using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;

namespace MVC_DB_First_Approach_Ex.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Employee>Employees{get;set;}
            

            

        



    }
}
