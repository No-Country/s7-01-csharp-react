using s7_01.Api.Common.DTO;
using s7_01.Api.Common.DTOs.VacunaDTOs;
using s7_01.Api.Contracts.Repositories;
using s7_01.Api.Contracts.Services;
using s7_01.Api.DataAccess.Models;
using s7_01.Api.Repositories;
using System.Net.WebSockets;
using static s7_01.Api.Common.DTOs.VacunaDTOs.VacunaDTOs;

namespace s7_01.Api.Services;

public class VacunaService : IVacunaService
{
    private readonly IGenericRepository<Vacuna> _vacunaRepository;

    private readonly IVacunaRepository _repository;

    public VacunaService(IGenericRepository<Vacuna> vacunaRepository, IVacunaRepository repository)
    {
        _vacunaRepository = vacunaRepository;
        _repository = repository;
    }
    public async Task<ResponseDTO> AddAsync(VacunaDTO vacunaDTO)
    {
        var vacuna = new Vacuna
        {
            EsDosisUnica = vacunaDTO.EsDosisUnica,
            FechaAplicacion = vacunaDTO.FechaAplicacion,
            HistoriaClinicaId = vacunaDTO.HistoriaClinicaId,
            LoteSerial = vacunaDTO.LoteSerial,
            Nombre = vacunaDTO.Nombre,
            ProximaAplicacion = vacunaDTO.ProximaAplicacion
        };

        await _vacunaRepository.AddAsync(vacuna);
        await _vacunaRepository.SaveAsync();

        var response = new ResponseDTO
        {
            Success = true,
            Result = vacuna,
            Message = "Vacuna agregada correctamente",
            StatusCode = 201
        };

        return response;
    }

    public async Task<ResponseDTO> GetAllAsync()
    {
        var vacunas = await _vacunaRepository.GetAllAsync();
        ResponseDTO response = null;
        if(vacunas != null)
        {
            response = new ResponseDTO
            {
                Success = true,
                Result = vacunas,
                Message = "Lista de vacunas obtenida correctamente",
                StatusCode = 200
            };
        }
        else
        {
            response = new ResponseDTO
            {
                Success = false,
                Result = vacunas,
                Message = "No se encontraron vacunas",
                StatusCode = 200
            };
        }
        return response;
    }

    public async Task<ResponseDTO> GetByIdAsync(int id)
    {
        var vacuna = await _vacunaRepository.GetByIdAsync(id);
        ResponseDTO? response = null;

        if(vacuna != null)
        {
            response = new ResponseDTO
            {
                Success = true,
                Result = vacuna,
                Message = "Vacuna obtenida correctamente",
                StatusCode = 200
            };
        }
        else
        {
            response = new ResponseDTO
            {
                Success = false,
                Result = vacuna,
                Message = $"No existe una vacuna con id {id}",
                StatusCode = 200
            };
        }
        return response;
    }

    public async Task<ResponseDTO> UpdateAsync(int id, VacunaDTO vacunaDTO)
    {
        var vacuna = await _vacunaRepository.GetByIdAsync(id);
        ResponseDTO response = null;

        if(vacuna == null)
        {
            response = new ResponseDTO
            {
                Success = false,
                Result = vacuna,
                Message = $"No existe una vacuna con id {id}",
                StatusCode = 404
            };
        }
        else
        {
            vacuna.EsDosisUnica = vacunaDTO.EsDosisUnica;
            vacuna.FechaAplicacion = vacunaDTO.FechaAplicacion;
            vacuna.HistoriaClinicaId = vacunaDTO.HistoriaClinicaId;
            vacuna.LoteSerial = vacunaDTO.LoteSerial;
            vacuna.Nombre = vacunaDTO.Nombre;
            vacuna.ProximaAplicacion = vacunaDTO.ProximaAplicacion;

            await _vacunaRepository.UpdateAsync(vacuna);
            
            response = new ResponseDTO
            {
                Success = false,
                Result = vacuna,
                Message = "Vacuna actualizada correctamente",
                StatusCode = 201
            };
        }
        return response;
    }

    public async Task<ResponseDTO> DeleteAsync(int id)
    {
        var vacuna = await _vacunaRepository.GetByIdAsync(id);
        ResponseDTO response = null;

        if (vacuna == null)
        {
            response = new ResponseDTO
            {
                Success = false,
                Result = vacuna,
                Message = $"No existe una vacuna con id {id}",
                StatusCode = 404
            };
        }
        else
        {
            response = new ResponseDTO
            {
                Success = true,
                Result = vacuna,
                Message = "La vacuna se eliminó correctamente",
                StatusCode = 404
            };

            _vacunaRepository.Remove(vacuna);
            await _vacunaRepository.SaveAsync();
        }

        return response;
    }


    public async Task<ResponseDTO> GetVacunasByHistoriaClinicaIdAsync(int historiaClinicaId)
    {
        var response = new ResponseDTO();
        try
        {
            var result = await _repository.GetVacunasByHistoriaClinicaIdAsync(historiaClinicaId);
            response.Result = result;
            response.Success = true;
            response.Message = "Vacunas found";
            response.StatusCode = 200;
        }
        catch (Exception ex)
        {
            response.Success = false;
            response.StatusCode = 500;
            response.Message = ex.Message;
        }


        return response;
    }
}
