using Microsoft.EntityFrameworkCore;
using VittorioLongo.Diario.DataLayer;
using VittorioLongo.Diario.Entity;

namespace VittorioLongo.Diario.Service.Utente
{
    public class UtenteManager
    {
        // COSTRUTTORE: Inizializza UtenteManager con il contesto SQLServerContext per l'accesso al database
        private readonly SQLServerContext _context;

        public UtenteManager(SQLServerContext context)
        {
            _context = context;
        }

        // CREATE: Aggiunge un nuovo utente
        public void Create(Entity.Utente utente)
        {
            if (utente == null)
            {
                throw new ArgumentNullException(nameof(utente), "L'utente non può essere nullo");
            }

            // Non è necessario impostare manualmente l'ID se è una chiave primaria auto-incrementante
            _context.Utenti.Add(utente);
            _context.SaveChanges();  // Salva le modifiche nel database
        }

        // READ: Trova un utente per ID
        public Entity.Utente GetById(int id)
        {
            var utente = _context.Utenti.Find(id);
            if (utente == null)
                throw new KeyNotFoundException($"Utente con ID {id} non trovato");

            return utente;
        }

        // READ ALL: Restituisce tutti gli utenti
        public IEnumerable<Entity.Utente> GetAll()
        {
            return _context.Utenti.AsNoTracking().ToList();
        }

        // UPDATE: Modifica i dati di un utente esistente
        public void Update(Entity.Utente utente, string nuovoUser, string nuovaPassword)
        {
            if (utente == null)
                throw new ArgumentNullException(nameof(utente), "Utente nullo, impossibile aggiornare");

            // Aggiorna l'utente con i nuovi valori
            utente.Update(nuovoUser, nuovaPassword);

            // Salva le modifiche nel contesto
            _context.SaveChanges();
        }

        // DELETE: Elimina un utente
        public void Delete(int id)
        {
            var utente = _context.Utenti.Find(id);
            if (utente == null)
                throw new KeyNotFoundException($"Utente con ID {id} non trovato");

            _context.Utenti.Remove(utente);
            _context.SaveChanges();
        }
    }
}
