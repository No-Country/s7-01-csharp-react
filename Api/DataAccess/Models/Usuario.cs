using System.ComponentModel.DataAnnotations;

namespace s7_01.Api.DataAccess.Models
{
    public class Usuario : Persona
    {
        [Required]
        public string Password { get; set; }
        public int IdRole { get; set; }
        public Role Role { get; set; }
    }
}
