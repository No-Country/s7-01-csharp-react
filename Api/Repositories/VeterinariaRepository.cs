using Microsoft.EntityFrameworkCore;
using s7_01.Api.Contracts.Repositories;
using s7_01.Api.DataAccess;
using s7_01.Api.DataAccess.Models;

namespace s7_01.Api.Repositories
{
    public class VeterinariaRepository : GenericRepository<Veterinaria>
    {           
        public VeterinariaRepository(VeterinariaContext _context) : base(_context)  
        {
            
        }                    
    }
}
