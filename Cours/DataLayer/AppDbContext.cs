using Cours.Entity;
using Microsoft.EntityFrameworkCore;

namespace Cours.DataLayer
{
    public class AppDbContext : DbContext
    {
        public DbSet<Learning> Course { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options) { }
    }
}
