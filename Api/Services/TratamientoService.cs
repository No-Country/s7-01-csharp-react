using s7_01.Api.Common;
using s7_01.Api.Common.DTOs.TratamientoDTOs;
using s7_01.Api.Contracts.Repositories;
using s7_01.Api.Contracts.Services;
using s7_01.Api.DataAccess.Models;
using s7_01.Api.Repositories;
using static s7_01.Api.Common.DTOs.TratamientoDTOs.TratamientoDTOs;
using static s7_01.Api.Common.DTOs.VacunaDTOs.VacunaDTOs;

namespace s7_01.Api.Services
{
    public class TratamientoService : ITratamientoService
    {
        private readonly IGenericRepository<Tratamiento> _tratamientoRepository;
        private readonly ITratamientoRepository _tratamiento;

        public TratamientoService(IGenericRepository<Tratamiento> tratamientoRepository,
            ITratamientoRepository tratamiento)
        {
            _tratamientoRepository = tratamientoRepository;
            _tratamiento = tratamiento;
        }
        public async Task<ResponseDTO> AddAsync(TratamientoDTO tratamientoDTO)
        {
            var tratamiento = new Tratamiento
            {
                DosisMedicamento = tratamientoDTO.DosisMedicamento,
                Fecha = tratamientoDTO.Fecha,
                HistoriaClinicaId = tratamientoDTO.HistoriaClinicaId,
                NombreMedico = tratamientoDTO.NombreMedico,
                Observaciones = tratamientoDTO.Observaciones,
                TipoTratamiento = tratamientoDTO.TipoTratamiento,
                VeterinariaId = tratamientoDTO.VeterinariaId
            };

            await _tratamientoRepository.AddAsync(tratamiento);
            await _tratamientoRepository.SaveAsync();

            var response = new ResponseDTO
            {
                Success = true,
                Result = tratamiento,
                Message = "Tratamiento agregado correctamente",
                StatusCode = 201
            };

            return response;
        }

        public async Task<ResponseDTO> DeleteAsync(int id)
        {
            var tratamiento = await _tratamientoRepository.GetByIdAsync(id);
            ResponseDTO response = null;

            if (tratamiento == null)
            {
                response = new ResponseDTO
                {
                    Success = false,
                    Result = tratamiento,
                    Message = $"No existe un tratamiento con id {id}",
                    StatusCode = 404
                };
            }
            else
            {
                response = new ResponseDTO
                {
                    Success = true,
                    Result = tratamiento,
                    Message = "La vacuna se eliminó correctamente",
                    StatusCode = 201
                };

                _tratamientoRepository.Remove(tratamiento);
                await _tratamientoRepository.SaveAsync();
            }

            return response;
        }

        public async Task<ResponseDTO> GetAllAsync()
        {
            var tratamiento = await _tratamientoRepository.GetAllAsync();
            ResponseDTO response = null;
            if (tratamiento != null)
            {
                response = new ResponseDTO
                {
                    Success = true,
                    Result = tratamiento,
                    Message = "Lista de tratamientos obtenida correctamente",
                    StatusCode = 200
                };
            }
            else
            {
                response = new ResponseDTO
                {
                    Success = false,
                    Result = tratamiento,
                    Message = "No se encontraron tratamientos",
                    StatusCode = 200
                };
            }
            return response;
        }

        public async Task<ResponseDTO> GetByIdAsync(int id)
        {
            var tratamiento = await _tratamientoRepository.GetByIdAsync(id);
            ResponseDTO? response = null;

            if (tratamiento != null)
            {
                response = new ResponseDTO
                {
                    Success = true,
                    Result = tratamiento,
                    Message = "Tratmiento obtenido correctamente",
                    StatusCode = 200
                };
            }
            else
            {
                response = new ResponseDTO
                {
                    Success = false,
                    Result = tratamiento,
                    Message = $"No existe una vacuna con id {id}",
                    StatusCode = 200
                };
            }
            return response;
        }

        public async Task<ResponseDTO> GetTratamientoByVeterinariaIdAsync(int veterinariId)
        {
            //var tratamiento = await _service.GetTratamientoByVeterinariaIdAsync(veterinariId);
            var tratamiento = await _tratamiento.GetTratamientoByVeterinariaIdAsync(veterinariId);

            if (tratamiento is null)
            {
                return new ResponseDTO
                {
                    Success = false,
                    Result = null,
                    Message = "El tratamiento no tiene registros",
                    StatusCode = 404
                };
            }

            var response = new ResponseDTO
            {
                Success = true,
                Result = tratamiento,
                Message = "Lista de tratamientos obtenida correctamente",
                StatusCode = 200
            };

            return response;
        }

        public async Task<ResponseDTO> UpdateAsync(int id, TratamientoDTOs.TratamientoDTO tratamientoDTO)
        {
            var tratamiento = await _tratamientoRepository.GetByIdAsync(id);
            ResponseDTO response = null;

            if (tratamiento == null)
            {
                response = new ResponseDTO
                {
                    Success = false,
                    Result = tratamiento,
                    Message = $"No existe una vacuna con id {id}",
                    StatusCode = 404
                };
            }
            else
            {
                tratamiento.DosisMedicamento = tratamientoDTO.DosisMedicamento;
                tratamiento.Fecha = tratamientoDTO.Fecha;
                tratamiento.HistoriaClinicaId = tratamientoDTO.HistoriaClinicaId;
                tratamiento.Id = tratamientoDTO.TratamientoId;
                tratamiento.NombreMedico = tratamientoDTO.NombreMedico;
                tratamiento.Observaciones = tratamientoDTO.Observaciones;
                tratamiento.TipoTratamiento = (TipoTratamiento)tratamientoDTO.TipoTratamiento;
                tratamiento.VeterinariaId = tratamientoDTO.VeterinariaId;

                await _tratamientoRepository.UpdateAsync(tratamiento);

                response = new ResponseDTO
                {
                    Success = false,
                    Result = tratamiento,
                    Message = "Tratamiento actualizado correctamente",
                    StatusCode = 201
                };
            }
            return response;
        }
    }
}
