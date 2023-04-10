using Microsoft.AspNetCore.Mvc;
using s7_01.Api.Contracts.Repositories;
using s7_01.Api.DataAccess.Models;
using s7_01.Api.Dtos;

namespace s7_01.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MascotaController : Controller
    {
        private readonly IMascotaRepository _mascotaRepository;
        private readonly IMascotaPropietarioRepository _mascotaPropietarioRepository;

        public MascotaController(IMascotaRepository mascotaRepository, IMascotaPropietarioRepository mascotaPropietarioRepository)
        {
            _mascotaRepository = mascotaRepository;
            _mascotaPropietarioRepository = mascotaPropietarioRepository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MascotaPropietario>>> Index()
        {
            var mascotaPropietarios = _mascotaPropietarioRepository.GetAll();

            return Ok(mascotaPropietarios);
        }

        [HttpGet("getForPropietarie/{id}")]
        public async Task<ActionResult<MascotaXPropietarioDto>> getForPropietarie(int id)
        {

            var mascotaPropietarios = _mascotaPropietarioRepository.Find(m => m.PropietarioId == id);
            List<Mascota> mascotas = new List<Mascota>();
            foreach (var mascotaXPropietario in mascotaPropietarios)
            {
                mascotas.Add(mascotaXPropietario.Mascota);
            }
            MascotaXPropietarioDto mascotaXPropietarioDto = new MascotaXPropietarioDto() { Mascotas = mascotas };



            return Ok(mascotaXPropietarioDto);
        }
    }
}

