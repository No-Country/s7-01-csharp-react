using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace s7_01.Api.DataAccess.Models
{
    public class Direccion
    {
        [JsonIgnore]
        [Key]
        public int Id { get; set; }

        [JsonIgnore]
        public int IdPersona { get; set; }
        
        [JsonIgnore]
        [ForeignKey("IdPersona")]
        public Persona Persona { get; set; }

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
