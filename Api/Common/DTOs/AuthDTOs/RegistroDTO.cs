using System.ComponentModel.DataAnnotations;

namespace s7_01.Api.Common.DTOs.AuthDTOs
{
    public class RegistroDTO
    {
        [Required]
        public string Nombre { get; set; }
        [Required]
        [MinLength(6)]
        [MaxLength(12)]
        public string Password { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
