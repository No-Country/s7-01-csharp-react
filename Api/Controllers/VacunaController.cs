using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using s7_01.Api.Common.DTOs.VacunaDTOs;
using s7_01.Api.Contracts.Services;
using static s7_01.Api.Common.DTOs.VacunaDTOs.VacunaDTO;

namespace s7_01.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VacunaController : ControllerBase
    {
        private readonly IVacunaService _vacunaService;

        public VacunaController(IVacunaService vacunaService)
        {
            _vacunaService = vacunaService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllVacunas()
        {
            var response = await _vacunaService.GetAllAsync();
            return StatusCode(response.StatusCode, response);
        }

        [HttpGet("getvacuna/{id}")]
        public async Task<IActionResult> GetVacunaById(int id)
        {
            var response = await _vacunaService.GetByIdAsync(id);
            return StatusCode(response.StatusCode, response);
        }

        [HttpPost]
        public async Task<IActionResult> AddVacuna(VacunaDTO model)
        {
            var response = await _vacunaService.AddAsync(model);
            return StatusCode(response.StatusCode, response);
        }

        [HttpPut("updatevacuna/{id}")]
        public async Task<IActionResult> UpdateVacuna(int id, VacunaDTO model)
        {
            var response = await _vacunaService.UpdateAsync(id, model);
            return StatusCode(response.StatusCode, response);
        }

        [HttpDelete("deletevacuna/{id}")]
        public async Task<IActionResult> DeleteVacuna(int id)
        {
            var response = await _vacunaService.DeleteAsync(id);

            if (!response.Success)
                return StatusCode(response.StatusCode, response);

            return Ok(response.Result);
        }
       
        [HttpGet("getvacunas/{historiaClinicaId}")]
        public async Task<IActionResult> GetVacunasByHistoriaClinicaId(int historiaClinicaId)
        {
            var response = await _vacunaService.GetVacunasByHistoriaClinicaIdAsync(historiaClinicaId);
            return StatusCode(response.StatusCode, response);
        }

        
    }
}
