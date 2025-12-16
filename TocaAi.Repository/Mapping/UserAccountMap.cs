using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TocaAi.Domain.Entities;

namespace TocaAi.Repository.Mapping
{
    public class UserAccountMap : IEntityTypeConfiguration<UserAccount>
    {
        public void Configure(EntityTypeBuilder<UserAccount> builder)
        {
            builder.ToTable("UserAccounts");

            builder.Property(u => u.Username)
                .IsRequired()
                .HasMaxLength(30);

            builder.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(u => u.PasswordHash)
                .IsRequired();

            builder.Property(u => u.Role)
                .IsRequired();

            builder.Property(u => u.IsActive)
                .IsRequired();

            // relacionamento 1 - 1
            builder.HasOne(u => u.Person)
                .WithOne()
                .HasForeignKey<Person>(p => p.UserAccountId)
                .OnDelete(DeleteBehavior.Cascade);

            // relacionamento 1 - N
            builder.HasMany(u => u.Rentals)
                .WithOne(r => r.UserAccount)
                .HasForeignKey(r => r.UserAccountId)
                .OnDelete(DeleteBehavior.Restrict);

            // relacionamento 1 - N
            builder.HasMany(u => u.EquipmentOwned)
                .WithOne(e => e.Owner)
                .HasForeignKey(e => e.OwnerId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
