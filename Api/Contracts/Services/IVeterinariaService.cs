using s7_01.Api.Common.DTO;
using s7_01.Api.Common.DTOs.VeterinariaDTOs;

namespace s7_01.Api.Contracts.Services
{
    public interface IVeterinariaService
    {      
        Task<ResponseDTO> GetAllVeterinariasAsync();
        Task<ResponseDTO> GetVeterinariaByIdAsync(int id);
        Task<ResponseDTO> AddVeterinariaAsync(VeterinariaDTO veterinariaDTO);
        Task<ResponseDTO> UpdateVeterinariaAsync(int id, VeterinariaDTO veterinariaDTO);
        Task<ResponseDTO> DeleteVeterinariaAsync(int id);
        Task<ResponseDTO> GetProductosByVeterinariaIdAsync(int id);
        Task<ResponseDTO> GetServiciosByVeterinariaIdAsync(int id);
    }
}
