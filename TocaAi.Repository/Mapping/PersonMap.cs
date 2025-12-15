using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TocaAi.Domain.Entities;
using TocaAi.Repository.Mapping.Extensions;

namespace TocaAi.Repository.Mapping
{
    public class PersonMap : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("Person");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd();

            builder.Property(p => p.FullName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.DocumentNumber)
                .IsRequired()
                .HasMaxLength(11);

            builder.Property(p => p.PhoneNumber)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(p => p.RegisterDate)
                .IsRequired();

            builder.OwnsOne(p => p.Address, a =>
            {
                a.ConfigureAddress();
            });
        }
    }
}
