using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TocaAi.Test
{
    [TestClass]
    public class UnitTestService
    {
        private ServiceCollection? services;

        public ServiceProvider ConfigureServices()
        {
            services = new ServiceCollection();

            // configs de appsettings.json
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false)
                .Build();

            return services.BuildServiceProvider();
        }
    }
}
