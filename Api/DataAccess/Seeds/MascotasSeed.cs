using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Security;
using s7_01.Api.DataAccess.Models;

namespace s7_01.Api.DataAccess.Seeds
{
    public static class MascotasSeed
    {
        public static IEnumerable<Mascota> data { get; set; }
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mascota>().HasData(data);
        }

        public static IEnumerable<Mascota> GetData()
        {
            data = new[]
           {
              new Mascota() {
                  Id =1,
                  Nombre = "FLOKY",
                  Peso=2.5m,
                  Especie = "CANINO",
                  FechaNacimento = new DateTime(2022,04,15).AddDays(-41),
                  Sexo = "MACHO",
                  URLFotoPerfil = "https://ichef.bbci.co.uk/news/800/cpsprodpb/14EC6/production/_124820758_pug1.jpg"
              },
               new Mascota() {
                  Id =2,
                  Nombre = "GASPAR",
                  Peso=1,
                //  Especie = "GATO",
                  FechaNacimento = new DateTime(2017,01,23),
                  Sexo = "MACHO",
                  URLFotoPerfil = "https://http2.mlstatic.com/D_NQ_NP_937599-MCO27610185417_062018-O.jpg"
              },
                new Mascota() {
                  Id =3,
                  Nombre = "ELO",
                  Peso=2,
              //    Especie = "CANINO",
                  FechaNacimento = new DateTime(2021,01,23),
                  Sexo = "MACHO",
                  URLFotoPerfil = "https://www.petdarling.com/wp-content/uploads/2015/07/cuanto-vive-un-gato-persa.jpg"
              },
                 new Mascota() {
                  Id =4,
                  Nombre = "LOTUS",
                  Peso=2,
                //  Especie = "CANINO",
                  FechaNacimento = new DateTime(2010,01,23),
                  Sexo = "MACHO",
                  URLFotoPerfil = "https://i0.wp.com/blog.mascotaysalud.com/wp-content/uploads/2019/05/PASTOR-BELGA.jpg?fit=865%2C540&ssl=1"

              }
            };
            data.ToList().ForEach(x => x.Id = 0);
            return data;
        }
    }
}
