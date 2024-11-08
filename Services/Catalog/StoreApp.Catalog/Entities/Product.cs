using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace StoreApp.Catalog.Entities
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductImageUrl { get; set; }
        public string ProductDescription { get; set; }
        public string CategoryId { get; set; }
        [BsonIgnore] //Nesneden MongoDb belgesine dönüştürülürken ilgili kısmı dikkate alma.
        public Category Category { get; set; }
    }
}
