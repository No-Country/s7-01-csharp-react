using s7_01.Api.DataAccess.Models;
using System.ComponentModel.DataAnnotations;

namespace s7_01.Api.Common.DTOs.PropietarioDTOs
{
    public class CreatePropietarioDTO
    {
        public string Nombre { get; set; }

        public string DNI { get; set; }

        public Direccion? Direccion { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
