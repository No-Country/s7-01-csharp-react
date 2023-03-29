namespace s7_01.Api.DataAccess.Models
{
    public class HistoriaClinica
    {
        public int Id { get; set; }

        //TODO No se sea relevante el propietario acá
        public int PropietarioId { get; set; }

        public int MascotaId { get; set; }

        public int CarnetVacunasId { get; set; }

        public string Comentarios { get; set; }

        public virtual ICollection<Tratamiento> Tratamientos { get; } = new List<Tratamiento>();
    }
}
