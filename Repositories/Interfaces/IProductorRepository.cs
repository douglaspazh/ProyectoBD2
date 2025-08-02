using ProyectoBD2.Models;
using System.Data;

namespace ProyectoBD2.Repositories.Interfaces
{
    public interface IProductorRepository
    {
        void AddProductor( Dictionary<string, dynamic> productorData );
        void UpdateProductor( Dictionary<string, dynamic> productorData );
        void DeleteProductor( int productorId );

        DataTable GetAllProductores();
        DataTable GetProductorById( int productorId );
        DataTable GetByValue( string value );
        DataTable GetByEstado( int estadoId );
        DataTable GetAllEstados();
    }
}
