using s7_01.Api.Common;
using s7_01.Api.Common.DTO;
using s7_01.Api.Common.DTOs.AutorizacionDTOs;
using s7_01.Api.Common.DTOs.HistoriaClinicaDTOs;
using s7_01.Api.Common.DTOs.PropietarioDTOs;
using s7_01.Api.Common.DTOs.VeterinariaDTOs;
using s7_01.Api.Contracts.Repositories;
using s7_01.Api.Contracts.Services;
using s7_01.Api.DataAccess.Models;
using s7_01.Api.Repositories;
using System.Linq.Expressions;

namespace s7_01.Api.Services
{
    public class HistoriaClinicaService : IHistoriaClinicaService
    {
        private readonly IGenericRepository<HistoriaClinica> _repository;

        private readonly IHistoriaClinicaRepository _historiaClinicaRepository;

        public HistoriaClinicaService(IGenericRepository<HistoriaClinica> repository, IHistoriaClinicaRepository historiaClinicaRepository)
        {
            _repository = repository;
            _historiaClinicaRepository = historiaClinicaRepository;
        }

        public async Task<ResponseDTO> GetByIdAsync(int id)
        {
            var response = new ResponseDTO();

            try
            {
                var entity = await _repository.GetByIdAsync(id);

                if (entity != null)
                {
                    response.Success = true;
                    response.Result = entity;
                    response.Message = "Historia Clinica found.";
                    response.StatusCode = 200;
                }
                else
                {
                    response.Success = false;
                    response.Message = "Historia Clinica not found.";
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
                response.Message = "List of Historias successfully loaded";
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

        public async Task<ResponseDTO> FindAsync(Expression<Func<HistoriaClinica, bool>> expression)
        {
            var response = new ResponseDTO();
            try
            {
                var result = await _repository.FindAsync(expression);
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

        public async Task<ResponseDTO> AddAsync(CreateHistoriaClinicaDTO createHistoriaClinicaDTO)
        {
            
            var historiaClinica = new HistoriaClinica
            {
                MascotaId = createHistoriaClinicaDTO.MascotaId,
                Comentarios = createHistoriaClinicaDTO.Comentarios

            };

            var response = new ResponseDTO();
            try
            {
                await _repository.AddAsync(historiaClinica);
                await _repository.SaveAsync();
                response.Success = true;
                response.Message = "Historia clinica successfully added";
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

        public async Task<ResponseDTO> RemoveAsync(int historiaClinicaId)
        {
            var historiaClinica = await _repository.GetByIdAsync(historiaClinicaId);

            if (historiaClinica == null)
            {
                return new ResponseDTO
                {
                    Success = false,
                    Result = null,
                    Message = "Historia clinica not found",
                    StatusCode = 404
                };
            }

            var response = new ResponseDTO();
            try
            {
                _repository.Remove(historiaClinica);
                await _repository.SaveAsync();
                response.Success = true;
                response.Message = "Historia clinica successfully removed";
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

        public async Task<ResponseDTO> UpdateAsync(int id, CreateHistoriaClinicaDTO createHistoriaClinicaDTO)
        {
            var historiaClinica = await _repository.GetByIdAsync(id);

            if (historiaClinica == null)
            {
                return new ResponseDTO
                {
                    Success = false,
                    Result = null,
                    Message = "Historia clinica not found",
                    StatusCode = 404
                };
            }

            historiaClinica.MascotaId = createHistoriaClinicaDTO.MascotaId;
            historiaClinica.Comentarios = createHistoriaClinicaDTO.Comentarios;
         
            await _repository.UpdateAsync(historiaClinica);

            var response = new ResponseDTO
            {
                Success = true,
                Result = historiaClinica,
                Message = "Historia clinica successfully updated",
                StatusCode = 200
            };

            return response;
        }

        public async Task<ResponseDTO> GetHistoriaClinicaByMascotaId(int mascotaId)
        {
            var response = new ResponseDTO();
            try
            {
                var result = await _historiaClinicaRepository.GetHistoriaClinicaByMascotaId(mascotaId);
                response.Result = result;
                response.Success = true;
                response.Message = "Historia Clinica found";
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


        public Task<ResponseDTO> AddRangeAsync(IEnumerable<CreateHistoriaClinicaDTO> createHistoriaClinicaDTOs)
        {
            throw new NotImplementedException();
        }

        public ResponseDTO RemoveRangeAsync(IEnumerable<GetHistoriaClinicaDTO> getHistoriaClinicaDTOs)
        {
            throw new NotImplementedException();
        }
       
    }
}
