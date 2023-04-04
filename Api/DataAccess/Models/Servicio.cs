using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace s7_01.Api.DataAccess.Models
{
    public class Servicio
    {
        public int Id { get; set; }

        public int VeterinariaId { get; set; }

        public Veterinaria Veterinaria { get; set; }

        [Column(TypeName = "DECIMAL(11,2)")]
        public decimal Costo { get; set; }

        public string Nombre { get; set; }
    }
}
