using Microsoft.EntityFrameworkCore;

namespace _2_nd_assignment.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure decimal precision for Price
            modelBuilder.Entity<Product>()
                        .Property(p => p.Price)
                        .HasPrecision(18, 2);
        }
    }
}
