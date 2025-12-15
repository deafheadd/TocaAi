using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TocaAi.Domain.ValueObjects;

namespace TocaAi.Repository.Mapping.Extensions
{
    public static class AddressMappingExtensions
    {
        // método que padroniza o mapeamento de Address em qualquer entidade
        public static void ConfigureAddress<T>(this OwnedNavigationBuilder<T, Address> builder) 
            where T : class
        {
            builder.Property(a => a.Street)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(a => a.Number)
                .IsRequired()
                .HasMaxLength(10);

            builder.Property(a => a.Neighborhood)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(a => a.City)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(a => a.State)
                .IsRequired()
                .HasMaxLength(2);

            builder.Property(a => a.PostalCode)
                .IsRequired()
                .HasMaxLength(8);
        }
    }
}
