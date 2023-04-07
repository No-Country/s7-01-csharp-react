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

        public IEnumerable<Producto> GetProductosByVeterinariaId(int id)
        {
            var productos = _context.Set<Producto>().Where(p => p.VeterinariaId == id).ToList();
            
            return productos;
        }

        public IEnumerable<Servicio> GetServiciosByVeterinariaId(int id)
        {            
            var servicios = _context.Set<Servicio>().Where(p => p.VeterinariaId == id).ToList();

            return servicios;
        }
    }
}
