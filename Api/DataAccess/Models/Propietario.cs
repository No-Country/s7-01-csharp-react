using System.ComponentModel.DataAnnotations;
using s7_01.Api.DataAccess.Interfaces;

namespace s7_01.Api.DataAccess.Models
{
    public class Propietario : Persona
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string   Email { get; set; }

        //[Required]
        //public bool EsPrincipal { get; set; } = false;
        //   public virtual ICollection<Mascota> Mascotas { get; set; } = new List<Mascota>();

    }
}
