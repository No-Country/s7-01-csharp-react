using Microsoft.EntityFrameworkCore;
using s7_01.Api.Common.DTOs.AutorizacionDTOs;
using s7_01.Api.Contracts.Repositories;
using s7_01.Api.DataAccess;
using s7_01.Api.DataAccess.Models;

namespace s7_01.Api.Repositories
{
    public class HistoriaClinicaRepository : GenericRepository<HistoriaClinica> , IHistoriaClinicaRepository
    {
        public HistoriaClinicaRepository(VeterinariaContext context) : base(context)
        {

        }

        public async Task<HistoriaClinica> GetHistoriaClinicaByMascotaId(int mascotaId)
        {
            return await _context.Set<HistoriaClinica>()
                                 .SingleOrDefaultAsync(h => h.MascotaId == mascotaId);
        }
      
    }
}
