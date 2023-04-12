using Azure;
using s7_01.Api.Common.DTO;
using s7_01.Api.Common.DTOs.VeterinariaDTOs;
using s7_01.Api.Contracts.Repositories;
using s7_01.Api.Contracts.Services;
using s7_01.Api.DataAccess.Models;

namespace s7_01.Api.Services
{
    public class VeterinariaService : IVeterinariaService
    {
        private readonly IGenericRepository<Veterinaria> _veterinariaRepository;

        public VeterinariaService(IGenericRepository<Veterinaria> veterinariaRepository)
        {
            _veterinariaRepository = veterinariaRepository;
        }

        public async Task<ResponseDTO> AddVeterinariaAsync(VeterinariaDTO veterinariaDTO)
        {

            var dir = veterinariaDTO.DireccionDTO;

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

    }
}
