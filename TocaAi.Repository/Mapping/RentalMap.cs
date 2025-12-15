using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TocaAi.Domain.Entities;

namespace TocaAi.Repository.Mapping
{
    public class RentalMap : IEntityTypeConfiguration<Rental>
    {
        public void Configure(EntityTypeBuilder<Rental> builder)
        {
            builder.ToTable("Rental");

            builder.HasKey(r => r.Id);

            builder.Property(r => r.PickupDate)
                .IsRequired();

            builder.Property(r => r.ExpectedReturnDate)
                .IsRequired();

            builder.Property(r => r.DailyRate)
                .IsRequired();

            builder.Property(r => r.RentalStatus)
                .IsRequired();
        }
    }
}
