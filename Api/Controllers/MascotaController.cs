using Microsoft.AspNetCore.Mvc;
using s7_01.Api.Contracts.Repositories;
using s7_01.Api.DataAccess.Models;

namespace s7_01.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MascotaController : Controller
    {
        private readonly IMascotaRepository _mascotaRepository;

        public MascotaController(IMascotaRepository mascotaRepository)
        {
            _mascotaRepository = mascotaRepository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Mascota>>> Index()
        {
            var mascota = _mascotaRepository.GetAll();

            return Ok(mascota);
        }
    }
}
