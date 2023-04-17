using s7_01.Api.DataAccess.Models;

namespace s7_01.Api.DataAccess.Seeds
{
    public class RecordatoriosSeed
    {
        public static List<Recordatorio> data { get; set; }
        public static IEnumerable<Recordatorio> GetData()
        {
            var recordatorios = new List<Recordatorio>()
            {
                        new Recordatorio()
                        {
                            DiasPreviosNotificacion = 3,
                            FechaNotificacion = new DateTime(2022,04,15).AddDays(15),
                            Mensaje = "Recuerda: Seguir le plán de vacunación de tu mascota es fundamental. Acercate a tu veterinaria de confiana para la aplicacíon de la proxima dosis"

                        },
                         new Recordatorio()
                        {
                            DiasPreviosNotificacion = 3,
                            FechaNotificacion = new DateTime(2022,04,15).AddDays(43),
                            Mensaje = "Recuerda: Seguir le plán de vacunación de tu mascota es fundamental. Acercate a tu veterinaria de confiana para la aplicacíon de la proxima dosis"

                        },
                        new Recordatorio()
                        {
                            DiasPreviosNotificacion = 3,
                            FechaNotificacion = new DateTime(2022,04,15).AddDays(71),
                            Mensaje = "Recuerda: Seguir le plán de vacunación de tu mascota es fundamental. Acercate a tu veterinaria de confiana para la aplicacíon de la proxima dosis"

                        },
             };
            return recordatorios;

        }
    }
}
