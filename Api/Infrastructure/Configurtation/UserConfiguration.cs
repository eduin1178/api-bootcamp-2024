using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Infrastructure.Configurtation
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(e => e.Id);

            builder.ToTable("Usuarios");

            builder.Property(e => e.Id)
                .HasColumnName("IdUsuario")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(x=>x.Email)
                .HasMaxLength(100)
                .IsRequired();

            builder.HasIndex(e => e.Email)
                .IsUnique();
        }
    }
}
