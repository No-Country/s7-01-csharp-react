using Microsoft.EntityFrameworkCore;
using s7_01.Api.DataAccess.Models;

namespace s7_01.Api.DataAccess.Seeds
{
    public static class SeedGraph
    {
        public static bool Seed(VeterinariaContext _context)
        {
            var direccion1 = new Direccion()
            {
                Calle = "54 Sanluis",
                Numero = "8555",
                CodigoPostal = 5465001,
                Ciudad = "Buenos Aires",
                Pais = "Argentina",
            };

            var direccion2 = new Direccion()
            {
                Numero = "4516",
                Calle = "54 Sanluis",
                CodigoPostal = 5465001,
                Ciudad = "Buenos Aires",
                Pais = "Argentina"
            };


            var clinicas = ClinicasSeed.GetData();
            direccion1.Persona = clinicas.First();
            direccion2.Persona = clinicas.Last();

            var props = PropietariosSeed.GetData();

            var mascotas = MascotasSeed.GetData();
            var owner = new MascotaPropietario() { EsPrincipal = true, Mascota = mascotas.First(), Propietario = props.First() };

            var historia = HistoriaClinicaSeed.GetData();
            var vacunas = VacunasSeed.GetData();
            var tratamientos = TratamientosSeed.GetData();
            tratamientos.ForEach(x => x.Veterinaria = clinicas.First());
            tratamientos.ForEach(x => x.HistoriaClinica = historia.First());
            historia.First().Mascota = mascotas.First();
            historia.First().Vacunas = vacunas.ToList();
            historia.First().Tratamientos = tratamientos.ToList();

            _context.Propietarios.AddRange(props);
            _context.Veterinarias.AddRange(clinicas);
            _context.Direcciones.Add(direccion2);
            _context.Direcciones.Add(direccion1);
            _context.Mascotas.AddRange(mascotas);
            _context.MascotaPropietarios.Add(owner);
            _context.Historias.Add(historia.First());


            var recordatorios = Seeds.RecordatoriosSeed.GetData();
            recordatorios.ToList().ForEach(x => { x.Destinatario = props.First(); x.CreadorId = 1; });
            _context.Recordatorios.AddRange(recordatorios);
            _context.SaveChanges();

            return true;
        }


    }
}
