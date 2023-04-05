using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace s7_01.Api.DataAccess.Models
{
    public class Recordatorio
    {
        public int Id{ get; set; }

        public int CreadorId { get; set; }

        public int DestinatarioId { get; set; }

        public DateTime  FechaCreacion { get; set; } = DateTime.Now;

        public DateTime  FechaNotificacion { get; set; }

        public int DiasPreviosNotificacion { get; set; }

        public bool EsEmailEnviado { get; set; }

        public bool EsSMSEnviado { get; set; }

        public bool EsPushNotificationEnviada { get; set; }

        public string Mensaje { get; set; }

        public bool EsLeido { get; set; }
    }
}
