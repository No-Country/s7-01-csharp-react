using s7_01.Api.DataAccess.Models;

namespace s7_01.Api.Common.DTOs.TratamientoDTOs;

public class TratamientoDTOs
{
    public record TratamientoDTO(int TratamientoId, int HistoriaClinicaId,
        int VeterinariaId, string NombreMedico, TipoTratamiento TipoTratamiento,
        string DosisMedicamento, string Observaciones, DateTime Fecha);
}
