using s7_01.Api.DataAccess.Models;
using System.Text.Json.Serialization;

namespace s7_01.Api.Common.DTOs.TratamientoDTOs;

public class TratamientoDTO
{
    [JsonIgnore]
    public int TratamientoId { get; set; }
    public int HistoriaClinicaId { get; set; }
    public int VeterinariaId { get; set; }
    public string NombreMedico { get; set; }
    public TipoTratamiento TipoTratamiento { get; set; }
    public string DosisMedicamento { get; set; }
    public string Observaciones { get; set; }
    public DateTime Fecha { get; set; }
}