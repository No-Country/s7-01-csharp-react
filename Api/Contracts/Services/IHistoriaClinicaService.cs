using s7_01.Api.Common;
using s7_01.Api.Common.DTO;
using s7_01.Api.Common.DTOs.AutorizacionDTOs;
using s7_01.Api.Common.DTOs.HistoriaClinicaDTOs;
using s7_01.Api.Common.DTOs.PropietarioDTOs;
using s7_01.Api.Common.DTOs.VeterinariaDTOs;
using s7_01.Api.DataAccess.Models;
using System.Linq.Expressions;

namespace s7_01.Api.Contracts.Services
{
    public interface IHistoriaClinicaService
    {
        Task<ResponseDTO> GetByIdAsync(int id);
        Task<ResponseDTO> GetAllAsync();
        Task<ResponseDTO> FindAsync(Expression<Func<HistoriaClinica, bool>> expression);
        Task<ResponseDTO> AddAsync(CreateHistoriaClinicaDTO createHistoriaClinicaDTO);
        Task<ResponseDTO> AddRangeAsync(IEnumerable<CreateHistoriaClinicaDTO> createHistoriaClinicaDTOs);
        Task<ResponseDTO> RemoveAsync(int historiaClinicaId);
        Task<ResponseDTO> UpdateAsync(int id, CreateHistoriaClinicaDTO createHistoriaClinicaDTO);
        ResponseDTO RemoveRangeAsync(IEnumerable<GetHistoriaClinicaDTO> getHistoriaClinicaDTOs);

        Task<ResponseDTO> GetHistoriaClinicaByMascotaId(int mascotaId);
    }
}
