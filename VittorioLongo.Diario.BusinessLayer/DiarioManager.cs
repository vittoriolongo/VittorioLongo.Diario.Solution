using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VittorioLongo.Diario.DataLayer;

namespace VittorioLongo.Diario.CRUDService
{
    public class DiarioManager 
    {
        // COSTRUTTORE: Inizializza DiarioManager con il contesto MongoDBContext per l'accesso al database
        private readonly MongoDBContext _context;

        public DiarioManager(MongoDBContext context)
        {
            _context = context;
        }

        // CREATE : Crea nuovo diario
        public void Create(Entity.Diario entity)
        {
            _context.Diari.InsertOne(entity);
            Console.WriteLine($"Diario creato per l'utente {entity.UserID}.");
        }

        // READ : restiusce un testo per il suo objectId
        public Entity.Diario GetById(string objectId)
        {
            return _context.Diari.Find(d => d.ObjectID == objectId).FirstOrDefault();
        }

        // READ : Restituisce tutta la lista dei testi nel DB
        public IEnumerable<Entity.Diario> GetAll()
        {
            return _context.Diari.Find(d => true).ToList();
        }

        // READ : Restituisce la lista dei testi per userId
        public IEnumerable<Entity.Diario> GetAllByUserID(int userId)
        {

            return _context.Diari.Find(d => d.UserID == userId).ToList();
        }

        // UPDATE : Modifica testo esistente
        public void Update(Entity.Diario entity)
        {
            var filter = Builders<Entity.Diario>.Filter.Eq(d => d.ObjectID, entity.ObjectID);
            var update = Builders<Entity.Diario>.Update
                .Set(d => d.Testo, entity.Testo)
                .Set(d => d.DataTesto, entity.DataTesto);

            _context.Diari.UpdateOne(filter, update);
            Console.WriteLine($"Diario con ID {entity.ObjectID} aggiornato.");
        }

        // DELETE : Elimina testo esistente
        public void Delete(string id)
        {
            var filter = Builders<Entity.Diario>.Filter.Eq(d => d.ObjectID, id);
            _context.Diari.DeleteOne(filter);
            Console.WriteLine($"Diario con ID {id} eliminato.");
        }
    }
}
