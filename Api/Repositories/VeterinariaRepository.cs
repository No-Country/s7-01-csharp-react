using Microsoft.EntityFrameworkCore;
using s7_01.Api.Contracts.Repositories;
using s7_01.Api.DataAccess;
using s7_01.Api.DataAccess.Models;

namespace s7_01.Api.Repositories
{
    public class VeterinariaRepository : GenericRepository<Veterinaria>, IVeterinariaRepository
    {     
        private readonly GenericRepository<Producto> _productsRepository;

        public VeterinariaRepository(VeterinariaContext _context) : base(_context)  
        {
            _productsRepository = new GenericRepository<Producto>(_context);
        }

        public IEnumerable<Producto> GetProductosByVeterinariaId(int id)
        {

           var productos =  _productsRepository.Find( x => x.VeterinariaId == id).ToList();
           // var veterinaria = GetById(id);
           // var 

           //var vetProductos =  Find( x => x.Id == id).Select( x => x.Productos ); 

            return productos;
        }

        public IEnumerable<Servicio> GetServiciosByVeterinariaId(int id)
        {
            var veterinaria = GetById(id);

            return veterinaria.Servicios;
        }
    }
}
