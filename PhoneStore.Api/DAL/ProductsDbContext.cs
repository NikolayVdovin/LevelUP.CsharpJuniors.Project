using Microsoft.EntityFrameworkCore;
using PhoneStore.Api.DAL.Configurations;
using PhoneStore.Api.DAL.Entities;

namespace PhoneStore.Api.DAL
{
    public sealed class ProductsDbContext : DbContext
    {
        public DbSet<ProductEntity>? Products { get; set; }

        public ProductsDbContext(DbContextOptions<ProductsDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductEntityConfiguration());
        }
    }
}
