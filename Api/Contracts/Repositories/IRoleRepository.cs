using s7_01.Api.DataAccess.Models;
using System.Linq.Expressions;

namespace s7_01.Api.Contracts.Repositories
{
    public interface IRoleRepository : IGenericRepository<Role>
    {
        Task<Role> FindRoleName (Expression<Func<Role, bool>> expression);
    }
}
