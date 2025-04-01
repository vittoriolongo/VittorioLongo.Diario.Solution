using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace VittorioLongo.Diario.Entity
{
    public class Diario
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ObjectID;
        public int UserID;
        public string Testo;
        public DateTime DataTesto;

    }
}

