
using Microsoft.EntityFrameworkCore;
using VittorioLongo.Diario.DataLayer;
using ZstdSharp;

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

        // CREATE: Aggiunge nuovo utente
        public void Create(Entity.Utente utente)
        {
            if (utente != null)
            {
                _context.Utenti.Add(utente);
                _context.SaveChanges();
                Console.WriteLine($"Utente {utente.NomeUtente} creato con ID {utente.ID}");
            }
            else
            {
                throw new Exception("Utente nullo, impossibile creazione utente");
            }
        }

        // READ: Trova un utente per ID
        public Entity.Utente GetById(int id)
        {
            var utente = _context.Utenti.Find(id);
            if (utente == null)
            {
                throw new Exception("Utente nullo, impossibile ricerca");
            }
            return utente;
        }

        // READ ALL: Restituisce tutti gli utenti
        public IEnumerable<Entity.Utente> GetAll()
        {
            return _context.Utenti.AsEnumerable();
        }

        // UPDATE: Modifica i dati di un utente esistente
        public void Update(Entity.Utente utente, string nuovoUser, string nuovaPassword)
        {
            if (utente != null)
            {
                utente.Update(nuovoUser, nuovaPassword);
                _context.SaveChanges();
                Console.WriteLine($"Utente con ID {utente.ID} aggiornato.");
            }
            else
            {
                throw new Exception("Utente non trovato, impossibile aggiornare.");
            }
        }

        // DELETE: Elimina un utente
        public void Delete(int id)
        {
            var utente = _context.Utenti.Find(id);
            if (utente != null)
            {
                Console.WriteLine($"Eliminazione utente: {utente.ID}");
                _context.Utenti.Remove(utente);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Utente nullo, impossibile eliminazione utente");
            }
        }

    }
}
