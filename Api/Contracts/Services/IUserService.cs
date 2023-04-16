using s7_01.Api.Common.DTOs.AuthDTOs;

namespace s7_01.Api.Contracts.Services
{
    public interface IUserService
    {
        Task<string> RegisterAsync(RegistroDTO model);
    }
}
