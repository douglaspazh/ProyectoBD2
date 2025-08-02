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


        public DataTable GetAllProductores()
        {
            // Using a stored procedure to get all productores
            var connectionString = _context.Database.GetConnectionString();
            using var connection = new SqlConnection( connectionString );
            using var command = new SqlCommand( "spGetAllProductores", connection )
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue( "@PageNumber", 1 );
            command.Parameters.AddWithValue( "@PageSize", 25 );

            var dataTable = new DataTable();
            connection.Open();
            using var reader = command.ExecuteReader();
            dataTable.Load(reader);
            connection.Close();

            return dataTable;
        }

        public DataTable GetProductorById( int productorId )
        {
            // Using a stored procedure to get a specific productor by ID
            var connectionString = _context.Database.GetConnectionString();
            using var connection = new SqlConnection( connectionString );
            using var command = new SqlCommand( "spGetProductorByID", connection )
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue( "@ProductorID", productorId );
            var dataTable = new DataTable();
            connection.Open();
            using var reader = command.ExecuteReader();
            dataTable.Load(reader);
            connection.Close();
            return dataTable;
        }

        public DataTable GetByValue( string value )
        {
            // Using a stored procedure to search for productores by value
            var connectionString = _context.Database.GetConnectionString();
            using var connection = new SqlConnection( connectionString );
            using var command = new SqlCommand( "spGetProductorByValue", connection )
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue( "@Value", value );

            var dataTable = new DataTable();
            connection.Open();
            using var reader = command.ExecuteReader();
            dataTable.Load( reader );
            connection.Close();

            return dataTable;
        }

        public DataTable GetByEstado( int estadoId )
        {
            // Using a stored procedure to get productores by estado
            var connectionString = _context.Database.GetConnectionString();
            using var connection = new SqlConnection( connectionString );
            using var command = new SqlCommand( "spGetProductorByEstado", connection )
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue( "@EstadoID", estadoId );
            var dataTable = new DataTable();
            connection.Open();
            using var reader = command.ExecuteReader();
            dataTable.Load( reader );
            connection.Close();

            return dataTable;
        }

        public void AddProductor( Dictionary<string, dynamic> productorData )
        {
            // Extracting values from the dictionary
            var nombre = productorData["Nombre"] as string;
            var apellido = productorData["Apellido"] as string;
            var documento = productorData["Documento"] as string;
            var rtn = productorData["RTN"] as string;
            var direccion = productorData["Direccion"] as string;
            var telefono = productorData["Telefono"] as string;
            var correo = productorData["Correo"] as string;

            // Using a stored procedure to insert the productor
            var connectionString = _context.Database.GetConnectionString();
            using var connection = new SqlConnection( connectionString );
            using var command = new SqlCommand( "spInsertProductor", connection )
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue( "@Nombre", nombre );
            command.Parameters.AddWithValue( "@Apellido", apellido );
            command.Parameters.AddWithValue( "@RTN", rtn );
            command.Parameters.AddWithValue( "@Direccion", direccion );
            command.Parameters.AddWithValue( "@Telefono", telefono );
            command.Parameters.AddWithValue( "@Correo", correo );
            command.Parameters.AddWithValue( "@Documento", documento );

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteProductor( int productorId )
        {
            var connectionString = _context.Database.GetConnectionString();
            using var connection = new SqlConnection( connectionString );
            using var command = new SqlCommand( "spDeleteProductor", connection )
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue( "@ProductorID", productorId );

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void UpdateProductor( Dictionary<string, object> productorData )
        {
            // Extracting values from the dictionary
            var productorId = (int)productorData["ProductorID"];
            var nombre = productorData["Nombre"] as string;
            var apellido = productorData["Apellido"] as string;
            var documento = productorData["Documento"] as string;
            var rtn = productorData["RTN"] as string;
            var telefono = productorData["Telefono"] as string;
            var correo = productorData["Correo"] as string;
            var direccion = productorData["Direccion"] as string;
            var estadoId = (int)productorData["EstadoID"];

            // Using a stored procedure to update the productor
            var connectionString = _context.Database.GetConnectionString();
            using var connection = new SqlConnection(connectionString);
            using var command = new SqlCommand( "spUpdateProductor", connection )
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@ID", productorId);
            command.Parameters.AddWithValue("@Nombre", nombre);
            command.Parameters.AddWithValue("@Apellido", apellido);
            command.Parameters.AddWithValue("@Documento", documento);
            command.Parameters.AddWithValue("@RTN", rtn);
            command.Parameters.AddWithValue("@Telefono", telefono);
            command.Parameters.AddWithValue("@Correo", correo);
            command.Parameters.AddWithValue("@Direccion", direccion);
            command.Parameters.AddWithValue("@EstadoID", estadoId);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public DataTable GetAllEstados()
        {
            // Using a stored procedure to get all estados
            var connectionString = _context.Database.GetConnectionString();
            using var connection = new SqlConnection( connectionString );
            using var command = new SqlCommand( "spGetProductorEstados", connection )
            {
                CommandType = CommandType.StoredProcedure
            };

            var dataTable = new DataTable();
            connection.Open();
            using var reader = command.ExecuteReader();
            dataTable.Load(reader);
            connection.Close();

            return dataTable;
        }
    }
}
