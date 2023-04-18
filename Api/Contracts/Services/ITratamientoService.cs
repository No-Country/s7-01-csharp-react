using s7_01.Api.Common;
using s7_01.Api.Common.DTO;
using static s7_01.Api.Common.DTOs.TratamientoDTOs.TratamientoDTOs;

namespace s7_01.Api.Contracts.Services;

public interface ITratamientoService
{
    Task<ResponseDTO> GetAllAsync();
    Task<ResponseDTO> GetByIdAsync(int id);
    Task<ResponseDTO> GetTratamientoByVeterinariaIdAsync(int veterinariId);
    Task<ResponseDTO> AddAsync(TratamientoDTO tratamiento);
    Task<ResponseDTO> UpdateAsync(int id, TratamientoDTO tratamiento);
    Task<ResponseDTO> DeleteAsync(int id);
}
