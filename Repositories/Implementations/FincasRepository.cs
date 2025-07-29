using ProyectoBD2.Repositories.Interfaces;
using ProyectoBD2.Models;
using ProyectoBD2.Data;
using Microsoft.EntityFrameworkCore;

namespace ProyectoBD2.Repositories.Implementations
{
    public class FincasRepository : IFincaRepository
    {
        public IEnumerable<Finca> GetAllFincas()
        {
            using var context = new AppDbContext();
            // Se usará temporalmente LINQ, tiene que ser reemplazado por un procedimiento almacenado.
            return context.Fincas.Include( f => f.Productor )
                          .ToList();
        }

        public IEnumerable<Finca> GetByValue( string value )
        {
            using var context = new AppDbContext();
            // Se usará temporalmente LINQ, tiene que ser reemplazado por un procedimiento almacenado.
            return context.Fincas
                          .Include( f => f.Productor )
                          .Where( f => f.Nombre.Contains( value ) || f.Direccion.Contains( value ) )
                          .ToList();
        }

        public IEnumerable<Finca> GetByProductorId( int productorId )
        {
            using var context = new AppDbContext();
            // Se usará temporalmente LINQ, tiene que ser reemplazado por un procedimiento almacenado.
            return context.Fincas
                          .Where( f => f.ProductorID == productorId )
                          .ToList();
        }

        public void AddFinca( Finca finca )
        {
            using var context = new AppDbContext();
            // Se usará temporalmente LINQ, tiene que ser reemplazado por un procedimiento almacenado.
            context.Fincas.Add( finca );
            context.SaveChanges();
        }

        public void DeleteFinca( int fincaId )
        {
            using var context = new AppDbContext();
            // Se usará temporalmente LINQ, tiene que ser reemplazado por un procedimiento almacenado.
            var finca = context.Fincas.Find( fincaId );
            if ( finca != null )
            {
                context.Fincas.Remove( finca );
                context.SaveChanges();
            }
            else
            {
                throw new KeyNotFoundException( $"Finca with ID {fincaId} not found." );
            }
        }

        public void UpdateFinca( Finca finca )
        {
            var context = new AppDbContext();
            // Se usará temporalmente LINQ, tiene que ser reemplazado por un procedimiento almacenado.
            var existingFinca = context.Fincas.Find( finca.FincaID );
            if ( existingFinca != null )
            {
                context.ChangeTracker.Clear();
                context.Fincas.Update( finca );
                context.SaveChanges();
            }
            else
            {
                throw new KeyNotFoundException( $"Finca with ID {finca.FincaID} not found." );
            }
        }
    }
}
