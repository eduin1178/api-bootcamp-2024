using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Infrastructure.Configurtation
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Productos");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("IdProducto")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.Name)
                .HasColumnName("Nombre")
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}
