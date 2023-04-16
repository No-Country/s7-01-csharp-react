using Microsoft.EntityFrameworkCore;
using s7_01.Api.DataAccess.Models;
using System.Security.Cryptography.Xml;

namespace s7_01.Api.DataAccess.Seeds
{
    public static class PropietariosSeed
    {
        public static List<Propietario> data { get; set; }
        public static void Seed(ModelBuilder modelBuilder)
        {
            //var direccion =  new Direccion()
            var data = new[]
            {
              new Propietario() {
                  Id =1,
                  Nombre = "JOSE CUERVO",
                  Email = "jose.cuervo@mailinator.com",
                  DNI = "1001",
        //          Direccion = new Direccion() {Id = 1}
              },
               new Propietario() {
                  Id =2,
                  Nombre = "MONA LINARES",
                  Email = "MONA.LINARES@mailinator.com",
                  DNI = "1002",
           //       Direccion = new Direccion() {Id = 2}
              }

            };
            modelBuilder.Entity<Propietario>().HasData(data);
        }

        public static IEnumerable<Propietario> GetData()
        {
            var data = new[]
            {
                new Propietario()
                {
                    Direccion = new Direccion()
                    {
                        Numero = "524542455445",
                        Calle = "calle SanPedro 45",
                        Ciudad = "Buenos Aires",
                        Pais = "Argentina",
                  //      Id = 100,

                    },
                    DNI = "54878965",
                    Email = "jesus@somee.com",
                    Nombre = "Jesus Merchan"
                }
            };
          //  data.ToList().ForEach(x => x.Id = -1);
            return data;
        }
    }

}
