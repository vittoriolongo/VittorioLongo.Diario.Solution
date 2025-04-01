using MongoDB.Driver;

namespace VittorioLongo.Diario.DataLayer
{
    public class MongoDBContext
    {
        private readonly IMongoDatabase _database;

        public MongoDBContext(string connectionString, string databaseName)
        {
            var client = new MongoClient(connectionString);
            _database = client.GetDatabase(databaseName); 
        }

        public IMongoCollection<Entity.Diario> Diari
        {
            get { return _database.GetCollection<Entity.Diario>("Testi"); }
        }
    }
}
