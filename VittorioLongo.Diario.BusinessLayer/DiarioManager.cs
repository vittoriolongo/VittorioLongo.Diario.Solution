using MongoDB.Driver;
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
        }

        // READ : Restituisce un testo per il suo objectId
        public Entity.Diario GetById(string objectId)
        {
            var filter = Builders<Entity.Diario>.Filter.Eq("ObjectID", objectId);
            return _context.Diari.Find(filter).FirstOrDefault();
        }

        // READ : Restituisce tutta la lista dei testi nel DB
        public IEnumerable<Entity.Diario> GetAll()
        {
            var filter = Builders<Entity.Diario>.Filter.Empty;
            return _context.Diari.Find(filter).ToList();
        }

        // READ : Restituisce la lista dei testi per userId
        public IEnumerable<Entity.Diario> GetAllByUserID(int userId)
        {
            var filter = Builders<Entity.Diario>.Filter.Eq("UserID", userId);
            return _context.Diari.Find(filter).ToList();
        }

        // UPDATE : Modifica testo esistente
        public void Update(Entity.Diario entity)
        {
            var filter = Builders<Entity.Diario>.Filter.Eq("ObjectID", entity.ObjectID);
            var update = Builders<Entity.Diario>.Update
                .Set("Testo", entity.Testo)
                .Set("DataTesto", entity.DataTesto);

            _context.Diari.UpdateOne(filter, update);
        }

        // DELETE : Elimina testo esistente
        public void Delete(string id)
        {
            var filter = Builders<Entity.Diario>.Filter.Eq("ObjectID", id);
            _context.Diari.DeleteOne(filter);
        }
    }
}
