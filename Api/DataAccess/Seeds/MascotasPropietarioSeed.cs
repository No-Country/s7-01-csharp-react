using Microsoft.EntityFrameworkCore;
using s7_01.Api.DataAccess.Models;

namespace s7_01.Api.DataAccess.Seeds
{
    public static class MascotasPropietarioSeed
    {
        public static List<MascotaPropietario> data;
        public static void Seed(ModelBuilder modelBuilder)
        {

        }

        public static IEnumerable<MascotaPropietario> GetData()
        {
            var data = new[]
          {
                new MascotaPropietario() {
                    EsPrincipal = true,
                    MascotaId = 1,
                    PropietarioId = 1,
                },
                 new MascotaPropietario() {
                    EsPrincipal = true,
                    MascotaId = 2,
                    PropietarioId = 1,
                },
                  new MascotaPropietario() {
                    EsPrincipal = true,
                    MascotaId = 3,
                    PropietarioId = 1,
                },
                    new MascotaPropietario() {
                    EsPrincipal = true,
                    MascotaId = 4,
                    PropietarioId = 2,
                },
            };
            return data;
        }
    }
}
