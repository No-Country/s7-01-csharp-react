using Microsoft.AspNetCore.Mvc;
using s7_01.Api.Common.DTO;
using s7_01.Api.Common.DTOs.ProductoDTOs;
using s7_01.Api.Contracts.Services;

namespace s7_01.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoService _productoService;

        public ProductoController(IProductoService productoService)
        {
            _productoService = productoService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProductosAsync()
        {
            var response = await _productoService.GetAllProductosAsync();

            if (!response.Success)
            {
                return StatusCode(response.StatusCode, response.Message);
            }

            return Ok(response.Result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductoByIdAsync(int id)
        {
            var response = await _productoService.GetProductoByIdAsync(id);

            if (!response.Success)
            {
                return StatusCode(response.StatusCode, response.Message);
            }

            return Ok(response.Result);
        }

        [HttpPost]
        public async Task<IActionResult> AddProductoAsync(ProductoDTO productoDto)
        {
            var response = await _productoService.AddProductoAsync(productoDto);

            if (!response.Success)
            {
                return StatusCode(response.StatusCode, response.Message);
            }

            return Ok(response.Result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProductoAsync(int id, ProductoDTO productoDto)
        {
            var response = await _productoService.UpdateProductoAsync(id, productoDto);

            if (!response.Success)
            {
                return StatusCode(response.StatusCode, response.Message);
            }

            return Ok(response.Result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductoAsync(int id)
        {
            var response = await _productoService.DeleteProductoAsync(id);

            if (!response.Success)
            {
                return StatusCode(response.StatusCode, response.Message);
            }

            return Ok(response.Result);
        }
    }

}
