using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace s7_01.Api.Common.DTOs.MascotaDTOs
{
    public class MascotaDTO
    { 
        public string Nombre { get; set; }

        public string Sexo { get; set; }

        public string Especie { get; set; }

        public DateTime FechaNacimento { get; set; }

        public decimal Peso { get; set; }
    }
}
