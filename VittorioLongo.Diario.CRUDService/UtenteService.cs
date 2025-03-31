using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VittorioLongo.Diario.CRUDService;
using VittorioLongo.Diario.Entity;

namespace VittorioLongo.Diario.Service.Utente
{
    public class UtenteService : ICRUDService<Entity.Utente, int>
    {
        public void Create(Entity.Utente entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Entity.Utente> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Entity.Utente> GetAllByUserID(int id)
        {
            throw new NotImplementedException();
        }

        public Entity.Utente GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Entity.Utente entity)
        {
            throw new NotImplementedException();
        }
    }
}
