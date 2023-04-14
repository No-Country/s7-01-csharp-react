using Microsoft.AspNetCore.Mvc;
using s7_01.Api.Common.DTOs.ServicioDTOs;
using s7_01.Api.Contracts.Services;
using s7_01.Api.Services;

namespace s7_01.Api.Controllers
{
    [ApiController]
    [Route("api/servicios")]
    public class ServicioController : ControllerBase
    {
        private readonly IServicioService _servicioService;

        public ServicioController(IServicioService servicioService)
        {
            _servicioService = servicioService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllServiciosAsync()
        {
            var response = await _servicioService.GetAllServiciosAsync();

            if (!response.Success)
            {
                return StatusCode(response.StatusCode, response.Message);
            }

            return Ok(response.Result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetServicioByIdAsync(int id)
        {
            var response = await _servicioService.GetServicioByIdAsync(id);

            if (!response.Success)
            {
                return StatusCode(response.StatusCode, response.Message);
            }

            return Ok(response.Result);
        }

        [HttpGet("{id}/servicios")]
        public async Task<IActionResult> GetServiciosByVeterinariaIdAsync(int id)
        {
            var response = await _servicioService.GetServiciosByVeterinariaIdAsync(id);

            return StatusCode(response.StatusCode, response);
        }

        [HttpPost]
        public async Task<IActionResult> AddServicioAsync(ServicioDTO servicioDto)
        {
            var response = await _servicioService.AddServicioAsync(servicioDto);

            if (!response.Success)
            {
                return StatusCode(response.StatusCode, response.Message);
            }

            return Ok(response.Result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateServicioAsync(int id, ServicioDTO servicioDto)
        {
            var response = await _servicioService.UpdateServicioAsync(id, servicioDto);

            if (!response.Success)
            {
                return StatusCode(response.StatusCode, response.Message);
            }

            return Ok(response.Result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteServicioAsync(int id)
        {
            var response = await _servicioService.DeleteServicioAsync(id);

            if (!response.Success)
            {
                return StatusCode(response.StatusCode, response.Message);
            }

            return Ok(response.Result);
        }

    }
}
