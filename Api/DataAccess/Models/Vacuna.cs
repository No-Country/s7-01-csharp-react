using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace s7_01.Api.DataAccess.Models
{
    public class Vacuna
    {
        [Key]
        public int Id { get; set; }

        public int MascotaId { get; set; }
        public Mascota Mascota { get; set; }

        [Required] public string Nombre { get; set; }

        [Required] public string LoteSerial { get; set; }

        public int HistoriaClinicaId { get; set; }

        public HistoriaClinica HistoriaClinica { get; set; }

        public bool EsDosisUnica { get; set; } = false;

        [Required] public DateTime FechaAplicacion { get; set; }

        public DateTime? ProximaAplicacion { get; set; }
    }
}
