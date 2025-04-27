using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace BJMicro_Accounts_Refactor
{
    public class AppConfig
    {
        private static readonly IConfiguration _configuration;
        private static readonly string _apiBaseUrl;

        static AppConfig()
        {
            try
            {
                var basePath = AppDomain.CurrentDomain.BaseDirectory;
                var appsettingsPath = Path.Combine(basePath, "appsettings.json");

                if (!File.Exists(appsettingsPath))
                {
                    throw new FileNotFoundException($"appsettings.json not found at path: {appsettingsPath}");
                }

                _configuration = new ConfigurationBuilder()
                    .SetBasePath(basePath)
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .Build();

                _apiBaseUrl = _configuration.GetSection("ApiSettings:BaseUrl").Value;
                if (string.IsNullOrEmpty(_apiBaseUrl))
                {
                    throw new InvalidOperationException("API Base URL is not configured in appsettings.json. Ensure the 'ApiSettings:BaseUrl' key is defined.");
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Failed to initialize AppConfig: {ex.Message}", ex);
            }
        }

        public static string ApiBaseUrl => _apiBaseUrl;

        public static string GetModuleUrl(string module)
        {
            return $"{ApiBaseUrl}/{module}";
        }
    }

}

