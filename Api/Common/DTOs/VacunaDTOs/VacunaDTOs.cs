using System.Text.Json.Serialization;

namespace s7_01.Api.Common.DTOs.VacunaDTOs;

public class VacunaDTO
{
    [JsonIgnore]
    public int VacunaId { get; set; }
    public string Nombre { get; set; }
    public string LoteSerial { get; set; }
    public int HistoriaClinicaId { get; set; }
    public bool EsDosisUnica { get; set; }
    public DateTime FechaAplicacion { get; set; }
    public DateTime ProximaAplicacion { get; set; }
}
