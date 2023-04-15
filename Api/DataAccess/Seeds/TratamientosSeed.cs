﻿using Microsoft.EntityFrameworkCore;
using s7_01.Api.DataAccess.Models;

namespace s7_01.Api.DataAccess.Seeds
{
    public static class TratamientosSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var data = new[]
            {
              new Tratamiento() {
                  Id =1,
                  HistoriaClinicaId = 1,
                  VeterinariaId = 1,
                  Observaciones = "Ingresa Canino de raza pug de 6 semanas de edad, 300 gramos de peso, recien destetado, parto de 6 , primera revision, evidencia buen estado de salud, formacion osea, sentidos .inicio plan de vacunación, se aplica triple viral  CANIGEN® MHA2 PUPPY, se dan recomendaciones generales, se programa alerta para proxima vacuna x  polivalente para la 8va semana",
                  TipoTratamiento = TipoTratamiento.Desparasitación,
                  //Fecha = 
              },
                 new Tratamiento() {
                  Id =2,
                  HistoriaClinicaId = 1,
                  VeterinariaId = 1,
                  Observaciones = "Ingresa Canino de raza pug de 8 semanas de edad, 350 gramos de peso,  evidencia buen estado de salud,asiste para seguimiento plan de vacunacion, se aplica polivalente  , se aplica Nobivac® DHPPI, se dan recomendaciones generales, se programa alerta para proxima vacuna x refuerzo polivalente para la 12va semana",
                  TipoTratamiento = TipoTratamiento.Desparasitación,
                  //Fecha = 
              },
                   new Tratamiento() {
                  Id =3,
                  HistoriaClinicaId = 1,
                  VeterinariaId = 1,
                  Observaciones = "Ingresa Canino de raza pug de 12 semanas de edad, 500 gramos de peso, evidencia buen estado de salud, seguimiento plan de vacunacion, se aplica  refuerzo polivalente  , se aplica Nobivac® DHPPI, se dan recomendaciones generales, se programa alerta para proxima vacuna rabia a 1 año de edad",
                  TipoTratamiento = TipoTratamiento.Desparasitación,
                  //Fecha = 
              },
                  new Tratamiento() {
                  Id =3,
                  HistoriaClinicaId = 1,
                  VeterinariaId = 1,
                  Observaciones = "Ingresa Canino de raza pug de 52 semanas de edad, 2450 gramos de peso, propietatio manifiesta se rasca continuevmente orea derecha, descarta otitis, se realiza aseo" +
                  "con alcohol + agua, se dan recomendaciones asepsia para aseo, por lo demas goza buen estado de salud,  seguimiento plan de vacunacion, se aplica  refuerzo polivalente  , se aplica Nobivac® Rabia, se dan recomendaciones generales, se programa alerta para proxima vacuna refuerzo rabia a 2 año de edad",
                  TipoTratamiento = TipoTratamiento.Desparasitación,
                  //Fecha = 
              },

            };

            modelBuilder.Entity<Mascota>().HasData(data);
        }
    }
}