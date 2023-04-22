using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using s7_01.Api.Common.DTO;
using s7_01.Api.Common.DTOs.ProductoDTOs;
using s7_01.Api.Common.DTOs.VeterinariaDTOs;
using s7_01.Api.Contracts.Services;
using s7_01.Api.Services;

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
                

        [HttpGet]
        public async Task<IActionResult> GetAllVeterinariasAsync()
        {
            var response = await _veterinariaService.GetAllVetAsync();
            return StatusCode(response.StatusCode, response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetVeterinariaByIdAsync(int id)
        {
            var response = await _veterinariaService.GetVetByIdAsync(id);
            return StatusCode(response.StatusCode, response);
        }

        [HttpPost("veterinaria")]
        public async Task<IActionResult> AddVeterinariaAsync([FromBody] VeterinariaDTO veterinariaDTO)
        {
            var response = await _veterinariaService.AddVeterinariaAsync(veterinariaDTO);
            return StatusCode(response.StatusCode, response);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateVeterinariaAsync(int id, [FromBody] VeterinariaDTO veterinariaDTO)
        {
            var response = await _veterinariaService.UpdateVeterinariaAsync(id, veterinariaDTO);
            return StatusCode(response.StatusCode, response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVeterinariaAsync(int id)
        {
            var response = await _veterinariaService.DeleteVeterinariaAsync(id);
            return StatusCode(response.StatusCode, response);
        }


        [HttpPost("veterinariasList")]
        public async Task<IActionResult> AddVeterinariasAsync([FromBody] IEnumerable<VeterinariaDTO> veterinariaDTOs)
        {
            var response = await _veterinariaService.AddRangeAsync(veterinariaDTOs);

            if (!response.Success)
            {
                return StatusCode(response.StatusCode, response.Message);
            }

            return Ok(response.Result);
        }

    }
}
