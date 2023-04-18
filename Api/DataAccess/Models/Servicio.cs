using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace s7_01.Api.DataAccess.Models
{
    public class Servicio
    {
        public int Id { get; set; }

        [ForeignKey("Veterinaria")]
        public int VeterinariaId { get; set; }

        [JsonIgnore]
        public Veterinaria Veterinaria { get; set; }        

        public string Nombre { get; set; }

        [Column(TypeName = "DECIMAL(11,2)")]
        public decimal Costo { get; set; }
    }
}
