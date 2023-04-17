using Microsoft.AspNetCore.Mvc;
using s7_01.Api.Contracts.Repositories;
using s7_01.Api.DataAccess;
using s7_01.Api.DataAccess.Models;
using s7_01.Api.Repositories;
using s7_01.Api.Services.Email;
using s7_01.Api.DataAccess.Seeds;
using Microsoft.Data.Sql;
using Microsoft.EntityFrameworkCore;

namespace s7_01.Api.Controllers
{
    [Obsolete]
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly VeterinariaContext _context;
        private readonly IMascotaPropietarioRepository _repo;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, VeterinariaContext context, IMascotaPropietarioRepository repo)
        {
            _logger = logger;
            _context = context;
            _repo = repo;
        }

        [HttpGet("Get")]
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

            //var vet = new Veterinaria
            //{
            //    Telefono = "2321321",
            //    // PersonaResponsableId = 1,
            //    Nombre = "Veterinaria 1",
            //    CUIT = "CUIT",
            //    Email = "vet1@mailinator.com"
            //};
            //_context.Veterinarias.Add(vet);

            //_context.Productos.Add(new Producto
            //{
            //    Veterinaria = vet,
            //    // VeterinariaId = 2,
            //    Nombre = "Correa",
            //    Costo = 20
            //});

            //_context.Servicios.Add(new Servicio
            //{
            //    Veterinaria = vet,
            //    Nombre = "Extracción de muela",
            //    Costo = 20
            //});


            //_repo.Add(propietarioMascota);

            //var result = _context.SaveChanges();


            //var mascotas = _proprepo.GetMascotasByPropietarioId(1);


            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("SeedData")]
        public IActionResult SeedData()
        {
            FormattableString off = $"set identity_insert [dbo].[Mascotas] off\r\nset identity_insert [dbo].[Persona] off\r\nset identity_insert [dbo].[Historias] off\r\nset identity_insert [dbo].[Autorizaciones] off\r\nset identity_insert [dbo].[Direcciones] off\r\nset identity_insert [dbo].[Productos] off\r\nset identity_insert [dbo].[Recordatorios] off\r\nset identity_insert [dbo].[Servicios] off\r\nset identity_insert [dbo].[Tratamientos] off\r\nset identity_insert [dbo].[Vacunas] off";
            FormattableString on = $"set identity_insert [dbo].[Mascotas] on\r\nset identity_insert [dbo].[Persona] on\r\nset identity_insert [dbo].[Historias] on\r\nset identity_insert [dbo].[Autorizaciones] on\r\nset identity_insert [dbo].[Direcciones] on\r\nset identity_insert [dbo].[Productos] on\r\nset identity_insert [dbo].[Recordatorios] on\r\nset identity_insert [dbo].[Servicios] on\r\nset identity_insert [dbo].[Tratamientos] on\r\nset identity_insert [dbo].[Vacunas] on";
            //_context.Propietarios.AddRange(PropietariosSeed.GetData());

            //_context.SaveChanges();

            //_context.Mascotas.AddRange(MascotasSeed.GetData());
            //_context.SaveChanges();

            //_context.MascotaPropietarios.AddRange(MascotasPropietarioSeed.GetData());
            //_context.SaveChanges();


            //_context.Historias.AddRange(HistoriaClinicaSeed.GetData());
            //_context.SaveChanges();
            //_context.Veterinarias.AddRange((IEnumerable<Veterinaria>)ClinicasSeed.GetData());
            //_context.SaveChanges();
            //_context.Tratamientos.AddRange(TratamientosSeed.GetData());
            //_context.SaveChanges();

            //_context.Vacunas.AddRange(VacunasSeed.GetData());
            //_context.SaveChanges();

            //prueba direccion

            // var persona = new Veterinaria()
            // {
            //     Nombre = "SuperVetConDireccion",
            //  //   Direccion = direccion1,
            //     Email = "mivet@mailinator.com",
            //     CUIT = "13132",
            //     Telefono = "5511998765432",
            //     Whatsapp = "5511998765432",
            //     Instagram = "https://www.instagram.com/SuperVet",
            //     Facebook = "https://www.facebook.com/SuperVet",
            //     Twitter = "https://www.twitter.com/SuperVet",
            //     LogoURI = "https://placehold.co/400",
            //     RazonSocial = "SuperVet",
            // };

            // persona.Direccion = direccion1;

            // _context.Veterinarias.Add(persona);
            //var resul = _context.SaveChanges();

            // var per = _context.Veterinarias.Find(persona.Id);

            //var direccion1 = new Direccion()
            //{
            //    Calle = "54 Sanluis",
            //    Numero = "8555",
            //    CodigoPostal = 5465001,
            //    Ciudad = "Buenos Aires",
            //    Pais = "Argentina",
            //};

            //var direccion2 = new Direccion()
            //{
            //    Numero = "4516",
            //    Calle = "54 Sanluis",
            //    CodigoPostal = 5465001,
            //    Ciudad = "Buenos Aires",
            //    Pais = "Argentina"
            //};


            //var clinicas = ClinicasSeed.GetData();
            //direccion1.Persona = clinicas.First();
            //direccion2.Persona = clinicas.Last();

            //var props = PropietariosSeed.GetData();

            //var mascotas = MascotasSeed.GetData();
            //var owner = new MascotaPropietario() { EsPrincipal = true, Mascota = mascotas.First(), Propietario = props.First() };

            //var historia = HistoriaClinicaSeed.GetData();
            //var vacunas = VacunasSeed.GetData();
            //var tratamientos = TratamientosSeed.GetData();
            //tratamientos.ForEach( x => x.Veterinaria = clinicas.First() );
            //tratamientos.ForEach( x => x.HistoriaClinica = historia.First() );
            //historia.First().Mascota = mascotas.First();
            //historia.First().Vacunas = vacunas.ToList();
            //historia.First().Tratamientos = tratamientos.ToList();

            //_context.Propietarios.AddRange(props);            
            //_context.Veterinarias.AddRange(clinicas);
            //_context.Direcciones.Add(direccion2);
            //_context.Direcciones.Add(direccion1);
            //_context.Mascotas.AddRange(mascotas);
            //_context.MascotaPropietarios.Add(owner);
            //_context.Historias.Add(historia.First());

            //_context.SaveChanges();

            //      _context.Database.ExecuteSql(on);
            //      _context.SaveChanges();
            //_context.Database.ExecuteSql(off);





            return Ok(true);
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