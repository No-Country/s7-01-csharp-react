using s7_01.Api.Common.DTO;
using s7_01.Api.Common.DTOs.VeterinariaDTOs;

namespace s7_01.Api.Contracts.Services
{
    public interface IVeterinariaService
    {
        Task<ResponseDTO> AddVeterinariaAsync(VeterinariaDTO veterinariaDTO);
    }
}
