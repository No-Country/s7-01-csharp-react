using Azure;
using Microsoft.AspNetCore.Mvc;
using s7_01.Api.Common;
using s7_01.Api.Common.DTOs.AuthDTOs;
using s7_01.Api.Contracts.Services;
using s7_01.Api.DataAccess.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace s7_01.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsuarioController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpPost("register")]
        public async Task<ActionResult<ResponseDTO>> Register([FromBody] RegistroDTO registerModel)
        {

            ResponseDTO response = await _userService.RegisterAsync(registerModel);
            return StatusCode(response.StatusCode, response);

        }

        [HttpPost("login")]
        public async Task<ActionResult<ResponseDTO>> Login([FromBody] LoginDTO loginDTO)
        {

            ResponseDTO response = await _userService.LoginAsync(loginDTO);
            return StatusCode(response.StatusCode, response);

        }
    }
}
