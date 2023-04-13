using Azure;
using s7_01.Api.Common.DTO;
using s7_01.Api.Common.DTOs.DireccionDTOs;
using s7_01.Api.Common.DTOs.VeterinariaDTOs;
using s7_01.Api.Contracts.Repositories;
using s7_01.Api.Contracts.Services;
using s7_01.Api.DataAccess.Models;

namespace s7_01.Api.Services
{
    public class VeterinariaService : IVeterinariaService
    {
        private readonly IGenericRepository<Veterinaria> _veterinariaRepository;        

        public VeterinariaService(IGenericRepository<Veterinaria> veterinariaRepository, IVeterinariaRepository veteRepository)
        {
            _veterinariaRepository = veterinariaRepository;            
        }

        public async Task<ResponseDTO> GetAllVeterinariasAsync()
        {
            try
            {
                var veterinarias = await _veterinariaRepository.GetAllAsync();
                var response = new ResponseDTO
                {
                    Success = true,
                    Result = veterinarias,
                    Message = "Lista de veterinarias obtenida correctamente",
                    StatusCode = 200
                };
                return response;
            }
            catch (Exception ex)
            {
                var response = new ResponseDTO
                {
                    Success = false,
                    Message = "Ha ocurrido un error al obtener la lista de veterinarias",
                    StatusCode = 500
                };
                return response;
            }
        }

        public async Task<ResponseDTO> GetVeterinariaByIdAsync(int id)
        {
            var veterinaria = await _veterinariaRepository.GetByIdAsync(id);

            if (veterinaria == null)
            {
                return new ResponseDTO
                {
                    Success = false,
                    Result = null,
                    Message = "La veterinaria no existe",
                    StatusCode = 404
                };
            }

            var response = new ResponseDTO
            {
                Success = true,
                Result = veterinaria,
                Message = "Veterinaria obtenida correctamente",
                StatusCode = 200
            };

            return response;
        }       

        public async Task<ResponseDTO> AddVeterinariaAsync(VeterinariaDTO veterinariaDTO)
        {

            var dir = veterinariaDTO.Direccion;

            var direccion = new Direccion
            {
                Calle = dir.Calle,
                Numero = dir.Numero,
                Ciudad = dir.Ciudad,
                Pais = dir.Pais,
                CodigoPostal = dir.CodigoPostal
            };

            var veterinaria = new Veterinaria
            {
                Nombre = veterinariaDTO.Nombre,
                Direccion = direccion,
                RazonSocial = veterinariaDTO.RazonSocial,
                CUIT = veterinariaDTO.CUIT,
                Email = veterinariaDTO.Email,
                LogoURI = veterinariaDTO.LogoURI,
                Facebook = veterinariaDTO.Facebook,
                Instagram = veterinariaDTO.Instagram,
                Twitter = veterinariaDTO.Twitter,
                Whatsapp = veterinariaDTO.Whatsapp,
                Telefono = veterinariaDTO.Telefono
            };

            var response = new ResponseDTO();
            try
            {
                await _veterinariaRepository.AddAsync(veterinaria);
                await _veterinariaRepository.SaveAsync();
                response.Success = true;
                response.StatusCode = 201;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.StatusCode = 500;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<ResponseDTO> UpdateVeterinariaAsync(int id, VeterinariaDTO veterinariaDTO)
        {
            var veterinaria = await _veterinariaRepository.GetByIdAsync(id);

            if (veterinaria == null)
            {
                return new ResponseDTO
                {
                    Success = false,
                    Result = null,
                    Message = "La veterinaria no existe",
                    StatusCode = 404
                };
            }

            veterinaria.Nombre = veterinariaDTO.Nombre;
            veterinaria.Direccion.Calle = veterinariaDTO.Direccion.Calle;
            veterinaria.Direccion.Numero = veterinariaDTO.Direccion.Numero;
            veterinaria.Direccion.Ciudad = veterinariaDTO.Direccion.Ciudad;
            veterinaria.Direccion.Pais = veterinariaDTO.Direccion.Pais;
            veterinaria.Direccion.CodigoPostal = veterinariaDTO.Direccion.CodigoPostal;
            veterinaria.RazonSocial = veterinariaDTO.RazonSocial;
            veterinaria.CUIT = veterinariaDTO.CUIT;
            veterinaria.Email = veterinariaDTO.Email;
            veterinaria.LogoURI = veterinariaDTO.LogoURI;
            veterinaria.Facebook = veterinariaDTO.Facebook;
            veterinaria.Instagram = veterinariaDTO.Instagram;
            veterinaria.Twitter = veterinariaDTO.Twitter;
            veterinaria.Whatsapp = veterinariaDTO.Whatsapp;
            veterinaria.Telefono = veterinariaDTO.Telefono;

            await _veterinariaRepository.UpdateAsync(veterinaria);

            var response = new ResponseDTO
            {
                Success = true,
                Result = veterinaria,
                Message = "Veterinaria actualizada correctamente",
                StatusCode = 200
            };

            return response;
        }

        public async Task<ResponseDTO> DeleteVeterinariaAsync(int id)
        {
            var veterinaria = await _veterinariaRepository.GetByIdAsync(id);

            if (veterinaria == null)
            {
                return new ResponseDTO
                {
                    Success = false,
                    Result = null,
                    Message = "La veterinaria no existe",
                    StatusCode = 404
                };
            }

            _veterinariaRepository.Remove(veterinaria);
            await _veterinariaRepository.SaveAsync();

            var response = new ResponseDTO
            {
                Success = true,
                Result = veterinaria,
                Message = "Veterinaria eliminada correctamente",
                StatusCode = 200
            };

            return response;
        }

        

        

    }
}
