using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace purchase.Models
{
    public class UserBasket
    {
        public int UserBasketId { get; set; }

        public List<UserBasketItem> Items { get; set; }
    }

    public class UserBasketItem 
    {
        public int UserBasketItemId { get; set; }

        public string Name { get; set;}

        public string ImageURL { get; set; }

        public double Price { get; set; }

        public UserBasket basket {get; set; }

        public int UserBasketId { get; set; }
    }
}