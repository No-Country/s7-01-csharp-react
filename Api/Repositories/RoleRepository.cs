using Microsoft.EntityFrameworkCore;
using s7_01.Api.Contracts.Repositories;
using s7_01.Api.DataAccess;
using s7_01.Api.DataAccess.Models;
using System.Linq.Expressions;

namespace s7_01.Api.Repositories
{
    public class RoleRepository : GenericRepository<Role> , IRoleRepository
    {
        public RoleRepository(VeterinariaContext context) : base(context)
        {
        }

        public async Task<Role> FindRoleName(Expression<Func<Role, bool>> expression)
        {
            return await _context.Set<Role>().Where(expression).FirstOrDefaultAsync();
        }
    }
}
