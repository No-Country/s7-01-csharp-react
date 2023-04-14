using s7_01.Api.Common.DTO;
using s7_01.Api.Common.DTOs.ProductoDTOs;
using s7_01.Api.Common.DTOs.ServicioDTOs;
using s7_01.Api.Contracts.Repositories;
using s7_01.Api.Contracts.Services;
using s7_01.Api.DataAccess.Models;

namespace s7_01.Api.Services
{
    public class ServicioService : IServicioService
    {
        private readonly IGenericRepository<Servicio> _servicioRepository;
        private readonly IServicioRepository _servRepository;

        public ServicioService(IGenericRepository<Servicio> servicioRepository, IServicioRepository servRepository)
        {
            _servicioRepository = servicioRepository;
            _servRepository = servRepository;
        }

        public async Task<ResponseDTO> GetAllServiciosAsync()
        {
            var servicios = await _servicioRepository.GetAllAsync();

            var response = new ResponseDTO
            {
                Success = true,
                Result = servicios,
                Message = "Lista de servicios obtenida correctamente",
                StatusCode = 200
            };

            return response;
        }

        public async Task<ResponseDTO> GetServicioByIdAsync(int id)
        {
            var servicio = await _servicioRepository.GetByIdAsync(id);

            if (servicio == null)
            {
                return new ResponseDTO
                {
                    Success = false,
                    Result = null,
                    Message = "El servicio no existe",
                    StatusCode = 404
                };
            }

            var response = new ResponseDTO
            {
                Success = true,
                Result = servicio,
                Message = "Servicio obtenido correctamente",
                StatusCode = 200
            };

            return response;
        }

        public async Task<ResponseDTO> GetServiciosByVeterinariaIdAsync(int id)
        {
            var servicios = await _servRepository.GetServiciosByVeterinariaIdAsync(id);

            if (servicios == null || !servicios.Any())
            {
                return new ResponseDTO
                {
                    Success = false,
                    Result = null,
                    Message = "La veterinaria no tiene servicios registrados",
                    StatusCode = 404
                };
            }

            var response = new ResponseDTO
            {
                Success = true,
                Result = servicios,
                Message = "Lista de servicios obtenida correctamente",
                StatusCode = 200
            };

            return response;
        }

        public async Task<ResponseDTO> AddServicioAsync(ServicioDTO servicioDTO)
        {
            var servicio = new Servicio
            {
                VeterinariaId = servicioDTO.VeterinariaId,
                Costo = servicioDTO.Costo,
                Nombre = servicioDTO.Nombre
            };

            await _servicioRepository.AddAsync(servicio);
            await _servicioRepository.SaveAsync();

            var response = new ResponseDTO
            {
                Success = true,
                Result = servicio,
                Message = "Producto agregado correctamente",
                StatusCode = 201
            };

            return response;
        }

        public async Task<ResponseDTO> UpdateServicioAsync(int id, ServicioDTO servicioDTO)
        {
            var servicio = await _servicioRepository.GetByIdAsync(id);

            if (servicio == null)
            {
                return new ResponseDTO
                {
                    Success = false,
                    Result = null,
                    Message = "El servicio no existe",
                    StatusCode = 404
                };
            }

            servicio.VeterinariaId = servicioDTO.VeterinariaId;
            servicio.Costo = servicioDTO.Costo;
            servicio.Nombre = servicioDTO.Nombre;

            await _servicioRepository.UpdateAsync(servicio);

            var response = new ResponseDTO
            {
                Success = true,
                Result = servicio,
                Message = "Servicio actualizado correctamente",
                StatusCode = 200
            };

            return response;
        }

        public async Task<ResponseDTO> DeleteServicioAsync(int id)
        {
            var servicio = await _servicioRepository.GetByIdAsync(id);

            if (servicio == null)
            {
                return new ResponseDTO
                {
                    Success = false,
                    Result = null,
                    Message = "El servicio no existe",
                    StatusCode = 404
                };
            }

            _servicioRepository.Remove(servicio);
            await _servicioRepository.SaveAsync();

            var response = new ResponseDTO
            {
                Success = true,
                Result = servicio,
                Message = "Servicio eliminado correctamente",
                StatusCode = 200
            };

            return response;
        }

        

    }
}
