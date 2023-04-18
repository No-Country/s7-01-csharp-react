using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using s7_01.Api.Common.DTO;
using s7_01.Api.Common.DTOs.MascotaDTOs;
using s7_01.Api.Common.DTOs.VeterinariaDTOs;
using s7_01.Api.Contracts.Services;
using s7_01.Api.Services;

namespace s7_01.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "User")]
    public class MascotaController : Controller
    {
        private readonly IMascotaService _macotaService;
        public MascotaController(IMascotaService mascotaService)
        {
            _macotaService = mascotaService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ResponseDTO>>> Index()
        {
            ResponseDTO response = await _macotaService.GetAllMascotasAsync();

            return StatusCode(response.StatusCode, response);
        }

        [HttpGet("getForPropietarie/{id}")]
        public async Task<ActionResult<ResponseDTO>> getForPropietarie(int id)
        {

            ResponseDTO response = await _macotaService.GetAllMascotasPropietaryAsync(id);

            return StatusCode(response.StatusCode, response);
        }


        [HttpGet("getMascota/{id}")]
        public async Task<ActionResult<ResponseDTO>> GetMascota(int id)
        {
            ResponseDTO response = await _macotaService.GetMascotaByIdAsync(id);
            return StatusCode(response.StatusCode, response);
        }

        //// id = id de propietario
        [HttpPost("addMascota/{id}")]
        public async Task<ActionResult> AddMascota(int id, [FromBody] MascotaDTO mascotaModel)
        {
            ResponseDTO response = await _macotaService.AddMascotaAsync(id, mascotaModel);

            return StatusCode(response.StatusCode, response);

        }

        [HttpPut("updateMascota/{id}")]
        public async Task<ActionResult> UpdateMascota(int id, [FromBody] MascotaDTO mascotaDTO)
        {
            ResponseDTO response = await _macotaService.UpdateMascotaAsync(id, mascotaDTO);

            return StatusCode(response.StatusCode, response);
        }

        [HttpPost("mascotasList")]
        public async Task<IActionResult> AddMascotasAsync(int id, [FromBody] IEnumerable<MascotaDTO> mascotaDTOs)
        {
            var response = await _macotaService.AddRangeAsync(id, mascotaDTOs);

            if (!response.Success)
            {
                return StatusCode(response.StatusCode, response.Message);
            }

            return Ok(response.Result);
        }
    }
}

