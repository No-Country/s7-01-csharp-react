using Microsoft.EntityFrameworkCore;
using s7_01.Api.Contracts.Repositories;
using s7_01.Api.DataAccess;
using s7_01.Api.DataAccess.Models;

namespace s7_01.Api.Repositories
{
    public class ProductoRepository : GenericRepository<Producto>, IProductoRepository
    {
        public ProductoRepository(VeterinariaContext _context) : base(_context)
        {

        }

        public async Task<IEnumerable<Producto>> GetProductosByVeterinariaIdAsync(int id)
        {
            var productos = await _context.Set<Producto>().Where(p => p.VeterinariaId == id).ToListAsync();

            return productos;
        }
    }
}
