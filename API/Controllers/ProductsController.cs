using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{   
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext _context;
        //Type CTOR for making easly the Constructor
        public ProductsController(StoreContext context)
        {
            _context = context;
        }    

        //Endpoint for get the list of Products
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var products = await _context.Products.ToListAsync();

            return Ok(products);
        }

        //The "Task" in async method who is used to make asynchronus operations.
        //They suport async and await keywords.

        //Endpoint for get a specify product
        [HttpGet("{id}")] // example: api/products/3
        public async Task<ActionResult<Product>> GetProduct(int id) 
        {
            var product = await _context.Products.FindAsync(id);
            return product;
        }
    }
}