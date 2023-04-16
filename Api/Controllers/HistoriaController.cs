using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using s7_01.Api.DataAccess;
using s7_01.Api.DataAccess.Models;
using s7_01.Api.DataAccess.Seeds;

namespace s7_01.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoriaController : ControllerBase
    {

        private readonly VeterinariaContext _context;
        public HistoriaController(VeterinariaContext context)
        {
            _context = context;
        }

        //[HttpGet("{id}")]
        //public IActionResult GetById(int id)
        //{
        //    var mascota = new Mascota()
        //    {
        //        FechaNacimento = DateTime.Now,
        //        Especie = "especie",
        //        Nombre = "FLoky",
        //        Peso = 5.3m,
        //        Sexo = "M"

        //    };

        //    var vacunas = new List<Vacuna>()
        //    {
        //        new Vacuna() {
        //            Id = 1,
        //            EsDosisUnica =true,
        //            FechaAplicacion = DateTime.Now.AddDays(-50),
        //            Nombre = "CANIGEN® MHA2 PUPPY",
        //            LoteSerial = "52JDJ34543F32-2",
        //        },
        //         new Vacuna() {
        //            Id = 1,
        //            EsDosisUnica =true,
        //            FechaAplicacion = DateTime.Now.AddDays(-20),
        //            Nombre = "Nobivac® DHPPI",
        //            LoteSerial = "52JD562JF32-2",
        //        },
        //          new Vacuna() {
        //            Id = 1,
        //            EsDosisUnica =true,
        //            FechaAplicacion = DateTime.Now.AddDays(-10),
        //            Nombre = "Nobivac® DHPPI",
        //            LoteSerial = "52JDJ533F32-2",
        //        },
        //                  new Vacuna() {
        //            Id = 1,
        //            EsDosisUnica =true,
        //            FechaAplicacion = DateTime.Now,
        //            Nombre = "Nobivac® DHPPI",
        //            LoteSerial = "52JDssaJF32-2",
        //        },

        //    };
        //    var historia = new HistoriaClinica()
        //    {
        //        Mascota = mascota,
        //        Tratamientos = TratamientosSeed.GetData(),
        //        Vacunas = vacunas
        //    };


        //    //_context.Tratamientos.AddRange();
        //    //_context.SaveChanges();


        //    return Ok(historia);
        //}
    }
}
