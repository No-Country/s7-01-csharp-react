using s7_01.Api.DataAccess.Models;
using s7_01.Api.DataAccess;
using s7_01.Api.Contracts.Repositories;
using Microsoft.EntityFrameworkCore;

namespace s7_01.Api.Repositories
{
    public class PropietarioRepository : GenericRepository<Propietario>, IPropietarioRepository
    {
        public PropietarioRepository(VeterinariaContext _context) : base(_context)
        {

        }


        public async Task<IEnumerable<Mascota>> GetMascotasByPropietarioIdAsync(int propietarioId)
        {
            var mascotas = await _context.Set<MascotaPropietario>()
                                        .Include(mp => mp.Mascota)
                                        .Where(mp => mp.PropietarioId == propietarioId)
                                        .Select(mp => mp.Mascota)
                                        .ToListAsync();
            return mascotas;
        }

    }
}
