using System.ComponentModel.DataAnnotations;

namespace s7_01.Api.DataAccess.Models
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }

        public string Nombre { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public Direccion? Direccion { get; set; }
    }
}
