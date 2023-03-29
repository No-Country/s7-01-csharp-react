namespace s7_01.Api.DataAccess.Models
{
    public class Tratamiento
    {
        public int Id { get; set; }

        public int MascotaId { get; set; }

        public Mascota Mascota { get; set; }

        public int VeterinariaId { get; set; }

        public Veterinaria Veterinaria { get; set; }

        public string NombreMedico { get; set; }

        public int TipoTratamiento { get; set; }

        public string DosisMedicamento { get; set; }

        public string Observaciones { get; set; }
    }
}
