using Microsoft.EntityFrameworkCore;

namespace mvc_Code_first_practice2.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>op):base(op)
        {

        }

        public DbSet<Valid>Validate { get; set; }
    }
}
