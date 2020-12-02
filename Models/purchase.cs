using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace purchase.Models
{
    public class UserBasket
    {
        // dotnet add package MongoDB.Bson
        // mongodb.bson (maybe just this one) mongodb.driver
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int Id { get; set; }

        public List<UserBasketItem> Items { get; set; }
    }

    public class UserBasketItem 
    {
        public int Id { get; set; }

        public string Name { get; set;}

        public string ImageURL { get; set; }

        public double Price { get; set; }
    }
}