using System.Linq.Expressions;

namespace s7_01.Api.Contracts.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> expression);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
        Task UpdateAsync(T entity);
        Task<int> SaveAsync();
    }
}
