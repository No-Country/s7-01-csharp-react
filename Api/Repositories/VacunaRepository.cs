using Microsoft.EntityFrameworkCore;
using s7_01.Api.Contracts.Repositories;
using s7_01.Api.DataAccess;
using s7_01.Api.DataAccess.Models;

namespace s7_01.Api.Repositories;

public class VacunaRepository : GenericRepository<Vacuna>, IVacunaRepository
{
    public VacunaRepository(VeterinariaContext context) : base(context)
    {

    }

    public async Task<IEnumerable<Vacuna>> GetVacunasByHistoriaClinicaIdAsync(int historiaClinicaId)
    {
        return await _context.Set<Vacuna>()
                             .Where(a => a.HistoriaClinicaId == historiaClinicaId)
                             .ToListAsync();
    }
}
