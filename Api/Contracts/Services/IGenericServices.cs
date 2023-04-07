using System.Linq.Expressions;

namespace s7_01.Api.Contracts.Services
{
    public interface IGenericServices<T> where T : class
    {
        void Add(T entity);

        void AddRange(IEnumerable<T> entities);

        IEnumerable<T> Find(Expression<Func<T, bool>> expression);

        IEnumerable<T> GetAll();

        T GetById(int id);

        void Remove(T entity);

        void RemoveRange(IEnumerable<T> entities);
    }
}
