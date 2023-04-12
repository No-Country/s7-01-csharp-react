using s7_01.Api.DataAccess.Models;
using s7_01.Api.DataAccess;

namespace s7_01.Api.Repositories
{
    public class ServicioRepository : GenericRepository<Servicio>
    {
        public ServicioRepository(VeterinariaContext _context) : base(_context)
        {

        }
    }
}
