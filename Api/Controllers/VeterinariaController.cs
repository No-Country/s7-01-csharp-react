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
    }
}
