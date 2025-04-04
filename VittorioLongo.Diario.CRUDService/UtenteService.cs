using VittorioLongo.Diario.CRUDService;

namespace VittorioLongo.Diario.Service.Utente
{
    // CLASSE SERVICE: Implementazione del servizio CRUD per la gestione degli utenti
    public class UtenteService : ICRUDService<Entity.Utente, int>
    {
        // METODO CREATE: Crea un nuovo utente
        public void Create(Entity.Utente entity)
        {
            throw new NotImplementedException();
        }

        // METODO GETBYID: Restituisce un utente specifico tramite ID
        public Entity.Utente GetById(int id)
        {
            throw new NotImplementedException();
        }

        // METODO GETALL: Restituisce tutti gli utenti
        public IEnumerable<Entity.Utente> GetAll()
        {
            throw new NotImplementedException();
        }

        // METODO GETALLBYUSERID: Restituisce tutti gli utenti con un determinato ID (verifica se necessario)
        public IEnumerable<Entity.Utente> GetAllByUserID(int id)
        {
            throw new NotImplementedException();
        }

        // METODO UPDATE: Aggiorna un utente esistente
        public void Update(Entity.Utente entity)
        {
            throw new NotImplementedException();
        }

        // METODO DELETE: Elimina un utente tramite ID
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
