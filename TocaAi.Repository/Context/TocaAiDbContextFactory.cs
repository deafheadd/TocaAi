using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace TocaAi.Repository.Context
{
    public class TocaAiDbContextFactory : IDesignTimeDbContextFactory<TocaAiDbContext>
    {
        public TocaAiDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TocaAiDbContext>();

            optionsBuilder.UseSqlServer("Server=GUSTAG15\\SQLEXPRESS;Database=TocaAiDB;User Id=gustavo;Password=1875;TrustServerCertificate=True;");

            return new TocaAiDbContext(optionsBuilder.Options);
        }
    }
}
