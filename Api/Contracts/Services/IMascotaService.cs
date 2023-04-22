using s7_01.Api.Common.DTO;
using s7_01.Api.Common.DTOs.MascotaDTOs;

namespace s7_01.Api.Contracts.Services
{
    public interface IMascotaService
    {
        Task<ResponseDTO> GetAllMascotasAsync();
        Task<ResponseDTO> GetAllMascotasPropietaryAsync(int id);
        Task<ResponseDTO> GetMascotaByIdAsync(int id);
        Task<ResponseDTO> AddMascotaAsync(int id, MascotaDTO mascota);
        Task<ResponseDTO> UpdateMascotaAsync(int id, MascotaDTO mascota);
        Task<ResponseDTO> AddRangeAsync(int id, IEnumerable<MascotaDTO> mascotaDTOs);
    }
}
