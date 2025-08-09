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
        public DataTable ExecuteSPDataTable( string spName, Dictionary<string, dynamic>? parameters = null )
        {
            try
            {
                // Using a stored procedure to execute a command
                var connectionString = _context.Database.GetConnectionString();
                using var connection = new SqlConnection( connectionString );
                using var command = new SqlCommand( spName, connection )
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
                foreach ( SqlError error in ex.Errors )
                {
                    MessageBox.Show( $"Error: {error.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                }
                throw;
            }
        }
        
        // Para usar tabla como parametro en un procedimiento almacenado
        public DataTable ExcuteSPDataTable( string spName, string nameParam, string nameTypeTable, DataTable table, Dictionary<string, dynamic>? parameters = null)
        {
            try
            {
                // Using a stored procedure to execute a command
                var connectionString = _context.Database.GetConnectionString();
                using var connection = new SqlConnection(connectionString);
                using var command = new SqlCommand(spName, connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                SqlParameter type = command.Parameters.AddWithValue( nameParam, table );
                type.SqlDbType = SqlDbType.Structured;
                type.TypeName = nameTypeTable;

                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        command.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }
                
                var dataTable = new DataTable();
                connection.Open();
                using var reader = command.ExecuteReader();
                dataTable.Load(reader);
                connection.Close();

                return dataTable;
            }
            catch (SqlException ex)
            {
                foreach (SqlError error in ex.Errors)
                {
                    MessageBox.Show($"Error: {error.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);    
                }
                throw;
            }
        }
        public DataTable ExecuteSPDataTableTypeName(string storedProcedure, Dictionary<string, dynamic> parameters = null, Dictionary<string, dynamic> tabletype = null)
        {
            try
            {
                // Using a stored procedure to execute a command
                var connectionString = _context.Database.GetConnectionString();
                using var connection = new SqlConnection(connectionString);
                using var command = new SqlCommand(storedProcedure, connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {

                        command.Parameters.AddWithValue(param.Key, param.Value);
                        
                    }
                    foreach (var tt in tabletype)
                    {

                        SqlParameter type = command.Parameters.AddWithValue(tt.Key, tt.Value);
                        type.TypeName = "dbo.InsumoSolicitud";
                    }
                }
                var dataTable = new DataTable();
                connection.Open();
                using var reader = command.ExecuteReader();
                dataTable.Load(reader);
                connection.Close();
                return dataTable;
            }
            catch (SqlException ex)
            {
                Debug.WriteLine($"Error executing stored procedure {storedProcedure}: {ex.Message}");
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
<<<<<<< HEAD
                Debug.WriteLine($"Error executing view {viewName}: {ex.Message}");
=======
                foreach ( SqlError error in ex.Errors )
                {
                    MessageBox.Show( $"Error: {error.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                }
>>>>>>> 7fd34a7ec829ade1aa3de8eb07023d5e41de465f
                throw;
            }
        }
    }
}
