using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace CustomValidation_Example.Models
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        } 

        public DbSet<Student>Students { get; set; }
    }
}
