using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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

        public async Task<ActionResult> CompletePurchase(UserBasket items)
        {
             _context.basket.Add(items);
            await _context.SaveChangesAsync();

            return null;
        }

        public async Task<UserBasket> GetUserBasketById(int id)
        {
            var userBasket = await _context.basket.FindAsync(id);

            if(userBasket == null) 
            {
                return null;
            }

            return userBasket;
        }
    }
}