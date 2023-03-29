using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace s7_01.Api.DataAccess.Models
{
    public class CarnetVacuna
    {
        [Key]
        public int Id { get; set; }

        public int MascotaId { get; set; }
        public Mascota Mascota { get; set; }

        [Required] public string Nombre { get; set; }

        [Required] public string LoteSerial { get; set; }

        /// <summary>
        /// Define si la dosis es unica, considerando que si no lo es se deberia llenar la proxima aplicacion
        /// </summary>
        public bool EsDosisUnica { get; set; } = false;

        [Required] public DateTime FechaAplicacion { get; set; }

        public DateTime? ProximaAplicacion { get; set; }
    }
}
