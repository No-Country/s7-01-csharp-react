using Microsoft.AspNetCore.Mvc;
using s7_01.Api.Common.DTOs.TratamientoDTOs;
using s7_01.Api.Contracts.Services;
using static s7_01.Api.Common.DTOs.TratamientoDTOs.TratamientoDTO;

namespace s7_01.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TratamientoController : ControllerBase
{
    private readonly ITratamientoService _tratamientoService;

    public TratamientoController(ITratamientoService tratamientoService)
    {
        _tratamientoService = tratamientoService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllTratamientos()
    {
        var response = await _tratamientoService.GetAllAsync();
        return StatusCode(response.StatusCode, response);
    }

    [HttpGet("gettratamiento/{id}")]
    public async Task<IActionResult> GetTratamientoId(int id)
    {
        var response = await _tratamientoService.GetByIdAsync(id);
        return StatusCode(response.StatusCode, response);
    }

    [HttpPost]
    public async Task<IActionResult> AddTratamiento(TratamientoDTO model)
    {
        var response = await _tratamientoService.AddAsync(model);
        return StatusCode(response.StatusCode, response);
    }

    [HttpPut("updatetratamiento/{id}")]
    public async Task<IActionResult> UpdateTratamiento(int id, TratamientoDTO model)
    {
        var response = await _tratamientoService.UpdateAsync(id, model);
        return StatusCode(response.StatusCode, response);
    }

    [HttpDelete("deletetratamiento/{id}")]
    public async Task<IActionResult> DeleteTratamiento(int id)
    {
        var response = await _tratamientoService.DeleteAsync(id);

        if (!response.Success)
            return StatusCode(response.StatusCode, response);

        return Ok(response.Result);
    }

    [HttpGet("gettratamientobyveterinariaId/{id}")]
    public async Task<IActionResult> GetTratamientoByVeterinariaId(int id)
    {
        var response = await _tratamientoService.GetTratamientoByVeterinariaIdAsync(id);
        return StatusCode(response.StatusCode, response);
    }
}
