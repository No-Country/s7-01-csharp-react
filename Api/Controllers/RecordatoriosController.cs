using Microsoft.AspNetCore.Mvc;
using s7_01.Api.DataAccess;
using s7_01.Api.DataAccess.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace s7_01.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecordatoriosController : ControllerBase
    {
        private readonly VeterinariaContext _context;
        public RecordatoriosController(VeterinariaContext context)
        {
            _context = context;
        }

        // GET: api/<RecordatoriosController>
        [HttpGet]
        public IEnumerable<Recordatorio> Get()
        {
            var data = _context.Recordatorios.AsEnumerable();
            return data;
        }

        // GET api/<RecordatoriosController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = _context.Recordatorios.Find(id);
            return data == null ? NotFound() : Ok(data);
        }

        //// POST api/<RecordatoriosController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<RecordatoriosController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<RecordatoriosController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
