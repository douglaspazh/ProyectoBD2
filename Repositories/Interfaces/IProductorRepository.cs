using ProyectoBD2.Models;

namespace ProyectoBD2.Repositories.Interfaces
{
    public interface IProductorRepository
    {
        void AddProductor(Productor productor);
        void UpdateProductor(Productor productor);
        void DeleteProductor(int productorId);

        IEnumerable<Productor> GetAllProductores();
        IEnumerable<Productor> GetByValue(string value);
        // IEnumerable<Productor> GetByEstado(string estado); // Uncomment if needed

        

    }
}
