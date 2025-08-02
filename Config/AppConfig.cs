using Microsoft.Extensions.Configuration;
using System.IO;

namespace ProyectoBD2.Config
{
    public static class AppConfig
    {
        private static readonly IConfigurationRoot _configuration;

        static AppConfig()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath( Directory.GetCurrentDirectory() )
                .AddJsonFile( "appsettings.json", optional: false, reloadOnChange: true );

            _configuration = builder.Build();
        }

        public static string GetConnectionString( string name = "DefaultConnection" )
        {
            var connectionString = _configuration.GetConnectionString( name );
            if ( string.IsNullOrEmpty( connectionString ) )
            {
                throw new InvalidOperationException( $"Connection string '{name}' is not configured." );
            }
            return connectionString;
        }

        public static string GetSetting( string key )
        {
            return _configuration[key] ?? string.Empty;
        }
    }
}