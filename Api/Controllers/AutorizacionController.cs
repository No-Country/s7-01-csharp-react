using Microsoft.AspNetCore.Mvc;
using s7_01.Api.Common.DTOs.AutorizacionDTOs;
using s7_01.Api.Contracts.Services;
using s7_01.Api.Services;

namespace s7_01.Api.Controllers
{
        [ApiController]
        [Route("api/[controller]")]
        public class AutorizacionController : ControllerBase
        {
            private readonly IAutorizacionService _autorizacionService;

            public AutorizacionController(IAutorizacionService autorizacionService)
            {
                _autorizacionService = autorizacionService;
            }

            [HttpGet]
            public async Task<IActionResult> GetAllAsync()
            {
                var response = await _autorizacionService.GetAllAsync();

                if (!response.Success)
                {
                    return StatusCode(response.StatusCode, response.Message);
                }

                return Ok(response.Result);
            }

            [HttpGet("{id}")]
            public async Task<IActionResult> GetByIdAsync(int id)
            {
                var response = await _autorizacionService.GetByIdAsync(id);

                if (!response.Success)
                {
                    return StatusCode(response.StatusCode, response.Message);
                }

                return Ok(response.Result);
            }

            [HttpGet("mascota/{mascotaId}")]
            public async Task<IActionResult> GetByMascotaIdAsync(int mascotaId)
            {
                var response = await _autorizacionService.GetAutorizacionesByMascotaIdAsync(mascotaId);

                if (!response.Success)
                {
                    return StatusCode(response.StatusCode, response.Message);
                }

                return Ok(response.Result);
            }

            [HttpGet("veterinaria/{veterinariaId}")]
            public async Task<IActionResult> GetByVeterinariaIdAsync(int veterinariaId)
            {
                var response = await _autorizacionService.GetAutorizacionesByVeterinaIdAsync(veterinariaId);

                if (!response.Success)
                {
                    return StatusCode(response.StatusCode, response.Message);
                }

                return Ok(response.Result);
            }

            [HttpGet]
            public async Task<IActionResult> GetAutorizacionByMascotaIdAndVeterinariaIdAsync([FromQuery] GetAutorizacionDTO getAutorizacionDTO)
            {
                var response = await _autorizacionService.GetAutorizacionByMascotaIdAndVeterinariaIdAsync(getAutorizacionDTO);

                if (!response.Success)
                {
                    return StatusCode(response.StatusCode, response.Message);
                }

                return Ok(response.Result);
            }


        [HttpPost]
            public async Task<IActionResult> AddAsync(CreateAutorizacionDTO createAutorizacionDTO)
            {
                var response = await _autorizacionService.AddAsync(createAutorizacionDTO);

                if (!response.Success)
                {
                    return StatusCode(response.StatusCode, response.Message);
                }

                return Ok(response.Result);
            }
          

            [HttpDelete]
            public async Task<IActionResult> Delete(GetAutorizacionDTO getAutorizacionDTO)
            {
                var response = await _autorizacionService.RemoveAsync(getAutorizacionDTO);

                if (!response.Success)
                {
                    return StatusCode(response.StatusCode, response.Message);
                }

                return Ok(response.Result);
            }
        }
}
