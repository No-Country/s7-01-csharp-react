using s7_01.Api.DataAccess.Models;

namespace s7_01.Api.Contracts.Repositories
{
    public interface IServicioRepository
    {
        Task<IEnumerable<Servicio>> GetServiciosByVeterinariaIdAsync(int id);
    }
}
