using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace s7_01.Api.DataAccess.Models
{
    public class Veterinaria : Persona
    {

        public int? PersonaResponsableId { get; set; }
        [ForeignKey("PersonaResponsableId")]
        public Persona? PersonaResponsable { get; set; }

        public string LogoURI { get; set; }

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




    }
}
