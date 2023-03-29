namespace s7_01.Api.DataAccess.Models
{
    public class Producto
    {
        public int Id { get; set; }

        /// <summary>
        /// Bien o servicio
        /// </summary>
        public string Tipo { get; set; }

        public int VeterinariaId { get; set; }

        public Veterinaria Veterinaria { get; set; }

        public decimal Costo { get; set; }

        public string Nombre { get; set; }

    }
}
