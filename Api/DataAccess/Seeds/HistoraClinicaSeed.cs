using s7_01.Api.DataAccess.Models;

namespace s7_01.Api.DataAccess.Seeds
{
    public class HistoriaClinicaSeed
    {
        public static IEnumerable<HistoriaClinica> GetData()
        {
            var historia = new HistoriaClinica()
            {
               // Id = 1,
                MascotaId = 4,
                Comentarios = "Pug"
            };

            var data = new List<HistoriaClinica>();
               data .Add(historia);

            return data;
        }
    }
}
