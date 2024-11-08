using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace StoreApp.Catalog.Entities
{
    public class Category
    {
        [BsonId] //Id olduğnu belirtmek için bu iki attributeyi kullanıyoruz
        [BsonRepresentation(BsonType.ObjectId)] //Benzersiz olduğunu bildiriyoruz
        public string CategoryId { get; set; } //Guid
        public string CategoryName { get; set; }
    }
}
