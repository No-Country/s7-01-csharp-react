using s7_01.Api.Common.DTOs.AutorizacionDTOs;
using s7_01.Api.DataAccess.Models;

namespace s7_01.Api.Contracts.Repositories
{
    public interface IAutorizacionRepository
    {
        Task<IEnumerable<Autorizacion>> GetAutorizacionesByMascotaIdAsync(int mascotaId);

        Task<IEnumerable<Autorizacion>> GetAutorizacionesByVeterinariaIdAsync(int veterinariaId);

        Task<Autorizacion> GetAutorizacionByMascotaIdAndVeterinariaIdAsync(GetAutorizacionDTO getAutorizacionDTO);

        Task RemoveAutorizacionById(int id);
    }
}
