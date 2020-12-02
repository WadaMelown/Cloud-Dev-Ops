using System.Collections.Generic;
using purchase.Models;

namespace purchase.Data
{
    public interface IPurchasesRepo
    {
        UserBasket GetUserBasketById(int id);

        void CompletePurchase(UserBasket items);
    }
}