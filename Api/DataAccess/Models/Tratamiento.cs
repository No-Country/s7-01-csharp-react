using System.ComponentModel.DataAnnotations.Schema;

namespace s7_01.Api.DataAccess.Models
{
    public class Tratamiento
    {
        public int Id { get; set; }
       
        public int HistoriaClinicaId { get; set; }

        public HistoriaClinica HistoriaClinica { get; set; }
       
        public int VeterinariaId { get; set; }

        public Veterinaria Veterinaria { get; set; }

        public string NombreMedico { get; set; }

        public TipoTratamiento TipoTratamiento { get; set; }

        public string DosisMedicamento { get; set; }

        public string Observaciones { get; set; }

        public DateTime Fecha { get; set; } 
    }

    
    
    public enum TipoTratamiento
    {
        Cirugías,
        Radiología,
        Análisis,
        CuidadoDental,
        Desparasitación,
        MicroChip,
        Ultrasonidos
    }
}
