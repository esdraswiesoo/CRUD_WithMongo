using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CrudWithMongo.API;

public class Product
{
    [BsonId] // define primary key
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    [BsonElement("Name")] // define column name
    public string Name { get; set; }

    public decimal Price { get; set; }
}
