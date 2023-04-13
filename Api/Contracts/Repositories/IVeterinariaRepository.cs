using Microsoft.EntityFrameworkCore;
using s7_01.Api.DataAccess.Models;

namespace s7_01.Api.Contracts.Repositories
{
    public interface IVeterinariaRepository
    {        
        Task<IEnumerable<Producto>> GetProductosByVeterinariaIdAsync(int id);

        Task<IEnumerable<Servicio>> GetServiciosByVeterinariaIdAsync(int id);
    }
}
