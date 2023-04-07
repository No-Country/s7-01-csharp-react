using Azure;
using s7_01.Api.Common.DTO;
using s7_01.Api.Common.Exceptions;
using s7_01.Api.Contracts.Repositories;
using s7_01.Api.Contracts.Services;
using s7_01.Api.DataAccess;
using s7_01.Pages;
using System.Linq.Expressions;

namespace s7_01.Api.Services
{
    public class GenericService<T> : IGenericServices<T> where T : class
    {
        private readonly VeterinariaContext _context;
        private readonly IGenericRepository<T> _genericRepository;

        public GenericService(IGenericRepository<T> genericRepository, VeterinariaContext context)
        {
            _genericRepository = genericRepository;
            _context = context;
        }

        public virtual void Add(T entity)
        {
            try
            {
                _genericRepository.Add(entity);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new ServicioExceptions("An error occurred while adding the entity.", ex);
            }
        }

        public virtual void AddRange(IEnumerable<T> entities)
        {
            try
            {
                _genericRepository.AddRange(entities);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new ServicioExceptions("An error occurred while adding the entities.", ex);
            }
        }

        public virtual IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            try
            {
                return _genericRepository.Find(expression);
            }
            catch (Exception ex)
            {
                throw new ServicioExceptions("An error occurred while finding the entities.", ex);
            }
        }

        public virtual IEnumerable<T> GetAll()
        {
            try
            {
                return _genericRepository.GetAll();
            }
            catch (Exception ex)
            {
                throw new ServicioExceptions("An error occurred while getting all the entities.", ex);
            }
        }

        public virtual T GetById(int id)
        {
            try
            {
                return _genericRepository.GetById(id);
            }
            catch (Exception ex)
            {
                throw new ServicioExceptions($"An error occurred while getting the entity with Id = {id}.", ex);
            }
        }

        public virtual void Remove(T entity)
        {
            try
            {
                _genericRepository.Remove(entity);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new ServicioExceptions("An error occurred while removing the entity.", ex);
            }
        }

        public virtual void RemoveRange(IEnumerable<T> entities)
        {
            try
            {
                _genericRepository.RemoveRange(entities);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new ServicioExceptions("An error occurred while removing the entities.", ex);
            }
        }

    }

}
