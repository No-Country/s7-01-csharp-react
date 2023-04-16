using Microsoft.EntityFrameworkCore;
using s7_01.Api.Contracts.Repositories;
using s7_01.Api.DataAccess;
using s7_01.Api.DataAccess.Models;
using System.Linq.Expressions;

namespace s7_01.Api.Repositories
{
    public class UsuarioRepository : GenericRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(VeterinariaContext _context) : base(_context)
        {

        }
        public async Task<Usuario> FindEmail(Expression<Func<Usuario, bool>> expression)
        {
            return await _context.Set<Usuario>().Where(expression).FirstOrDefaultAsync();
        }
    }
}
