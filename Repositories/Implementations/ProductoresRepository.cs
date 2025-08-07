using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ProyectoBD2.Data;
using ProyectoBD2.Models;
using ProyectoBD2.Repositories.Interfaces;
using System.Data;
using System.Diagnostics;

namespace ProyectoBD2.Repositories.Implementations
{
    public class ProductoresRepository: IProductorRepository
    {
        private readonly AppDbContext _context;

        // Constructor
        public ProductoresRepository()
        {
            _context = new AppDbContext();
        }

        // Method to execute a stored procedure and return a DataTable
        public DataTable ExecuteSPDataTable( string storedProcedure, Dictionary<string, dynamic> parameters = null)
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

        public DataTable GetAllProductores()
        {
            Dictionary<string, dynamic> parameters = new()
            {
                { "@PageNumber", 1 },
                { "@PageSize", 25 }
            };
            return ExecuteSPDataTable( "spGetAllProductores", parameters );
        }

        public DataTable GetProductorById( int productorId )
        {
            Dictionary<string, dynamic> parameters = new()
            {
                { "@ID", productorId }
            };
            return ExecuteSPDataTable( "spGetProductorByID", parameters );
        }

        public DataTable GetByValue( string value )
        {
            Dictionary<string, dynamic> parameters = new()
            {
                { "@Value", value }
            };
            return ExecuteSPDataTable( "spGetProductorByValue", parameters );
        }

        public DataTable GetByEstado( int estadoId )
        {
            Dictionary<string, object> parameters = new()
            {
                { "@EstadoID", estadoId }
            };
            return ExecuteSPDataTable( "spGetProductorByEstado", parameters );
        }

        public DataTable AddProductor( Dictionary<string, dynamic> productorData )
        {
            // Extracting values from the dictionary
            var nombre = productorData["Nombre"] as string;
            var apellido = productorData["Apellido"] as string;
            var documento = productorData["Documento"] as string;
            var rtn = productorData["RTN"] as string;
            var telefono = productorData["Telefono"] as string;
            var correo = productorData["Correo"] as string;

            // Using a stored procedure to insert the productor
            Dictionary<string, dynamic> parameters = new()
            {
                { "@Nombre", nombre },
                { "@Apellido", apellido },
                { "@Documento", documento },
                { "@RTN", rtn },
                { "@Telefono", telefono },
                { "@Correo", correo }
            };
            return ExecuteSPDataTable( "spAddProductor", parameters );
        }

        public DataTable DeleteProductor( int productorId )
        {
           Dictionary<string, object> parameters = new()
            {
                { "@ID", productorId }
            };
            return ExecuteSPDataTable( "spDeleteProductor", parameters );
        }

        public DataTable UpdateProductor( Dictionary<string, object> productorData )
        {
            // Extracting values from the dictionary
            var productorId = (int)productorData["ProductorID"];
            var nombre = productorData["Nombre"] as string;
            var apellido = productorData["Apellido"] as string;
            var documento = productorData["Documento"] as string;
            var rtn = productorData["RTN"] as string;
            var telefono = productorData["Telefono"] as string;
            var correo = productorData["Correo"] as string;
            var estadoId = (int)productorData["EstadoID"];

            // Using a stored procedure to update the productor
            Dictionary<string, object> parameters = new()
            {
                { "@ID", productorId },
                { "@Nombre", nombre },
                { "@Apellido", apellido },
                { "@Documento", documento },
                { "@RTN", rtn },
                { "@Telefono", telefono },
                { "@Correo", correo },
                { "@EstadoID", estadoId }
            };

            return ExecuteSPDataTable( "spUpdateProductor", parameters );
        }

        public DataTable GetAllEstados()
        {
            // Using a stored procedure to get all estados
            return ExecuteSPDataTable( "spGetProductorEstados" );
        }
    }
}
