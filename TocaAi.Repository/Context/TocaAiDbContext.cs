using Microsoft.EntityFrameworkCore;
using TocaAi.Domain.Entities;

namespace TocaAi.Repository.Context
{
    public class TocaAiDbContext : DbContext
    {
        public TocaAiDbContext(DbContextOptions<TocaAiDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Rental> Rentals { get; set; }
    }
}
