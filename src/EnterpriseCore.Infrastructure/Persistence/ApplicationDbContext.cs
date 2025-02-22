using EnterpriseCore.Domain.Entities; // ✅ Ensure correct import
using Microsoft.EntityFrameworkCore;

namespace EnterpriseCore.Infrastructure.Persistence // ✅ Check this is correct
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Add entity configurations here if needed
            base.OnModelCreating(modelBuilder);
        }
    }
}
