using System.ComponentModel.DataAnnotations.Schema;

namespace s7_01.Api.DataAccess.Models
{
    public class HistoriaClinica
    {
        public int Id { get; set; }

        public int MascotaId { get; set; }
        [ForeignKey("MascotaId")]
        public Mascota Mascota { get; set; }

        public int CarnetVacunasId { get; set; }

        public string? Comentarios { get; set; }

        public virtual ICollection<Tratamiento> Tratamientos { get; } = new List<Tratamiento>();
    }
}
