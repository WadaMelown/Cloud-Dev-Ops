using Microsoft.AspNetCore.Mvc;
using purchases.Data;
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
        private readonly IpurchasesRepo _repository;

        public PurchasesController(IpurchasesRepo repository)
        {
            _repository = repository;
        }
        
        //private readonly MockpurchasesRepo _repositorty = new MockpurchasesRepo();
        [HttpGet]
        public ActionResult <IEnumerable<Purchase>> GetAllCommands()
        
        {
            var purchaseItems = _repository.GetAppCommands();
            return Ok(purchaseItems);
        }

        //GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult <Purchase> GetCommandById(int id)
        
        {
            var purchaseItem = _repository.GetCommandById(id);
            return Ok(purchaseItem);
        }
    }

}