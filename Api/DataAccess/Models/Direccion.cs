using System.ComponentModel.DataAnnotations;

namespace s7_01.Api.DataAccess.Models
{
    public class Direccion
    {
        [Key]
        public int Id { get; set; }
        public int IdPersona { get; set; }
        //public Persona Persona { get; set; }

        //TODO : podria ir en un solo string estas dos
        public string Calle { get; set; }

        public string Numero { get; set; }
       
        public string Ciudad { get; set; }

        public string Pais { get; set; }

        public int CodigoPostal { get; set; }
        //public int IdCiudad { get; set; }
        //public int IdPais { get; set; }
    }
}
