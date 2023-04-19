using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace s7_01.Api.DataAccess.Models
{
    public class Vacuna
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string LoteSerial { get; set; }

        [JsonIgnore]
        [ForeignKey("HistoriaClinica")]
        public int HistoriaClinicaId { get; set; }

        [JsonIgnore]
        public HistoriaClinica HistoriaClinica { get; set; }

        public bool EsDosisUnica { get; set; } = false;

        [Required]
        public DateTime FechaAplicacion { get; set; }

        public DateTime? ProximaAplicacion { get; set; }
    }
}
