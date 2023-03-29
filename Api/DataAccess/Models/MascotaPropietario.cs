using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace s7_01.Api.DataAccess.Models
{
    [PrimaryKey(nameof(MascotaId), nameof(PropietarioId))]
    public class MascotaPropietario
    {
        public bool  EsPrincipal { get; set; }

        [Column(Order = 0)]
        public int MascotaId { get; set; }

        [Column(Order = 1)]
        public int PropietarioId { get; set; }

        public Mascota Mascota { get; set; }

        public Propietario Propietario { get; set; }
    }
}
