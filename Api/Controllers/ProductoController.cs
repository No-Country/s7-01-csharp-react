using Microsoft.AspNetCore.Mvc;
using s7_01.Api.Common.DTO;
using s7_01.Api.Contracts.Services;

namespace s7_01.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoService _productoService;

        public ProductoController(IProductoService productoService)
        {
            _productoService = productoService;
        }

        [HttpGet("ProductosList")]
        public ActionResult<ResponseDTO> GetAllProductos()
        {
            var response = _productoService.GetAllProductos();
            return Ok(response);
        }

        [HttpGet("Productos/{id}")]
        public ActionResult<ResponseDTO> GetProductoById(int id)
        {
            var response = _productoService.GetProductoById(id);
            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return NotFound(response);
            }
        }

        [HttpPost("Productos")]
        public ActionResult<ResponseDTO> AddProducto([FromBody] ProductoDTO productoDTO)
        {
            var response = _productoService.AddProducto(productoDTO);
            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response);
            }
        }

        [HttpPut("Productos/{id}")]
        public ActionResult<ResponseDTO> UpdateProducto(int id, [FromBody] ProductoDTO productoDTO)
        {
            var response = _productoService.UpdateProducto(id, productoDTO);
            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response);
            }
        }

        [HttpDelete("Productos/{id}")]
        public ActionResult<ResponseDTO> DeleteProducto(int id)
        {
            var response = _productoService.DeleteProducto(id);
            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response);
            }
        }
    }
}
