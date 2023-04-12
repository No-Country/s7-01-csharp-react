using Microsoft.EntityFrameworkCore;
using s7_01.Api.Contracts.Repositories;
using s7_01.Api.DataAccess;
using s7_01.Api.DataAccess.Models;

namespace s7_01.Api.Repositories
{
    public class VeterinariaRepository : GenericRepository<Veterinaria>, IVeterinariaRepository
    {           
        public VeterinariaRepository(VeterinariaContext _context) : base(_context)  
        {
            
        }

        public async Task<IEnumerable<Producto>> GetProductosByVeterinariaIdAsync(int id)
        {
            var productos = await _context.Set<Producto>().Where(p => p.VeterinariaId == id).ToListAsync();

            return productos;
        }

        public async Task<IEnumerable<Servicio>> GetServiciosByVeterinariaIdAsync(int id)
        {
            var servicios = await _context.Set<Servicio>().Where(p => p.VeterinariaId == id).ToListAsync();

            return servicios;
        }
    }
}
