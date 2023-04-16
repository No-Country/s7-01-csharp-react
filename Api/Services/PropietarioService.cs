﻿using Microsoft.EntityFrameworkCore;
using s7_01.Api.Common;
using s7_01.Api.Common.DTOs.AutorizacionDTOs;
using s7_01.Api.Common.DTOs.PropietarioDTOs;
using s7_01.Api.Contracts.Repositories;
using s7_01.Api.Contracts.Services;
using s7_01.Api.DataAccess;
using s7_01.Api.DataAccess.Models;
using s7_01.Api.Repositories;
using System.Linq.Expressions;
using System.Net;

namespace s7_01.Api.Services
{
    public class PropietarioService : IPropietarioService
    {
        private readonly IGenericRepository<Propietario> _repository;
        private readonly IPropietarioRepository _propietarioRepository;

        public PropietarioService(IGenericRepository<Propietario> repository, IPropietarioRepository propietarioRepository)
        {
            _repository = repository;
            _propietarioRepository = propietarioRepository;
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
                    response.Message = "Entity found.";
                    response.StatusCode = 200;
                }
                else
                {
                    response.Success = false;
                    response.Message = "Entity not found.";
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

        public async Task<ResponseDTO> FindAsync(Expression<Func<Propietario, bool>> expression)
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

        public async Task<ResponseDTO> AddAsync(CreatePropietarioDTO createPropietarioDTO)
        {
            var dir = createPropietarioDTO.DireccionDTO;

            var direccion = new Direccion
            {
                Calle = dir.Calle,
                Numero = dir.Numero,
                Ciudad = dir.Ciudad,
                Pais = dir.Pais,
                CodigoPostal = dir.CodigoPostal
            };

            var propietario = new Propietario
            {
               Nombre = createPropietarioDTO.Nombre,
               DNI = createPropietarioDTO.DNI,
               Direccion= direccion,
               Email= createPropietarioDTO.Email,

            };

            var response = new ResponseDTO();
            try
            {
                await _repository.AddAsync(propietario);
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

        public async Task<ResponseDTO> RemoveAsync(int propietarioId)
        {
            var propietario = await _repository.GetByIdAsync(propietarioId);

            if (propietario == null)
            {
                return new ResponseDTO
                {
                    Success = false,
                    Result = null,
                    Message = "Not Found",
                    StatusCode = 404
                };
            }

            var response = new ResponseDTO();
            try
            {
                _repository.Remove(propietario);
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

        public Task<ResponseDTO> AddRangeAsync(IEnumerable<CreatePropietarioDTO> createPropietarioDTOs)
        {
            throw new NotImplementedException();
        }
     
        public ResponseDTO RemoveRangeAsync(IEnumerable<GetAutorizacionDTO> getAutorizacionDTOs)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseDTO> GetMascotasByPropietarioIdAsync(int propietarioId)
        {
            var response = new ResponseDTO();
            try
            {
                var mascotas = await _propietarioRepository.GetMascotasByPropietarioIdAsync(propietarioId);
                if (mascotas != null && mascotas.Any())
                {
                    response.Success = true;
                    response.Result = mascotas;
                    response.Message = "Mascotas found.";
                    response.StatusCode = 200;
                }
                else
                {
                    response.Success = false;
                    response.Message = "Mascotas not found.";
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

    }

}
