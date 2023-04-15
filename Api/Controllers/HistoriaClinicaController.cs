using Microsoft.AspNetCore.Mvc;
using s7_01.Api.Common.DTOs.AutorizacionDTOs;
using s7_01.Api.Common.DTOs.HistoriaClinicaDTOs;
using s7_01.Api.Common.DTOs.PropietarioDTOs;
using s7_01.Api.Common.DTOs.VeterinariaDTOs;
using s7_01.Api.Contracts.Services;
using s7_01.Api.Services;

namespace s7_01.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HistoriaClinicaController : Controller
    {
        private readonly IHistoriaClinicaService _historiaClinicaService;

        public HistoriaClinicaController(IHistoriaClinicaService historiaClinicaService)
        {
            _historiaClinicaService = historiaClinicaService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var response = await _historiaClinicaService.GetAllAsync();

            if (!response.Success)
            {
                return StatusCode(response.StatusCode, response.Message);
            }

            return Ok(response.Result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var response = await _historiaClinicaService.GetByIdAsync(id);

            if (!response.Success)
            {
                return StatusCode(response.StatusCode, response.Message);
            }

            return Ok(response.Result);
        }


        [HttpPost]
        public async Task<IActionResult> AddAsync(CreateHistoriaClinicaDTO createHistoriaClinicaDTO)
        {
            var response = await _historiaClinicaService.AddAsync(createHistoriaClinicaDTO);

            if (!response.Success)
            {
                return StatusCode(response.StatusCode, response.Message);
            }

            return Ok(response.Result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateHistoriaClinicaAsync(int id, [FromBody] CreateHistoriaClinicaDTO createHistoriaClinicaDTO)
        {
            var response = await _historiaClinicaService.UpdateAsync(id, createHistoriaClinicaDTO);
            return StatusCode(response.StatusCode, response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int historiaClinicaId)
        {
            var response = await _historiaClinicaService.RemoveAsync(historiaClinicaId);

            if (!response.Success)
            {
                return StatusCode(response.StatusCode, response.Message);
            }

            return Ok(response.Result);
        }
    }
}

