using System.Collections.Generic;
using purchase.Models;


namespace purchase.Data
{
    public class PurchaseRepo : IPurchasesRepo
    {
        private readonly PurchaseContext _context;

        public PurchaseRepo(PurchaseContext context) 
        {
            _context = context;
        }

        public void CompletePurchase(UserBasket items)
        {
            var Test = _context.basket.Add(items);
            //_context.basket.Add(items);
        }

        public UserBasket GetUserBasketById(int id)
        {
            var userBasket = _context.basket.Find(id);

            if(userBasket == null) 
            {
                return null;
            }

            return userBasket;
        }
    }
}