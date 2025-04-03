using Microsoft.AspNetCore.Mvc;
using VittorioLongo.Diario.Service.Utente;
using VittorioLongo.Diario.Entity;

namespace VittorioLongo.Diario.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtenteUtenteController : ControllerBase
    {
        private readonly UtenteManager _utenteManager;

        public UtenteUtenteController(UtenteManager utenteManager)
        {
            _utenteManager = utenteManager;
        }

        // REGISTRAZIONE UTENTE (Accessibile senza autenticazione)
        [HttpPost("/Registrazione")]
        public IActionResult Create([FromBody] Utente utente)
        {
            if (utente == null)
                return BadRequest();

            _utenteManager.Create(utente);
            return CreatedAtAction(nameof(GetById), new { id = utente.ID }, utente);
        }

        // RESTITUISCE UN UTENTE PER ID (Solo per Utente)
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var utente = _utenteManager.GetById(id);
            if (utente == null)
                return NotFound();
            return Ok(utente);
        }

        // ELIMINA UN UTENTE (Solo per Utente)
        [HttpDelete("/Utente/Eliminazione/{id}")]
        public IActionResult Delete(int id)
        {
            _utenteManager.Delete(id);
            return NoContent();
        }
    }
}
