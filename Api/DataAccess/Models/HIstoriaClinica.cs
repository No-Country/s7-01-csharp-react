using System.ComponentModel.DataAnnotations.Schema;

namespace s7_01.Api.DataAccess.Models
{
    public class HistoriaClinica
    {
        public int Id { get; set; }

        [ForeignKey("Mascota")]
        public int MascotaId { get; set; }

        public Mascota Mascota { get; set; }

        public string? Comentarios { get; set; }

        public virtual ICollection<Vacuna> Vacunas { get; } = new List<Vacuna>(); // carnet de vacunas 
        public virtual ICollection<Tratamiento> Tratamientos { get; } = new List<Tratamiento>();
    }
}
