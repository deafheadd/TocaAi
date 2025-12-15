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
            var services = new ServiceCollection();
            return services.BuildServiceProvider();
        }
    }
}
