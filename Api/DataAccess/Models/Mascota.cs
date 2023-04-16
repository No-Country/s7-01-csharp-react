using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace s7_01.Api.DataAccess.Models
{
    public class Mascota
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Nombre { get; set; }
        [StringLength(15)]
        public string Sexo { get; set; }

    //    [StringLength(50)]
        public string Especie { get; set; } = "";

        public DateTime FechaNacimento { get; set; }

        [Column(TypeName = "DECIMAL(5,2)")]
        public decimal Peso { get; set; }

        //TODO : Deberia ir acá?
     //   public string Condiciones { get; set; }

        //public int PropietarioId { get; set; }
        //public virtual Propietario Propietario { get; set; } = new ();

    //    public virtual ICollection<Propietario> Mascotas { get; set; } = new List<Propietario>();

    }
}


