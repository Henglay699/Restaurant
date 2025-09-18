using Microsoft.EntityFrameworkCore;
using Restaurant.Domain.Entity;

namespace Restaurant.Domain
{
    public class RestaurantDbContext : DbContext
    {
        public RestaurantDbContext()
        {
            
        }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=RestaurantDb;Trusted_Connection=True;MultipleActiveResultSets=true; TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }   
    }
}