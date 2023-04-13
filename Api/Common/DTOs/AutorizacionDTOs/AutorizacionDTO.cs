using s7_01.Api.DataAccess.Models;

namespace s7_01.Api.Common.DTOs.AutorizacionDTOs
{
    public class AutorizacionDTO
    {
        public int Id { get; set; }

        public int MascotaId { get; set; }

        public Mascota Mascota { get; set; }

        public int VeterinariaId { get; set; }

        public Veterinaria Veterinaria { get; set; }

        public DateTime FechaAutorizacion { get; set; }

        public bool EsActiva { get; set; }
    }
}
