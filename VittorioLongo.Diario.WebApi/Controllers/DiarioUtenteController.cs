using Microsoft.AspNetCore.Mvc;
using VittorioLongo.Diario.CRUDService;
using VittorioLongo.Diario.Entity;

namespace VittorioLongo.Diario.Controllers
{
    [Route("DiarioApi")]
    [ApiController]
    public class DiarioUtenteController : ControllerBase
    {
        private readonly DiarioManager _diarioManager;

        public DiarioUtenteController(DiarioManager diarioManager)
        {
            _diarioManager = diarioManager;
        }

        // RESTITUISCE UN DIARIO PER ID (Solo per Utente)
        [HttpGet("Diario/Utente/HomeDiari/Testo/{id}")]
        public IActionResult GetById(string id)
        {
            var diario = _diarioManager.GetById(id);
            if (diario == null)
                return NotFound();
            return Ok(diario);
        }

        // RESTITUISCE TUTTI I DIARI DI UN UTENTE (Solo per Utente)
        [HttpGet("Diario/Utente/HomeDiari/{userId}")]
        public IActionResult GetByUserId(int userId)
        {
            return Ok(_diarioManager.GetAllByUserID(userId));
        }

        // CREA UN NUOVO DIARIO (Solo per Utente)
        [HttpPost("Diario/Utente/HomeDiari")]
        public IActionResult Create([FromBody] Entity.Diario diario)
        {
            if (diario == null)
                return BadRequest();

            _diarioManager.Create(diario);
            return CreatedAtAction(nameof(GetById), new { id = diario.ObjectID }, diario);
        }

        // MODIFICA UN DIARIO (Solo per Utente)
        [HttpPut("Diario/Utente/HomeDiari/{id}")]
        public IActionResult Update(string id, [FromBody] Entity.Diario diario)
        {
            if (diario == null || id != diario.ObjectID)
                return BadRequest();

            _diarioManager.Update(diario);
            return NoContent();
        }

        // ELIMINA UN DIARIO (Solo per Utente)
        [HttpDelete("Diario/Utente/HomeDiari/{id}")]
        public IActionResult Delete(string id)
        {
            _diarioManager.Delete(id);
            return NoContent();
        }
    }
}
