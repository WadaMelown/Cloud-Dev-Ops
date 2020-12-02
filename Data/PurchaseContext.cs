using Microsoft.EntityFrameworkCore;
using purchase.Models;

namespace Purchases.Data
{
    public class PurchaseContext : DbContext
    {
        public PurchaseContext(DbContextOptions<PurchaseContext> opt) : base(opt)
        {

        }

        public DbSet<Purchase> purchase { get; set; }
    }
}