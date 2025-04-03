using MongoDB.Driver;

namespace VittorioLongo.Diario.DataLayer
{
    // CLASSE CONTESTO: Classe per gestire il contesto di connessione al DB Mongo
    public class MongoDBContext
    {
        private readonly IMongoDatabase _database;

        // COSTRUTTORE: Inizializza la connessione al database MongoDB
        public MongoDBContext(string connectionString, string databaseName)
        {
            var client = new MongoClient(connectionString);
            _database = client.GetDatabase(databaseName);
        }

        // PROPRIETÀ: Ritorna la collezione di diari chiamata "Testi"
        public IMongoCollection<Entity.Diario> Diari
        {
            get { return _database.GetCollection<Entity.Diario>("Testi"); }
        }
    }
}
