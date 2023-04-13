using s7_01.Api.Contracts.Repositories;
using s7_01.Api.DataAccess;
using s7_01.Api.DataAccess.Models;

namespace s7_01.Api.Repositories
{
    public class MascotaRepository : GenericRepository<Mascota>, IMascotaRepository
    {
        public MascotaRepository(VeterinariaContext context) : base(context)
        {
        }
    }

}
