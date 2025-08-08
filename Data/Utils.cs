using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Diagnostics;

namespace ProyectoBD2.Data
{
    public class Utils
    {
        private readonly AppDbContext _context = new();

        // Constructor
        public Utils()
        {
            // Initialize the context if needed
        }

        // Method to execute a stored procedure and return a DataTable
        public DataTable ExecuteSPDataTable( string storedProcedure, Dictionary<string, dynamic> parameters = null )
        {
            try
            {
                // Using a stored procedure to execute a command
                var connectionString = _context.Database.GetConnectionString();
                using var connection = new SqlConnection( connectionString );
                using var command = new SqlCommand( storedProcedure, connection )
                {
                    CommandType = CommandType.StoredProcedure
                };
                if ( parameters != null )
                {
                    foreach ( var param in parameters )
                    {
                        command.Parameters.AddWithValue( param.Key, param.Value );
                    }
                }
                var dataTable = new DataTable();
                connection.Open();
                using var reader = command.ExecuteReader();
                dataTable.Load( reader );
                connection.Close();
                return dataTable;
            }
            catch ( SqlException ex )
            {
                Debug.WriteLine( $"Error executing stored procedure {storedProcedure}: {ex.Message}" );
                throw;
            }
        }

        public DataTable ExecuteViewDataTable( string viewName )
        {
            try
            {
                // Using a view to execute a command
                var connectionString = _context.Database.GetConnectionString();
                using var connection = new SqlConnection( connectionString );
                using var command = new SqlCommand( $"SELECT * FROM {viewName}", connection )
                {
                    CommandType = CommandType.Text
                };
                
                var dataTable = new DataTable();
                connection.Open();
                using var reader = command.ExecuteReader();
                dataTable.Load( reader );
                connection.Close();
                return dataTable;
            }
            catch ( SqlException ex )
            {
                Debug.WriteLine( $"Error executing view {viewName}: {ex.Message}" );
                throw;
            }
        }
    }
}
