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

        //GET api/commands/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<UserBasket>> GetCommandById(int id)
        {
            var item = await _repository.GetUserBasketById(id);

            if(item == null) 
            {
                return NotFound();
            }
            return item;
        }

        // POST api/commands
        [HttpPost("{id}")]
        public IActionResult CompleteItemPurchase(int id, UserBasket userBasketItems) 
        {
            
            _repository.CompletePurchase(userBasketItems);
            
            return CreatedAtAction(nameof(GetCommandById), new {id = userBasketItems.UserBasketId }, userBasketItems);

        }
    }

}