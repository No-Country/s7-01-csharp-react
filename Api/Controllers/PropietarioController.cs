using Microsoft.AspNetCore.Mvc;
using s7_01.Api.Common.DTOs.AutorizacionDTOs;
using s7_01.Api.Common.DTOs.PropietarioDTOs;
using s7_01.Api.Common.DTOs.VeterinariaDTOs;
using s7_01.Api.Contracts.Services;
using s7_01.Api.DataAccess.Models;
using s7_01.Api.Services;

namespace s7_01.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PropietarioController : Controller
    {
        private readonly IPropietarioService _propietarioService;

        public PropietarioController(IPropietarioService propietarioService)
        {
            _propietarioService = propietarioService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var response = await _propietarioService.GetAllPropAsync();

            if (!response.Success)
            {
                return StatusCode(response.StatusCode, response.Message);
            }

            return Ok(response.Result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var response = await _propietarioService.GetByIdAsync(id);

            if (!response.Success)
            {
                return StatusCode(response.StatusCode, response.Message);
            }

            return Ok(response.Result);
        }


        [HttpPost("propietario")]
        public async Task<IActionResult> AddAsync(CreatePropietarioDTO createPropietarioDTO)
        {
            var response = await _propietarioService.AddAsync(createPropietarioDTO);

            return StatusCode(response.StatusCode, response);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int propietarioId)
        {
            var response = await _propietarioService.RemoveAsync(propietarioId);

            if (!response.Success)
            {
                return StatusCode(response.StatusCode, response.Message);
            }

            return Ok(response.Result);
        }



        [HttpPost("propietariosList")]
        public async Task<IActionResult> AddPropietariosAsync([FromBody] IEnumerable<CreatePropietarioDTO> createPropietarioDTOs)
        {
            var response = await _propietarioService.AddRangeAsync(createPropietarioDTOs);

            return StatusCode(response.StatusCode, response);
        }
    }
}

