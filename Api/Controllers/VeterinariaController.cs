using Microsoft.AspNetCore.Mvc;
using s7_01.Api.Common.DTOs.VeterinariaDTOs;
using s7_01.Api.Contracts.Services;

namespace s7_01.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VeterinariaController : ControllerBase
    {
        private readonly IVeterinariaService _veterinariaService;

        public VeterinariaController(IVeterinariaService veterinariaService)
        {
            _veterinariaService = veterinariaService;
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync([FromBody] VeterinariaDTO veterinariaDTO)
        {
            var response = await _veterinariaService.AddVeterinariaAsync(veterinariaDTO);
            return StatusCode(response.StatusCode, response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var response = await _veterinariaService.GetAllVeterinariasAsync();
            return StatusCode(response.StatusCode, response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var response = await _veterinariaService.GetVeterinariaByIdAsync(id);
            return StatusCode(response.StatusCode, response);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(int id, [FromBody] VeterinariaDTO veterinariaDTO)
        {
            var response = await _veterinariaService.UpdateVeterinariaAsync(id, veterinariaDTO);
            return StatusCode(response.StatusCode, response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var response = await _veterinariaService.DeleteVeterinariaAsync(id);
            return StatusCode(response.StatusCode, response);
        }
    }
}
