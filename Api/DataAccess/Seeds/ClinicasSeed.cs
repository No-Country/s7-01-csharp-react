using Microsoft.EntityFrameworkCore;
using s7_01.Api.DataAccess.Models;

namespace s7_01.Api.DataAccess.Seeds
{
    public static class ClinicasSeed
    {
        private static IEnumerable<Veterinaria> data;

        public static void Seed(ModelBuilder modelBuilder)
        {
            GetData();
            modelBuilder.Entity<Veterinaria>().HasData(data);
        }

        public static IEnumerable<Veterinaria> GetData()
        {
            var direccion1 = new Direccion()
            {
                Calle = "54 Sanluis",
                Numero = "8555",
                CodigoPostal = 5465001,
                Ciudad = "Buenos Aires",
                Pais = "Argentina"
            };

            var direccion2 = new Direccion()
            {
                Numero = "4516",
                Calle = "54 Sanluis",
                CodigoPostal = 5465001,
                Ciudad = "Buenos Aires",
                Pais = "Argentina"
            };

            data = new[]
            {
              new Veterinaria() {
       //           Id =1,
                 Direccion =direccion1,
                 Email = "mivet@mailinator.com",
                 Nombre = "SuperVet",
                 CUIT = "13132",
                 Telefono = "5511998765432",
                 Whatsapp = "5511998765432",
                 Instagram = "https://www.instagram.com/SuperVet",
                 Facebook = "https://www.facebook.com/SuperVet",
                 Twitter = "\"https://www.twitter.com/SuperVet",
                 LogoURI = "https://placehold.co/400",
                 RazonSocial = "SuperVet",

              },
               new Veterinaria() {
            //      Id =1,
                 Direccion =direccion2,
                 Email = "VetSanFrancisco@mailinator.com",
                 Nombre = "Veterinaria San Francisco SRL",
                 CUIT = "5000",
                 Telefono = "59891234567",
                 Whatsapp = "59891234567",
                 Instagram = "https://www.instagram.com/VetSanFrancisco",
                 Facebook = "https://www.facebook.com/VetSanFrancisco",
                 Twitter = "https://www.twitter.com/VetSanFrancisco",
                 LogoURI = "https://placehold.co/400",
                 RazonSocial = "Veterinaria San Francisco SRL"
              },

            };
       //     data.ToList().ForEach(x => x.Id = -1);
            return data;
        }
    }
}
