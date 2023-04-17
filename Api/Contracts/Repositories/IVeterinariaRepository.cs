using Microsoft.EntityFrameworkCore;
using s7_01.Api.DataAccess.Models;

namespace s7_01.Api.Contracts.Repositories
{
    public interface IVeterinariaRepository
    {
        Task<IEnumerable<Veterinaria>> GetAllVetAsync();

        Task<Veterinaria> GetVetByIdAsync(int id);

    }    
}
