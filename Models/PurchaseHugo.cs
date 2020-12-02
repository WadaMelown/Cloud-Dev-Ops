using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace purchase.Models
{
    public class Product
    {
        // dotnet add package MongoDB.Bson
        // mongodb.bson (maybe just this one) mongodb.driver
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public List<ProductItem> Items { get; set; }
    }

    public class ProductItem 
    {
        public string Id { get; set; }

        public string Name { get; set;}

        public string ImageURL { get; set; }

        public decimal Price { get; set; }
    }
}