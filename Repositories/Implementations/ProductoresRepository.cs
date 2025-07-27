using ProyectoBD2.Repositories.Interfaces;
using ProyectoBD2.Models;
using ProyectoBD2.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace ProyectoBD2.Repositories.Implementations
{
    public class ProductoresRepository : IProductorRepository
    {
        private readonly AppDbContext _context;
        public ProductoresRepository()
        {
            _context = new AppDbContext();
        }

        public IEnumerable<ProductorDto> GetAllProductores()
        {
            return _context.ProductoresDto
                .FromSqlRaw( "EXEC dbo.spGetAllProductores" )
                .ToList();
        }

        public IEnumerable<ProductorDto> GetByValue( string value )
        {
            return _context.ProductoresDto
                .FromSql( $"EXEC dbo.spGetProductorByValue @Value = {value}" )
                .ToList();
        }

        public IEnumerable<ProductorDto> GetByEstado( int estadoId )
        {
            return _context.ProductoresDto
                .FromSql( $"EXEC dbo.spGetProductorByEstado @EstadoID={estadoId}" )
                .ToList();
        }

        public void AddProductor( Productor productor )
        {
            _context.Database.ExecuteSqlInterpolated(
                $"EXEC dbo.spInsertProductor @Nombre={productor.Nombre}, @Telefono={productor.Telefono}, @Correo={productor.Correo}, @EstadoID={productor.EstadoID}" 
            );
        }

        public void DeleteProductor( int productorId )
        {
            var productor = _context.Productores.Find( productorId );
            if ( productor != null )
            {
                _context.Database.ExecuteSqlInterpolated(
                    $"EXEC dbo.spDeleteProductor @ID={productorId}"
                );
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

                _context.Database.ExecuteSqlInterpolated(
                    $"EXEC dbo.spUpdateProductor @ID={productor.ProductorID}, @Nombre={productor.Nombre}, @Telefono={productor.Telefono}, @Correo={productor.Correo}, @EstadoID={productor.EstadoID}"
                );
            }
            else
            {
                throw new KeyNotFoundException( $"Productor with ID {productor.ProductorID} not found." );
            }
        }

        public IEnumerable<Estado> GetAllEstados()
        {
            return _context.Estados
                .FromSqlRaw( "EXEC dbo.spGetAllEstados" )
                .ToList();
        }
    }
}
