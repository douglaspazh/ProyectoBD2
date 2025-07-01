using Microsoft.Extensions.Configuration;
using System.IO;

namespace ProyectoBD2.Config
{
    public static class AppConfig
    {
        private static IConfigurationRoot _configuration;
        
        static AppConfig()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            _configuration = builder.Build();
        }
        
        public static string GetConnectionString(string name = "DefaultConnection")
        {
            return _configuration.GetConnectionString(name);
        }
        
        public static string GetSetting(string key)
        {
            return _configuration[key];
        }
    }
}