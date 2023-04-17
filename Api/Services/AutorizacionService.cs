using Microsoft.EntityFrameworkCore;
using s7_01.Api.Common;
using s7_01.Api.Common.DTO;
using s7_01.Api.Common.DTOs.AutorizacionDTOs;
using s7_01.Api.Contracts.Repositories;
using s7_01.Api.Contracts.Services;
using s7_01.Api.DataAccess;
using s7_01.Api.DataAccess.Models;
using s7_01.Api.Repositories;
using System.Linq.Expressions;
using System.Net;

namespace s7_01.Api.Services
{
    public class AutorizacionService : IAutorizacionService
    {
        private readonly IGenericRepository<Autorizacion> _repository;

        private readonly IAutorizacionRepository _autorizacionRepository;

        public AutorizacionService(IGenericRepository<Autorizacion> repository, IAutorizacionRepository autorizacionRepository )
        {
            _repository = repository;
            _autorizacionRepository= autorizacionRepository;
        }

       
        public async Task<ResponseDTO>  GetByIdAsync(int id)
        {
            var response = new ResponseDTO();

            try
            {
                var entity = await _repository.GetByIdAsync(id);

                if (entity != null)
                {
                    response.Success = true;
                    response.Result = entity;
                    response.Message = "Authorization found.";
                    response.StatusCode = 200;
                }
                else
                {
                    response.Success = false;
                    response.Message = "Authorization not found.";
                    response.StatusCode = 404;
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
                response.StatusCode = 500;
            }

            return response;
        }

        public async Task<ResponseDTO> GetAllAsync()
        {
            var response = new ResponseDTO();
            try
            {
                var result = await _repository.GetAllAsync();
                response.Result = result;
                response.Success = true;
                response.Message = "List of Authorizations successfully loaded";
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

        public async Task<ResponseDTO> FindAsync(Expression<Func<Autorizacion, bool>> expression)
        {
            var response = new ResponseDTO();
            try
            {
                var result =await _repository.FindAsync(expression);
                response.Result = result;
                response.Success = true;
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
      
        public async Task<ResponseDTO> AddAsync(CreateAutorizacionDTO createAutorizacionDTO)
        {
            var autorizacion = new Autorizacion
            {
                VeterinariaId = createAutorizacionDTO.VeterinariaId,
                MascotaId = createAutorizacionDTO.MascotaId,
                EsActiva = createAutorizacionDTO.EsActiva
            };

            var response = new ResponseDTO();
            try
            {
                await _repository.AddAsync(autorizacion);
                await _repository.SaveAsync();
                response.Success = true;
                response.Message = "Authorization successfully added";
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

        public async Task<ResponseDTO> AddRangeAsync(IEnumerable<CreateAutorizacionDTO> createAutorizacionDTOs)
        {
            var autorizaciones = new List<Autorizacion>();
            foreach (var dto in createAutorizacionDTOs)
            {
                var autorizacion = new Autorizacion
                {
                    VeterinariaId = dto.VeterinariaId,
                    MascotaId = dto.MascotaId,
                    EsActiva = dto.EsActiva
                };
                autorizaciones.Add(autorizacion);
            }

            var response = new ResponseDTO();
            try
            {
               await _repository.AddRangeAsync(autorizaciones);
                await _repository.SaveAsync();
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

        public async Task<ResponseDTO> RemoveAsync(GetAutorizacionDTO getAutorizacionDTO)
        {
            var response = new ResponseDTO();

            try
            {
                var autorizacion = await _autorizacionRepository.GetAutorizacionByMascotaIdAndVeterinariaIdAsync(getAutorizacionDTO);

                if (autorizacion == null)
                {
                    response.Success = false;
                    response.StatusCode = 404;
                    response.Message = "Authorization not found.";
                    return response;
                }

                _repository.Remove(autorizacion);
                await _repository.SaveAsync();
                response.Message = "Authorization successfully removed";
                response.Success = true;
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

        public async Task<ResponseDTO> RemoveRangeAsync(IEnumerable<GetAutorizacionDTO> getAutorizacionDTOs)
        {
            var autorizaciones = new List<Autorizacion>();

            foreach (var getAutorizacionDTO in getAutorizacionDTOs)
            {
                var autorizacion = await _autorizacionRepository.GetAutorizacionByMascotaIdAndVeterinariaIdAsync(getAutorizacionDTO);
                autorizaciones.Add(autorizacion);
            }

            var response = new ResponseDTO();

            try
            {
                _repository.RemoveRange(autorizaciones);
                await _repository.SaveAsync();
                response.Success = true;
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

        public async Task<ResponseDTO> GetAutorizacionesByMascotaIdAsync(int mascotaId)
        {
            var response = new ResponseDTO();
            try
            {
                var result = await _autorizacionRepository.GetAutorizacionesByMascotaIdAsync(mascotaId);
                response.Result = result;
                response.Success = true;
                response.Message = "Authorization found";
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

        public async Task<ResponseDTO> GetAutorizacionesByVeterinaIdAsync(int veterinariaId)
        {
            var response = new ResponseDTO();
            try
            {
                var result = await _autorizacionRepository.GetAutorizacionesByVeterinariaIdAsync(veterinariaId);
                response.Result = result;
                response.Success = true;
                response.Message = "Authorization found";
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

        public async Task<ResponseDTO> GetAutorizacionByMascotaIdAndVeterinariaIdAsync(GetAutorizacionDTO getAutorizacionDTO)
        {
            var response = new ResponseDTO();
            try
            {
                var result = await _autorizacionRepository.GetAutorizacionByMascotaIdAndVeterinariaIdAsync(getAutorizacionDTO);
                response.Result = result;
                response.Success = true;
                response.Message = "Authorization found";
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

}
