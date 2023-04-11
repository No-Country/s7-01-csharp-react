using Microsoft.EntityFrameworkCore;
using s7_01.Api.DataAccess.Models;

namespace s7_01.Api.Contracts.Repositories
{
    public interface IVeterinariaRepository
    {
        IEnumerable<Producto> GetProductosByVeterinariaId(int id);

        IEnumerable<Servicio> GetServiciosByVeterinariaId(int id);        
    }
}
