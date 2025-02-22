using EnterpriseCore.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EnterpriseCore.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ✅ Filter to exclude soft-deleted records by default
            modelBuilder.Entity<User>().HasQueryFilter(u => u.DeletedAt == null);
            modelBuilder.Entity<Product>().HasQueryFilter(p => p.DeletedAt == null);
        }
    }
}
