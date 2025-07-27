using ProyectoBD2.Models;

namespace ProyectoBD2.Repositories.Interfaces
{
    public interface IProductorRepository
    {
        void AddProductor( Productor productor );
        void UpdateProductor( Productor productor );
        void DeleteProductor( int productorId );

        IEnumerable<ProductorDto> GetAllProductores();
        IEnumerable<ProductorDto> GetByValue( string value );
        IEnumerable<ProductorDto> GetByEstado( int estadoId );
        IEnumerable<Estado> GetAllEstados();
    }
}
