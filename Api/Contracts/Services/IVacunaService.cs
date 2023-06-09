﻿using s7_01.Api.Common.DTO;
using s7_01.Api.Common.DTOs.VacunaDTOs;
using s7_01.Api.DataAccess.Models;
using static s7_01.Api.Common.DTOs.VacunaDTOs.VacunaDTO;

namespace s7_01.Api.Contracts.Services;

public interface IVacunaService
{
    Task<ResponseDTO> GetAllAsync();
    Task<ResponseDTO> GetByIdAsync(int id);
    Task<ResponseDTO> AddAsync(VacunaDTO vacuna);
    Task<ResponseDTO> UpdateAsync(int id, VacunaDTO vacuna);
    Task<ResponseDTO> DeleteAsync(int id);
    Task<ResponseDTO> GetVacunasByHistoriaClinicaIdAsync(int historiaClinicaId);
}
