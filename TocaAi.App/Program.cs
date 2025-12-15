using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TocaAi.App.Infra;
using TocaAi.Repository.Context;

namespace TocaAi.App
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // criação do DbContextOptions
            //var optionsBuilder = new DbContextOptionsBuilder<TocaAiDbContext>();
            //optionsBuilder.UseSqlServer("Server=GUSTAG15\\SQLEXPRESS;Database=TocaAiDB;Trusted_Connection=True;TrustServerCertificate=True;");

            // instância do DbContext
            //using var context = new TocaAiDbContext(optionsBuilder.Options);

            ConfigureDI.ConfigureService();

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}