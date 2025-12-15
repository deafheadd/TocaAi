using Microsoft.EntityFrameworkCore;
using TocaAi.Domain.Entities;

namespace TocaAi.Repository.Context
{
    public class TocaAiDbContext : DbContext
    {
        public TocaAiDbContext(DbContextOptions<TocaAiDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("Server=GUSTAG15\\SQLEXPRESS;Database=TocaAiDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TocaAiDbContext).Assembly);
        }

        public DbSet<Person> Person { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }
    }
}
