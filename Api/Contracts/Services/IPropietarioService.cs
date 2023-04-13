using s7_01.Api.Common;
using s7_01.Api.Common.DTOs.AutorizacionDTOs;
using s7_01.Api.Common.DTOs.PropietarioDTOs;
using s7_01.Api.DataAccess.Models;
using System.Linq.Expressions;

namespace s7_01.Api.Contracts.Services
{
    public interface IPropietarioService
    {
        Task<ResponseDTO> GetByIdAsync(int id);
        Task<ResponseDTO> GetAllAsync();
        Task<ResponseDTO> FindAsync(Expression<Func<Propietario, bool>> expression);
        Task<ResponseDTO> AddAsync(CreatePropietarioDTO createPropietarioDTO);
        Task<ResponseDTO> AddRangeAsync(IEnumerable<CreatePropietarioDTO> createPropietarioDTOs);
        Task<ResponseDTO> RemoveAsync(int propietarioId);
        ResponseDTO RemoveRangeAsync(IEnumerable<GetAutorizacionDTO> getAutorizacionDTOs);
        Task<ResponseDTO> GetMascotasByPropietarioIdAsync(int propietarioId);

    }
}
