using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using BJMicro_Accounts_Refactor.Core.Services;
using BJMicro_Accounts_Refactor.Core.Services.Interfaces;
using BJMicro_Accounts_Refactor.DataAccess.Repositories;
using BJMicro_Accounts_Refactor.DataAccess.Repositories.IRepository;
using BJMicro_Accounts_Refactor.DataAccess.Data;
using BJMicro_Accounts_Refactor.Forms; 

namespace BJMicro_Accounts_Refactor
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Set compatible text rendering before the form is created
            Application.SetCompatibleTextRenderingDefault(false);

            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();

            // 1. Register DbContext
            services.AddDbContext<MicroAccountsContext>(options =>
            {
                options.UseSqlServer("YourConnectionStringHere");
            });

            // 2. Register Repository and Services
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IDailyRateService, DailyRateService>();

            services.AddScoped<DailyRates>();

            var serviceProvider = services.BuildServiceProvider();

            var dailyRateService = serviceProvider.GetRequiredService<IDailyRateService>();

            var dailyRatesForm = new DailyRates("harsh", 0, 0, dailyRateService);
 
            Application.Run(dailyRatesForm);
        }
    }
}
