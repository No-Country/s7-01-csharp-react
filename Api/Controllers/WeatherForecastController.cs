﻿using Microsoft.AspNetCore.Mvc;
using s7_01.Api.Contracts.Repositories;
using s7_01.Api.DataAccess;
using s7_01.Api.DataAccess.Models;
using s7_01.Api.Repositories;

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
        private readonly IMascotaPropietarioRepository _repo;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, VeterinariaContext context, IMascotaPropietarioRepository repo)
        {
            _logger = logger;
            _context = context;
            _repo = repo;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {

            //para prueba
            //var repo = new MascotaPropietarioRepository(_context);
            var propietario = new Propietario()
            {
                Direccion = new Direccion()
                {
                    Numero = "number",
                    Calle = "calle",
                    Ciudad = "ciudad",
                    Pais = "Pais",

                },
                DNI = "",
                Email = "some@some.com",
                Nombre = "name"
            };
            var mascota = new Mascota()
            {
                FechaNacimento = DateTime.Now.AddYears(-1),
                Especie = "Canino",
                Nombre = "Firulais",
                Peso = 5,
                Sexo = "M", //Sexo.M
            };
            var propietarioMascota = new MascotaPropietario()
            {
                EsPrincipal = true,
                Mascota = mascota,
                Propietario = propietario
            };


            _repo.Add(propietarioMascota);

            var result = _context.SaveChanges();




            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}