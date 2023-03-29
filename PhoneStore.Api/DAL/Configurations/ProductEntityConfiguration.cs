using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PhoneStore.Api.DAL.Entities;

namespace PhoneStore.Api.DAL.Configurations
{
    public class ProductEntityConfiguration : IEntityTypeConfiguration<ProductEntity>
    {
        public void Configure(EntityTypeBuilder<ProductEntity> builder)
        {

            builder.ToTable("Products");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Name)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(300);

            builder.Property(e => e.Description)
                .HasColumnType("nvarchar")
                .HasMaxLength(600);

            builder.Property(e => e.CategoryId)
                .IsRequired()
                .HasColumnType("uniqueidentifier");

            builder.HasIndex(e => e.CategoryId);
        }
    }
}
