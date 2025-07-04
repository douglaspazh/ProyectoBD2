using ProyectoBD2.Repositories.Interfaces;
using ProyectoBD2.Models;
using ProyectoBD2.Data;

namespace ProyectoBD2.Repositories.Implementations
{
    public class ProductoresRepository : IProductorRepository
    {
        private readonly AppDbContext _context;
        public ProductoresRepository()
        {
            _context = new AppDbContext();
        }

        public IEnumerable<Productor> GetAllProductores()
        {
            return _context.Productores.ToList();
        }

        public IEnumerable<Productor> GetByValue( string value )
        {
            return _context.Productores
                          .Where( p => p.Nombre.Contains( value ) || p.Email.Contains( value ) )
                          .ToList();
        }

        public void AddProductor( Productor productor )
        {
            _context.Productores.Add( productor );
            _context.SaveChanges();
        }

        public void DeleteProductor( int productorId )
        {
            var productor = _context.Productores.Find( productorId );
            if ( productor != null )
            {
                _context.Productores.Remove( productor );
                _context.SaveChanges();
            }
            else
            {
                throw new KeyNotFoundException( $"Productor with ID {productorId} not found." );
            }
        }

        public void UpdateProductor( Productor productor )
        {
            var existingProductor = _context.Productores.Find( productor.ProductorID );
            if ( existingProductor != null )
            {
                _context.ChangeTracker.Clear();
                _context.Productores.Update( productor );
                _context.SaveChanges();
            }
            else
            {
                throw new KeyNotFoundException( $"Productor with ID {productor.ProductorID} not found." );
            }
        }
    }
}
