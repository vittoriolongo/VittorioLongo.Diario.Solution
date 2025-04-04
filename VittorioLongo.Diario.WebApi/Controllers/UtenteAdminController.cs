using Microsoft.AspNetCore.Mvc;
using VittorioLongo.Diario.Service.Utente;
using VittorioLongo.Diario.Entity;

namespace VittorioLongo.Diario.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtenteAdminController : ControllerBase
    {
        private readonly UtenteManager _utenteManager;

        public UtenteAdminController(UtenteManager utenteManager)
        {
            _utenteManager = utenteManager;
        }

        // RESTITUISCE TUTTI GLI UTENTI (Solo per Admin)
        [HttpGet("Admin/HomeUtenti")]
        public IActionResult GetAll()
        {
            return Ok(_utenteManager.GetAll());
        }

        // RESTITUISCE UN UTENTE PER ID (Solo per Admin)
        [HttpGet("Admin/HomeUtenti/{id}")]
        public IActionResult GetById(int id)
        {
            var utente = _utenteManager.GetById(id);
            if (utente == null)
                return NotFound();
            return Ok(utente);
        }

        // CREA UN NUOVO UTENTE (Solo per Admin)
        [HttpPost("Admin/HomeUtenti")]
        public IActionResult Create([FromBody] Utente utente)
        {
            if (utente == null)
                return BadRequest();

            _utenteManager.Create(utente);
            return CreatedAtAction(nameof(GetById), new { id = utente.ID }, utente);
        }

        // MODIFICA UN UTENTE (Solo per Admin)
        [HttpPut("Admin/HomeUtenti/{id}")]
        public IActionResult Update(int id, [FromBody] Utente utente)
        {
            if (utente == null || id != utente.ID)
                return BadRequest();

            _utenteManager.Update(utente, utente.NomeUtente, utente.Password);
            return NoContent();
        }

        // ELIMINA UN UTENTE (Solo per Admin)
        [HttpDelete("Admin/HomeUtenti/{id}")]
        public IActionResult Delete(int id)
        {
            _utenteManager.Delete(id);
            return NoContent();
        }
    }
}
