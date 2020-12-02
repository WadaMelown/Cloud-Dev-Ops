using System.Collections.Generic;
using purchase.Models;

namespace purchase.Data
{
    public interface IpurchasesRepo
    {
        IEnumerable<Purchase> GetAppCommands();
        Purchase GetCommandById(int id);
    }
}