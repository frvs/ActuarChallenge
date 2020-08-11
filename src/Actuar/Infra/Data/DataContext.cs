using Domain.Entities;
using Flunt.Notifications;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Notification>().HasNoKey();
            modelBuilder.Entity<Product>().HasKey(product => new { product.Id });
        }

        public DbSet<Product> Product { get; set; }
    }
}
