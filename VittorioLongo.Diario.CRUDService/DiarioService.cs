using VittorioLongo.Diario.Entity;

namespace VittorioLongo.Diario.CRUDService
{
    // CLASSE SERVICE: Implementazione del servizio CRUD per la gestione dei diari
    public class DiarioService : ICRUDService<Entity.Diario, string>
    {
        // METODO CREATE: Crea un nuovo diario
        public void Create(Entity.Diario entity)
        {
            throw new NotImplementedException();
        }

        // METODO DELETE: Elimina un diario tramite ID
        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        // METODO GETALL: Restituisce tutti i diari
        public IEnumerable<Entity.Diario> GetAll()
        {
            throw new NotImplementedException();
        }

        // METODO GETALLBYUSERID: Restituisce tutti i diari di un utente specifico
        public IEnumerable<Entity.Diario> GetAllByUserID(string id)
        {
            throw new NotImplementedException();
        }

        // METODO GETBYID: Restituisce un diario specifico tramite ID
        public Entity.Diario GetById(string id)
        {
            throw new NotImplementedException();
        }

        // METODO UPDATE: Aggiorna un diario esistente
        public void Update(Entity.Diario entity)
        {
            throw new NotImplementedException();
        }
    }
}