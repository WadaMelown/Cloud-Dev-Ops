using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using purchase.Models;
using purchase.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Purchases.Controllers
{
    //api[commands]
    [Route("api/purchases")]
    [ApiController]
    public class PurchasesController : ControllerBase
    {
        private readonly IPurchasesRepo _repository;
        private readonly PurchaseContext _context;

        public PurchasesController(IPurchasesRepo repository, PurchaseContext context)
        {
            _repository = repository;
            _context = context;
        }
        
        // //private readonly MockpurchasesRepo _repositorty = new MockpurchasesRepo();
        // [HttpGet]
        // public ActionResult <IEnumerable<Purchase>> GetAllCommands()
        
        // {
        //     var purchaseItems = _repository.GetAppCommands();
        //     return Ok(purchaseItems);
        // }

        //GET api/commands/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<UserBasket>> GetCommandById(int id)
        {
            var item = await _context.basket.FindAsync(id);

            if(item == null) 
            {
                return NotFound();
            }
            // var purchaseItem = _repository.GetUserBasketById(id);
            return item;
        }

        // POST api/commands
        [HttpPut("{id}")]
        public async Task<IActionResult> CompleteItemPurchase(int id, UserBasket userBasketItems) 
        {
            
           _context.basket.Add(userBasketItems);
           await _context.SaveChangesAsync();
            // _repository.CompletePurchase(basket);

            return CreatedAtAction(nameof(GetCommandById), new {id = userBasketItems.UserBasketId }, userBasketItems);

        }
    }

}