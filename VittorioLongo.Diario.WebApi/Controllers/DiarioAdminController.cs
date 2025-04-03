using Microsoft.AspNetCore.Mvc;
using VittorioLongo.Diario.CRUDService;
using VittorioLongo.Diario.Entity;

namespace VittorioLongo.Diario.Controllers
{
    [Route("DiarioApi")]
    [ApiController]
    public class DiarioAdminController : ControllerBase
    {
        private readonly DiarioManager _diarioManager;

        public DiarioAdminController(DiarioManager diarioManager)
        {
            _diarioManager = diarioManager;
            Console.WriteLine("DiarioAdminController inizializzato!");
        }

        // RESTITUISCE TUTTI I DIARI NEL DATABASE (Solo per Admin)
        [HttpGet("Diario/Admin/HomeDiari")]
        public IActionResult GetAll()
        {
            return Ok(_diarioManager.GetAll());
        }

        // RESTITUISCE UN DIARIO PER ID (Solo per Admin)
        [HttpGet("Diario/Admin/HomeDiari/{id}")]
        public IActionResult GetById(string id)
        {
            var diario = _diarioManager.GetById(id);
            if (diario == null)
                return NotFound();
            return Ok(diario);
        }

        // RESTITUISCE TUTTI I DIARI DI UN UTENTE (Solo per Admin)
        [HttpGet("Diario/Admin/HomeDiari/ListaUtente/{userId}")]
        public IActionResult GetByUserId(int userId)
        {
            return Ok(_diarioManager.GetAllByUserID(userId));
        }

        // CREA UN NUOVO DIARIO (Solo per Admin)
        [HttpPost("Diario/Admin/HomeDiari")]
        public IActionResult Create([FromBody] Entity.Diario diario)
        {
            if (diario == null)
                return BadRequest();

            _diarioManager.Create(diario);
            return CreatedAtAction(nameof(GetById), new { id = diario.ObjectID }, diario);
        }

        // MODIFICA UN DIARIO (Solo per Admin)
        [HttpPut("Diario/Admin/HomeDiari/{id}")]
        public IActionResult Update(string id, [FromBody] Entity.Diario diario)
        {
            if (diario == null || id != diario.ObjectID)
                return BadRequest();

            _diarioManager.Update(diario);
            return NoContent();
        }

        // ELIMINA UN DIARIO (Solo per Admin)
        [HttpDelete("Diario/Admin/HomeDiari/{id}")]
        public IActionResult Delete(string id)
        {
            _diarioManager.Delete(id);
            return NoContent();
        }
    }
}
