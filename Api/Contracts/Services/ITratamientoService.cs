using s7_01.Api.Common;
using s7_01.Api.Common.DTO;
using static s7_01.Api.Common.DTOs.TratamientoDTOs.TratamientoDTOs;

namespace s7_01.Api.Contracts.Services;

public interface ITratamientoService
{
    Task<Common.ResponseDTO> GetAllAsync();
    Task<Common.ResponseDTO> GetByIdAsync(int id);
    Task<Common.ResponseDTO> GetTratamientoByVeterinariaIdAsync(int veterinariId);
    Task<Common.ResponseDTO> AddAsync(TratamientoDTO tratamiento);
    Task<Common.ResponseDTO> UpdateAsync(int id, TratamientoDTO tratamiento);
    Task<Common.ResponseDTO> DeleteAsync(int id);
}
