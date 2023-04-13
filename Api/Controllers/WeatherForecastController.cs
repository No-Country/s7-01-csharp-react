using Microsoft.AspNetCore.Mvc;
using s7_01.Api.Contracts.Repositories;
using s7_01.Api.DataAccess;
using s7_01.Api.DataAccess.Models;
using s7_01.Api.Repositories;
using s7_01.Api.Services.Email;
using static System.Net.Mime.MediaTypeNames;

namespace s7_01.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly VeterinariaContext _context;        
        private readonly IVeterinariaRepository _vetrepo;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, VeterinariaContext context, IVeterinariaRepository vetrepo)

        //private readonly IEmailService _emailService;

     //   public WeatherForecastController(ILogger<WeatherForecastController> logger, VeterinariaContext context, IMascotaPropietarioRepository repo, IEmailService emailService)
        {
            _logger = logger;
            _context = context;            
         //   _vetrepo = vetrepo;

          //  _emailService = emailService;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {

            #region Crear-MascotaPropietarioRepository
            //para prueba
            //var repo = new MascotaPropietarioRepository(_context);

            //var propietario = new Propietario()
            //{
            //    Direccion = new Direccion()
            //    {
            //        Numero = "number",
            //        Calle = "calle",
            //        Ciudad = "ciudad",
            //        Pais = "Pais",

            //    },
            //    DNI = "",
            //    Email = "some@some.com",
            //    Nombre = "name"
            //};
            //var mascota = new Mascota()
            //{
            //    FechaNacimento = DateTime.Now.AddYears(-1),
            //    Especie = "Canino",
            //    Nombre = "Firulais",
            //    Peso = 5,
            //    Sexo = "M", //Sexo.M
            //};
            //var propietarioMascota = new MascotaPropietario()
            //{
            //    EsPrincipal = true,
            //    Mascota = mascota,
            //    Propietario = propietario
            //};


            //_repo.Add(propietarioMascota);

            //var result = _context.SaveChanges(); 
            #endregion

            var vet = new Veterinaria
            {
                Telefono = "2321321",
                // PersonaResponsableId = 1,
                Nombre = "Veterinaria 1",
                CUIT = "CUIT",
                Email = "vet1@mailinator.com"
            };
            _context.Veterinarias.Add(vet);

            _context.Productos.Add(new Producto
            {
                Veterinaria = vet,
               // VeterinariaId = 2,
                Nombre = "Correa",
                Costo = 20
            });

            _context.Servicios.Add(new Servicio
            {
                Veterinaria = vet,
                Nombre = "Corte de pelo",
                Costo = 10,
               
            });

            _context.Servicios.Add(new Servicio
            {
                Veterinaria = vet,
                Nombre = "Extracción de muela",
                Costo = 20
            });


            _context.SaveChanges();

            



            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        /*
        [HttpGet("/sendEmail")]
        public IActionResult SendEmail(string message)
        {
            var msg = new Message(new[] {"vet@mailinator.com" }, "Mensaje de prueba",message);
            _emailService.SendEmail(msg);
            return Ok("vet@mailinator.com");
        }
        */
    }
}