using s7_01.Api.DataAccess.Models;

namespace s7_01.Api.Contracts.Repositories
{
    public interface IHistoriaClinicaRepository
    {
        Task<HistoriaClinica>GetHistoriaClinicaByMascotaId (int mascotaId);
           
    }
}
