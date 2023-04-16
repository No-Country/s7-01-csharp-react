using s7_01.Api.DataAccess.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace s7_01.Api.Common.DTOs.HistoriaClinicaDTOs
{
    public class CreateHistoriaClinicaDTO
    {
        [Required]
        public int MascotaId { get; set; }
        public string? Comentarios { get; set; }
    }
}
