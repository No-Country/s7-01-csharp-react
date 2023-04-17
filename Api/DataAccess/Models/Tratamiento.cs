using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace s7_01.Api.DataAccess.Models
{
    public class Tratamiento
    {
        public int Id { get; set; }

        [JsonIgnore]
        public int HistoriaClinicaId { get; set; }

        [JsonIgnore]
        public HistoriaClinica HistoriaClinica { get; set; }
       
        public int VeterinariaId { get; set; }

        public Veterinaria Veterinaria { get; set; }

        public string NombreMedico { get; set; }

        public TipoTratamiento TipoTratamiento { get; set; }

        public string DosisMedicamento { get; set; }

        public string Observaciones { get; set; }
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
