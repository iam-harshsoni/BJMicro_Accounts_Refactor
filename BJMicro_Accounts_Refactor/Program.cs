using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using BJMicro_Accounts_Refactor.Core.Services;
using BJMicro_Accounts_Refactor.Core.Services.Interfaces;
using BJMicro_Accounts_Refactor.DataAccess.Repositories;
using BJMicro_Accounts_Refactor.DataAccess.Repositories.IRepository;
using BJMicro_Accounts_Refactor.DataAccess.Data;
using BJMicro_Accounts_Refactor.Forms;
using Microsoft.Extensions.Configuration;

namespace BJMicro_Accounts_Refactor
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();

            ConfigureServices(services);

            var serviceProvider = services.BuildServiceProvider();

            using (var scope = serviceProvider.CreateScope())
            {
                var httpClient = scope.ServiceProvider.GetRequiredService<HttpClient>();
                var mainDashboard = new MainDashboard("Harsh", httpClient);
                Application.Run(mainDashboard);
            }
        }
        private static void ConfigureServices(IServiceCollection services)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false)
                .Build();

            services.AddSingleton<IConfiguration>(configuration);

            // Configure HttpClient
            services.AddHttpClient("ApiClient", client =>
            {
                client.BaseAddress = new Uri(AppConfig.ApiBaseUrl);
                client.DefaultRequestHeaders.Add("Accept", "application/json");
            });


            //services.AddDbContext<MicroAccountsContext>(options =>
            //    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")),
            //    ServiceLifetime.Scoped);

            // Register Repositories and Services
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddSingleton<IDailyRateService, DailyRateService>();

            // Forms
            services.AddScoped<MainDashboard>();
            services.AddScoped<DailyGoldRates>();

            // (Optional) Logging, EmailServices, other utilities
        }

    }
}
