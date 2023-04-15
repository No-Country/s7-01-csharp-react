using Microsoft.AspNetCore.Mvc;
using s7_01.Api.Common.DTOs.AutorizacionDTOs;
using s7_01.Api.Common.DTOs.PropietarioDTOs;
using s7_01.Api.Contracts.Services;

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
            var response = await _propietarioService.GetAllAsync();

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

        [HttpGet("propietario/{id}/mascotas")]
        public async Task<IActionResult> GetMascotasByPropietarioIdAsync(int propietarioId)
        {
            var response = await _propietarioService.GetMascotasByPropietarioIdAsync(propietarioId);

            if (!response.Success)
            {
                return StatusCode(response.StatusCode, response.Message);
            }

            return Ok(response.Result);
        }



        [HttpPost]
        public async Task<IActionResult> AddAsync(CreatePropietarioDTO createPropietarioDTO)
        {
            var response = await _propietarioService.AddAsync(createPropietarioDTO);

            if (!response.Success)
            {
                return StatusCode(response.StatusCode, response.Message);
            }

            return Ok(response.Result);
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
    }
}

