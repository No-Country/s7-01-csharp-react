using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace s7_01.Api.DataAccess.Models
{
    public class Tratamiento
    {
        [JsonIgnore]
        public int Id { get; set; }

        [JsonIgnore]
        public int HistoriaClinicaId { get; set; }

        [JsonIgnore]
        public HistoriaClinica HistoriaClinica { get; set; }

        [JsonIgnore]
        public int VeterinariaId { get; set; }

        [JsonIgnore]
        public Veterinaria Veterinaria { get; set; }

        public string NombreMedico { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
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
