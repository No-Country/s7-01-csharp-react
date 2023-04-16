using s7_01.Api.DataAccess.Models;

namespace s7_01.Api.DataAccess.Seeds
{
    public class RecordatoriosSeed
    {
        public static List<Recordatorio> data { get; set; }
        public static IEnumerable<Recordatorio> GetData()
        {
            return new List<Recordatorio>();
        }
    }
}
