namespace s7_01.Api.Common.DTOs.VacunaDTOs;

public class VacunaDTOs
{
    public record VacunaDTO(int VacunaId, string Nombre, string LoteSerial, int HistoriaClinicaId,
    bool EsDosisUnica, DateTime FechaAplicacion, DateTime ProximaAplicacion);
}
