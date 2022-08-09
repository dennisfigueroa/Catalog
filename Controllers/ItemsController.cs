
using System.Collections.Generic;
using Catalog.Repositories;
using Microsoft.AspNetCore.Mvc;
using Catalog.Entities;
 namespace Catalog.Controllers 
 {
    [ApiController]
    [Route("items")]
    public class ItemsController : ControllerBase
    {
        private readonly InMemItemsRepository repository; 

        // Add ItemsController as constructor
        public ItemsController() {
            repository = new InMemItemsRepository();
        }
        // Get /items
        [HttpGet]
        public IEnumerable<Items> GetItems()
    {
        var items = repository.GetItems();
        return items;

    }
    }
 }