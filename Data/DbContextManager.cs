using Microsoft.Data.SqlClient;
using ProyectoBD2.Config;
using System.Diagnostics;

namespace ProyectoBD2.Data
{
    public static class DbContextManager
    {
        public static SqlConnection GetConnection()
        {
            var connectionString = AppConfig.GetConnectionString();
            return new SqlConnection(connectionString);
        }
        
        public static void OpenConnection()
        {
            var connection = GetConnection();

            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
                Debug.WriteLine("Connection opened successfully.");
            }
        }
        
        public static void CloseConnection()
        {
            var connection = GetConnection();

            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
                Debug.WriteLine("Connection closed successfully.");
            }
        }
    }
}
