using s7_01.Api.DataAccess.Models;

namespace s7_01.Api.DataAccess.Seeds
{
    public class VacunasSeed
    {
        public static List<Vacuna> data { get; set; }
        public void Seed()
        {

        }

        public static IEnumerable<Vacuna> GetData()
        {
            data = new List<Vacuna>()
                {
                    new Vacuna() {
                        //Id = 1,
                        EsDosisUnica =true,
                        FechaAplicacion = DateTime.Now.AddDays(-50),
                        Nombre = "CANIGEN® MHA2 PUPPY",
                        LoteSerial = "52JDJ34543F32-2",
                        HistoriaClinicaId =2
                    },
                     new Vacuna() {
                        //Id = 2,
                        EsDosisUnica =true,
                        FechaAplicacion = DateTime.Now.AddDays(-20),
                        Nombre = "Nobivac® DHPPI",
                        LoteSerial = "52JD562JF32-2",
                        HistoriaClinicaId =2
                    },
                      new Vacuna() {
                        //Id = 3,
                        EsDosisUnica =true,
                        FechaAplicacion = DateTime.Now.AddDays(-10),
                        Nombre = "Nobivac® DHPPI",
                        LoteSerial = "52JDJ533F32-2",
                        HistoriaClinicaId =2
                    },
                              new Vacuna() {
                        //Id = 4,
                        EsDosisUnica =true,
                        FechaAplicacion = DateTime.Now,
                        Nombre = "Nobivac® DHPPI",
                        LoteSerial = "52JDssaJF32-2",
                        HistoriaClinicaId =2
                    },

                };
          //  data.ToList().ForEach(x => x.Id = -1);
            return data;
        }
    }
}
