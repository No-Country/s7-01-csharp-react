using s7_01.Api.Common.DTO;
using s7_01.Api.Common.DTOs.AuthDTOs;

namespace s7_01.Api.Contracts.Services
{
    public interface IUserService
    {
        Task<ResponseDTO> RegisterAsync(RegistroDTO model);
        Task<ResponseDTO> LoginAsync(LoginDTO model);
    }
}
