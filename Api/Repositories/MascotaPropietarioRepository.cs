using Microsoft.EntityFrameworkCore;
using s7_01.Api.Contracts.Repositories;
using s7_01.Api.DataAccess;
using s7_01.Api.DataAccess.Models;
using System.Linq.Expressions;

namespace s7_01.Api.Repositories
{
    public class MascotaPropietarioRepository : GenericRepository<MascotaPropietario>, IMascotaPropietarioRepository
    {
        public MascotaPropietarioRepository(VeterinariaContext context) : base(context)
        {
            
        }
        public async Task<IEnumerable<MascotaPropietario>> GetAllAsync()
        {
            return await _context.Set<MascotaPropietario>()
                .Include(m => m.Propietario)
                .Include(m => m.Mascota)
                .ToListAsync();
        }
        public async Task<IEnumerable<MascotaPropietario>> FindAsync(Expression<Func<MascotaPropietario, bool>> expression)
        {
            return await _context.Set<MascotaPropietario>().Where(expression).Include(m => m.Mascota).ToListAsync();
        }

       
    }
}
