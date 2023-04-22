using s7_01.Api.DataAccess.Models;

namespace s7_01.Api.Contracts.Repositories
{
    public interface IVacunaRepository
    {
        Task<IEnumerable<Vacuna>> GetVacunasByHistoriaClinicaIdAsync(int historiaClinicaId);
    }
}
