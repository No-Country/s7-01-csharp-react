using s7_01.Api.DataAccess.Models;

namespace s7_01.Api.Common.DTOs.AutorizacionDTOs
{
    public class CreateAutorizacionDTO
    {

        public int MascotaId { get; set; }

        public int VeterinariaId { get; set; }

        public DateTime FechaAutorizacion { get; set; }

        public bool EsActiva { get; set; }
    }
}
