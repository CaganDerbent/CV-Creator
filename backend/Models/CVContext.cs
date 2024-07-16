using Microsoft.EntityFrameworkCore;
namespace myapp.Models
{
    public class CVContext : DbContext
    {
        // DbContext Creation

        // add-migration NAME
        // update-database
        public DbSet<CVData> CV { get; set; } // CV = Model

        public CVContext(DbContextOptions options) : base(options)
        {

        }
    }
}
