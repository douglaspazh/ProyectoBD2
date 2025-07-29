using ProyectoBD2.Models;

namespace ProyectoBD2.Repositories.Interfaces
{
    public interface IFincaRepository
    {
        void AddFinca(Finca finca);
        void UpdateFinca(Finca fincaId);
        void DeleteFinca(int fincaId);
        IEnumerable<Finca> GetAllFincas();
        IEnumerable<Finca> GetByValue(string value);
        IEnumerable<Finca> GetByProductorId(int productorId);
    }
}
