using Microsoft.EntityFrameworkCore;
using s7_01.Api.Contracts.Repositories;
using s7_01.Api.DataAccess;
using s7_01.Api.DataAccess.Models;

namespace s7_01.Api.Repositories
{
    public class TratamientoRepository : GenericRepository<Tratamiento>, ITratamientoRepository
    {
        public TratamientoRepository(VeterinariaContext context) : base(context)
        {
        }

        public async Task<List<Tratamiento>> GetTratamientosByVeterinariaIdAsync(int veterinariaId)
        {
            var tratamiento = await _context.Set<Tratamiento>().Where(t => t.VeterinariaId == veterinariaId).ToListAsync();
            return tratamiento;
        }
    }
}
