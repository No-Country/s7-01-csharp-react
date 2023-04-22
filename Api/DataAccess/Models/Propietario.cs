using System.ComponentModel.DataAnnotations;
using s7_01.Api.DataAccess.Interfaces;

namespace s7_01.Api.DataAccess.Models
{
    public class Propietario : Persona
    {
        public string DNI { get; set; }

        public string URLFotoPerfil { get; set; }
    }
}
