using s7_01.Api.Common;
using s7_01.Api.Common.DTOs.AutorizacionDTOs;
using s7_01.Api.DataAccess.Models;
using System.Linq.Expressions;

namespace s7_01.Api.Contracts.Services
{
    public interface IAutorizacionService
    {

        Task<ResponseDTO> GetByIdAsync(int id);
        Task<ResponseDTO> GetAllAsync();
        Task<ResponseDTO> FindAsync(Expression<Func<Autorizacion, bool>> expression);
        Task<ResponseDTO> AddAsync(CreateAutorizacionDTO createAutorizacionDTO);
        Task<ResponseDTO> AddRangeAsync(IEnumerable<CreateAutorizacionDTO> createAutorizacionDTOs);
        Task<ResponseDTO> RemoveAsync(GetAutorizacionDTO getAutorizacionDTO);
        Task<ResponseDTO> RemoveRangeAsync(IEnumerable<GetAutorizacionDTO> getAutorizacionDTOs);
        Task<ResponseDTO> GetAutorizacionesByMascotaIdAsync(int mascotaId);
        Task<ResponseDTO> GetAutorizacionesByVeterinaIdAsync(int veterinariaId);
        Task<ResponseDTO> GetAutorizacionByMascotaIdAndVeterinariaIdAsync(GetAutorizacionDTO getAutorizacionDTO);
    }
}
