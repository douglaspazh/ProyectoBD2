using ProyectoBD2.Repositories.Interfaces;
using ProyectoBD2.Models;
using ProyectoBD2.Data;

namespace ProyectoBD2.Repositories.Implementations
{
    public class ProductoresRepository : IProductorRepository
    {
        public IEnumerable<Productor> GetAllProductores()
        {
            using var context = new AppDbContext();
            return context.Productores.ToList();
        }

        public IEnumerable<Productor> GetByValue( string value )
        {
            using var context = new AppDbContext();
            return context.Productores
                          .Where( p => p.Nombre.Contains( value ) || p.Telefono.Contains( value ) || p.Email.Contains( value ) || p.Estado.Contains( value ))
                          .ToList();
        }

        public void AddProductor( Productor productor )
        {
            using var context = new AppDbContext();
            context.Productores.Add( productor );
            context.SaveChanges();
        }

        public void DeleteProductor( int productorId )
        {
            using var context = new AppDbContext();
            var productor = context.Productores.Find( productorId );
            if ( productor != null )
            {
                context.Productores.Remove( productor );
                context.SaveChanges();
            }
            else
            {
                throw new KeyNotFoundException( $"Productor with ID {productorId} not found." );
            }
        }

        public void UpdateProductor( Productor productor )
        {
            using var context = new AppDbContext();
            var existingProductor = context.Productores.Find( productor.ProductorID );
            if ( existingProductor != null )
            {
                context.ChangeTracker.Clear();
                context.Productores.Update( productor );
                context.SaveChanges();
            }
            else
            {
                throw new KeyNotFoundException( $"Productor with ID {productor.ProductorID} not found." );
            }
        }
    }
}
