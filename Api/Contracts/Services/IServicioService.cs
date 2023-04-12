using s7_01.Api.Common.DTO;
using s7_01.Api.Common.DTOs.ServicioDTOs;
using s7_01.Api.Contracts.Repositories;
using s7_01.Api.DataAccess.Models;

namespace s7_01.Api.Contracts.Services
{
    public interface IServicioService
    {
        Task<ResponseDTO> GetAllServiciosAsync();
        Task<ResponseDTO> GetServicioByIdAsync(int id);
        Task<ResponseDTO> AddServicioAsync(ServicioDTO servicioDTO);
        Task<ResponseDTO> UpdateServicioAsync(int id, ServicioDTO servicioDTO);
        Task<ResponseDTO> DeleteServicioAsync(int id);
    }
}
