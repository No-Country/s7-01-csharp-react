using s7_01.Api.DataAccess.Models;
using s7_01.Api.DataAccess;
using Microsoft.EntityFrameworkCore;
using s7_01.Api.Contracts.Repositories;

namespace s7_01.Api.Repositories
{
    public class ServicioRepository : GenericRepository<Servicio>, IServicioRepository
    {
        public ServicioRepository(VeterinariaContext _context) : base(_context)
        {

        }

        public async Task<IEnumerable<Servicio>> GetServiciosByVeterinariaIdAsync(int id)
        {
            var servicios = await _context.Set<Servicio>().Where(p => p.VeterinariaId == id).ToListAsync();

            return servicios;
        }
    }
}
