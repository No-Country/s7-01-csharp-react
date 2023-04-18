using Microsoft.VisualBasic;
using s7_01.Api.Common.DTOs.DireccionDTOs;
using s7_01.Api.Common.DTOs.ProductoDTOs;
using s7_01.Api.Common.DTOs.ServicioDTOs;
using s7_01.Api.DataAccess.Models;
using System.Net;
using System.Text.Json.Serialization;

namespace s7_01.Api.Common.DTOs.VeterinariaDTOs
{
    public class VeterinariaDTO
    {        
        public string Nombre { get; set; }
        public DireccionDTO Direccion { get; set; }
        public string RazonSocial { get; set; }
        public string CUIT { get; set; }
        public string Email { get; set; }
        public string LogoURI { get; set; }
        public string URLFotoPortada { get; set; }
        public string? Facebook { get; set; }
        public string? Instagram { get; set; }
        public string? Twitter { get; set; }
        public string? Whatsapp { get; set; }
        public string Telefono { get; set; }

        [JsonIgnore]
        public IEnumerable<ProductoDTO>? Productos { get; set; }
        [JsonIgnore]
        public IEnumerable<ServicioDTO>? Servicios { get; set; }
    } 




}
