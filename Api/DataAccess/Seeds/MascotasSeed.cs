using Microsoft.EntityFrameworkCore;
using s7_01.Api.DataAccess.Models;

namespace s7_01.Api.DataAccess.Seeds
{
    public static class MascotasSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var data = new[]
            {
              new Mascota() {
                  Id =1,
                  Nombre = "FLOKY",
                  Peso=2.5m,
                  Especie = "CANINO",
                  FechaNacimento = new DateTime(2015,01,23),
                  Sexo = "MACHO",
              },
               new Mascota() {
                  Id =2,
                  Nombre = "GASPAR",
                  Peso=1,
                  Especie = "GATO",
                  FechaNacimento = new DateTime(2017,01,23),
                  Sexo = "MACHO",
              },
                new Mascota() {
                  Id =3,
                  Nombre = "ELO",
                  Peso=2,
                  Especie = "CANINO",
                  FechaNacimento = new DateTime(2021,01,23),
                  Sexo = "MACHO",
              },
                 new Mascota() {
                  Id =4,
                  Nombre = "LOTUS",
                  Peso=2,
                  Especie = "CANINO",
                  FechaNacimento = new DateTime(2010,01,23),
                  Sexo = "MACHO",
              }
            };

            modelBuilder.Entity<Mascota>().HasData(data);
        }
    }
}
