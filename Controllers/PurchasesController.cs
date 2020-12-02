using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using purchase.Models;
using purchase.Data;

namespace Purchases.Controllers
{
    //api[commands]
    [Route("api/purchases")]
    [ApiController]
    public class PurchasesController : ControllerBase
    {
        private readonly IPurchasesRepo _repository;

        public PurchasesController(IPurchasesRepo repository)
        {
            _repository = repository;
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
        public IActionResult GetCommandById(int id)
        {
            var purchaseItem = _repository.GetUserBasketById(id);
            return Ok(purchaseItem);
        }

        // POST api/commands
        [HttpPost]
        public IActionResult CompleteItemPurchase(UserBasket basket) 
        {
            if(basket == null) 
            {
                return NotFound();
            }

            _repository.CompletePurchase(basket);

            return NoContent();

        }
    }

}