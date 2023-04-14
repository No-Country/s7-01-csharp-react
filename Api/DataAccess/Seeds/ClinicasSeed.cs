using Microsoft.EntityFrameworkCore;
using s7_01.Api.DataAccess.Models;

namespace s7_01.Api.DataAccess.Seeds
{
    public static class ClinicasSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var data = new[]
            {
              new HistoriaClinica() {
                  Id =1,
                  MascotaId = 1,
                  Comentarios = "Displasia de cadera",
              },
              
            };

            modelBuilder.Entity<Mascota>().HasData(data);
        }
    }
}
