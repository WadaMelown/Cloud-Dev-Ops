using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using purchase.Models;

namespace purchase.Data
{
    public interface IPurchasesRepo
    {
        Task<UserBasket> GetUserBasketById(int id);

        Task<ActionResult> CompletePurchase(UserBasket items);
    }
}