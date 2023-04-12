using s7_01.Api.Common.DTO;
using s7_01.Api.Common.DTOs.MascotaDTOs;
using s7_01.Api.Common.DTOs.ProductoDTOs;
using s7_01.Api.Contracts.Repositories;
using s7_01.Api.Contracts.Services;
using s7_01.Api.DataAccess.Models;
using s7_01.Api.Repositories;

namespace s7_01.Api.Services
{
    public class MascotaService : IMascotaService
    {
        private readonly IMascotaRepository _repository;
        private readonly IMascotaPropietarioRepository _mascotaPropietarioRepository;
        public MascotaService(IMascotaRepository repository, IMascotaPropietarioRepository mascotaPropietarioRepository)
        {
            _repository = repository;
            _mascotaPropietarioRepository = mascotaPropietarioRepository;
        }

        public async Task<ResponseDTO> GetAllMascotasAsync()
        {
            var mascotas = await _repository.GetAllAsync();
            var response = new ResponseDTO
            {
                Success = true,
                Result = mascotas,
                Message = "Lista de mascotas obtenida correctamente",
                StatusCode = 200
            };

            return response;
        }

        public async Task<ResponseDTO> GetMascotaByIdAsync(int id)
        {
            Mascota mascota = await _repository.GetByIdAsync(id);
            var response = new ResponseDTO
            {
                Success = true,
                Result = mascota,
                Message = "Mascota obtenida correctamente",
                StatusCode = 200
            };

            return response;
        }

        public async Task<ResponseDTO> AddMascotaAsync(int id, MascotaDTO mascotaDto)
        {
            Mascota mascota = new Mascota()
            {
                Nombre = mascotaDto.Nombre,
                Especie = mascotaDto.Especie,
                FechaNacimento = mascotaDto.FechaNacimento,
                Peso = mascotaDto.Peso,
                Sexo = mascotaDto.Sexo
            };

            await _mascotaPropietarioRepository.AddAsync(new MascotaPropietario()
            {
                EsPrincipal = false,
                Mascota = mascota,
                PropietarioId = id
            });
            await _mascotaPropietarioRepository.SaveAsync();
            var response = new ResponseDTO
            {
                Success = true,
                Result = mascota,
                Message = "Mascota agregada correctamente",
                StatusCode = 201
            };

            return response;
        }

        public async Task<ResponseDTO> UpdateMascotaAsync(int id, MascotaDTO mascotaDto)
        {
            var mascota = await _repository.GetByIdAsync(id);


            mascota.Nombre = mascotaDto.Nombre;
            mascota.Especie = mascotaDto.Especie;
            mascota.FechaNacimento = mascotaDto.FechaNacimento;
            mascota.Peso = mascotaDto.Peso;
            mascota.Sexo = mascotaDto.Sexo;
           

            await _repository.UpdateAsync(mascota);
            var response = new ResponseDTO
            {
                Success = true,
                Result = mascota,
                Message = "Mascota actualizado correctamente",
                StatusCode = 200
            };

            return response;
        }
        public async Task<ResponseDTO> GetAllMascotasPropietaryAsync(int id)
        {
            var mascotaPropietarios = await _mascotaPropietarioRepository.FindAsync(m => m.PropietarioId == id);
            List<Mascota> mascotas = new List<Mascota>();

            foreach (var mascotaXPropietario in mascotaPropietarios)
            {
                mascotas.Add(mascotaXPropietario.Mascota);
            }

            var response = new ResponseDTO
            {
                Success = true,
                Result = mascotas,
                Message = "Lista de mascota obtenida correctamente",
                StatusCode = 200
            };

            return response;
        }

    }
}
