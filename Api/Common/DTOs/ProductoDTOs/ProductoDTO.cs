namespace s7_01.Api.Common.DTOs.ProductoDTOs
{
    public class ProductoDTO
    {
        public int Id { get; set; }
        public int VeterinariaId { get; set; }
        public string VeterinariaNombre { get; set; }
        public decimal Costo { get; set; }
        public string Nombre { get; set; }
    }
}
