using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TocaAi.Domain.Entities;

namespace TocaAi.Repository.Mapping
{
    public class EquipmentMap : IEntityTypeConfiguration<Equipment>
    {
        public void Configure(EntityTypeBuilder<Equipment> builder)
        {
            builder.ToTable("Equipment");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.Type)
                .IsRequired();

            builder.Property(e => e.Brand)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.Model)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.SerialNumber)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(300);

            builder.Property(e => e.DailyRate)
                .IsRequired()
                .HasPrecision(18, 2);

            builder.Property(e => e.AcquisitionDate)
                .IsRequired();

            builder.Property(e => e.ConservationStatus)
                .IsRequired();

            builder.Property(e => e.IsAvailable)
                .IsRequired();
        }
    }
}
