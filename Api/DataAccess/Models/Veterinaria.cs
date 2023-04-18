using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace s7_01.Api.DataAccess.Models
{
    public class Veterinaria : Persona
    {
        public string RazonSocial { get; set; } // Ejemplo: Clinicucha SRL
                
        public string CUIT { get; set; } // Estructura: xx - xx xxx xxx - x ("x" son números, "-" son guiones). Ej: 29-15662874-9

        public string LogoURI { get; set; }   
        
        public string URLFotoPortada { get; set; }

        [Url]
        [DataType(DataType.Url)]
        public string? Facebook { get; set; }

        [Url]
        [DataType(DataType.Url)]
        public string? Instagram { get; set; }

        [Url]
        [DataType(DataType.Url)]
        public string? Twitter { get; set; }

        [Phone]
        [DataType(DataType.PhoneNumber)]
        public string? Whatsapp { get; set; }

        [Phone]
        [DataType(DataType.PhoneNumber)]
        [Required]
        public string Telefono { get; set; } //por si no tiene whatsapp

        public IEnumerable<Producto>? Productos { get; set; } = new List<Producto>();

        public IEnumerable<Servicio>? Servicios { get; set; } = new List<Servicio>();




    }
}
