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

        public async Task<IEnumerable<Veterinaria>> GetAllVetAsync()
        {
            return await _context.Set<Veterinaria>()
                .Include(v => v.Direccion)
                .ToListAsync();
        }
                

        public async Task<Veterinaria> GetVetByIdAsync(int id)
        {
            return await _context.Set<Veterinaria>()
                      .Include(v => v.Direccion)
                      .FirstOrDefaultAsync(v => v.Id == id);
        }
    }
}