using Microsoft.Extensions.DependencyInjection;
using TocaAi.App.Infra;
using TocaAi.App.Pages;

namespace TocaAi.App
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // configuração de serviços
            var serviceProvider = ConfigureDI.ConfigureService();

            var loginForm = serviceProvider.GetRequiredService<LoginForm>();

            Application.Run(loginForm);
        }
    }
}