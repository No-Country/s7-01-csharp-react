using System.ComponentModel.DataAnnotations;

namespace s7_01.Api.Common.DTOs.AuthDTOs
{
    public class LoginDTO
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MinLength(6)]
        [MaxLength(12)]
        public string Password { get; set; }
    }
}
