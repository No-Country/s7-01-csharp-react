using s7_01.Api.DataAccess.Models;

namespace s7_01.Api.Contracts.Repositories
{
    public interface IPropietarioRepository
    {
        Task<IEnumerable<Mascota>> GetMascotasByPropietarioIdAsync(int propietarioId);

        Task<IEnumerable<Propietario>> GetAllPropAsync();

        Task<Propietario> GetPropByIdAsync(int id);
    }
}
