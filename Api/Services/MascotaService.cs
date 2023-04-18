
using s7_01.Api.Common.DTO;
using s7_01.Api.Common.DTOs.MascotaDTOs;
using s7_01.Api.Common.DTOs.VeterinariaDTOs;
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
            var response = new ResponseDTO
            {
                Success = true,
                Result = "",
                Message = "",
                StatusCode = 200
            };

            try
            {
                var mascotas = await _repository.GetAllAsync();
                if (mascotas != null && mascotas.Any())
                {
                    response.Result = mascotas;
                    response.Message = "Lista de mascotas obtenida correctamente";
                }
                else
                {
                    response.Message = "Lista vacia";
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Result = ex.Message;
                response.Message = "Servel Internal Error";
                response.StatusCode = 500;
                throw;
            }
            return response;
        }

        public async Task<ResponseDTO> GetMascotaByIdAsync(int id)
        {
            var response = new ResponseDTO
            {
                Success = true,
                Result = "",
                Message = "",
                StatusCode = 200
            };
            try
            {
                Mascota mascota = await _repository.GetByIdAsync(id);
                if (mascota == null)
                {
                    response.Success = false;
                    response.Result = mascota;
                    response.Message = $"No existe una mascota con el id: ${id}";
                    response.StatusCode = 404;
                } else
                {
                    response.Result = mascota;
                    response.Message = "Mascota obtenida correctamente";

                }

            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Result = ex.Message;
                response.Message = "Servel Internal Error";
                response.StatusCode = 500;
                throw;
            }
            return response;
        }

        public async Task<ResponseDTO> AddMascotaAsync(int id, MascotaDTO mascotaDto)
        {
            var response = new ResponseDTO
            {
                Success = true,
                Result = "",
                Message = "",
                StatusCode = 200
            };

            if ( mascotaDto.GetType() != typeof(MascotaDTO))
            {
                response.Success = false;
                response.Message = "Error al agregar mascota, compruebe los datos ingresados";
                response.StatusCode = 400;

                return response;
            }

            Mascota mascota = new Mascota()
            {
                Nombre = mascotaDto.Nombre,
                Especie = mascotaDto.Especie,
                FechaNacimento = mascotaDto.FechaNacimento,
                Peso = mascotaDto.Peso,
                Sexo = mascotaDto.Sexo,
                URLFotoPerfil = mascotaDto.URLFotoPerfil
            };
            try
            {
                await _mascotaPropietarioRepository.AddAsync(new MascotaPropietario()
                {
                    EsPrincipal = false,
                    Mascota = mascota,
                    PropietarioId = id
                });
                await _mascotaPropietarioRepository.SaveAsync();
                response.Success = true;
                response.Message = "Mascota agregada correctamente";
                response.Result = mascota;
                response.StatusCode=201;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Result = ex.Message;
                response.Message = "Servel Internal Error";
                response.StatusCode = 500;
                throw;
            }
            return response;
        }

        public async Task<ResponseDTO> UpdateMascotaAsync(int id, MascotaDTO mascotaDto)
        {
            var response = new ResponseDTO
            {
                Success = true,
                Result = "",
                Message = "",
                StatusCode = 200
            };
            try
            {
                var mascota = await _repository.GetByIdAsync(id);
                if (mascota == null)
                {
                    response.Success = false;
                    response.Result = mascota;
                    response.Message = $"No existe una mascota con el id: ${id}";
                    response.StatusCode = 404;
                }
                else
                {
                    mascota.Nombre = mascotaDto.Nombre;
                    mascota.Especie = mascotaDto.Especie;
                    mascota.FechaNacimento = mascotaDto.FechaNacimento;
                    mascota.Peso = mascotaDto.Peso;
                    mascota.Sexo = mascotaDto.Sexo;

                    await _repository.UpdateAsync(mascota);

                    response.Message = "Mascota actualizada correctamente";
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Result = ex.Message;
                response.Message = "Servel Internal Error";
                response.StatusCode = 500;
                throw;
            }


            return response;
        }

        public async Task<ResponseDTO> GetAllMascotasPropietaryAsync(int id)
        {
            var response = new ResponseDTO
            {
                Success = true,
                Result = "",
                Message = "",
                StatusCode = 200
            };
            try
            {
                var mascotaPropietarios = await _mascotaPropietarioRepository.FindAsync(m => m.PropietarioId == id);
                if (mascotaPropietarios == null)
                {
                    response.Success = false;
                    response.Result = mascotaPropietarios;
                    response.Message = $"No se pudo encontrar las mascotas asociadas al id: ${id}";
                    response.StatusCode = 404;
                }
                else
                {
                    List<Mascota> mascotas = new List<Mascota>();
                    foreach (var mascotaXPropietario in mascotaPropietarios)
                    {
                        mascotas.Add(mascotaXPropietario.Mascota);
                    }
                    if (mascotas.Count > 0) // Agregado chequeo adicional
                    {
                        response.Result = mascotas;
                        response.Message = "Lista de mascotas obtenida correctamente";
                    }
                    else
                    {
                        response.Success = false;
                        response.Result = mascotas;
                        response.Message = "No se encontraron mascotas para el propietario especificado";
                        response.StatusCode = 404;
                    }
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Result = ex.Message;
                response.Message = "Servel Internal Error";
                response.StatusCode = 500;
                throw;
            }

            return response;
        }


        public async Task<ResponseDTO> AddRangeAsync(int id, IEnumerable<MascotaDTO> mascotaDTOs)
        {
            var response = new ResponseDTO
            {
                Success = true,
                Result = "",
                Message = "",
                StatusCode = 200
            };

            if (mascotaDTOs == null || !mascotaDTOs.Any())
            {
                response.Success = false;
                response.Message = "No se recibieron datos de mascotas para agregar";
                response.StatusCode = 400;

                return response;
            }

            var mascotas = new List<Mascota>();
            foreach (var dto in mascotaDTOs)
            {
                var mascota = new Mascota()
                {
                    Nombre = dto.Nombre,
                    Especie = dto.Especie,
                    FechaNacimento = dto.FechaNacimento,
                    Peso = dto.Peso,
                    Sexo = dto.Sexo
                };
                mascotas.Add(mascota);
            }

            try
            {
                var mascotaPropietarios = mascotas.Select(m => new MascotaPropietario()
                {
                    EsPrincipal = false,
                    Mascota = m,
                    PropietarioId = id
                }).ToList();
                await _mascotaPropietarioRepository.AddRangeAsync(mascotaPropietarios);
                await _mascotaPropietarioRepository.SaveAsync();

                response.Success = true;
                response.Message = "Mascotas agregadas correctamente";
                response.Result = mascotas;
                response.StatusCode = 201;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Result = ex.Message;
                response.Message = "Servel Internal Error";
                response.StatusCode = 500;
                throw;
            }

            return response;
        }

    }
}
