using Microsoft.EntityFrameworkCore;
using purchase.Models;

namespace purchase.Data
{
    public class PurchaseContext : DbContext
    {
        public PurchaseContext(DbContextOptions<PurchaseContext> opt) : base(opt)
        {

        }

        public DbSet<UserBasket> basket { get; set; }
    }
}