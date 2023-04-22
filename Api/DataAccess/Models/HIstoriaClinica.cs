using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace s7_01.Api.DataAccess.Models
{
    public class HistoriaClinica
    {
        public int Id { get; set; }

        [ForeignKey("Mascota")]
        public int MascotaId { get; set; }

        [JsonIgnore]
        public Mascota Mascota { get; set; }

        public string? Comentarios { get; set; }

        public virtual ICollection<Vacuna> Vacunas { get; set; } = new List<Vacuna>(); // carnet de vacunas 
        public virtual ICollection<Tratamiento> Tratamientos { get; set; } = new List<Tratamiento>();
    }
}
