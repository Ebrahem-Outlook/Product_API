using Microsoft.AspNetCore.Mvc;
using Product_API.Models;

namespace Product_API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ProductsController : ControllerBase    
    {
        private static List<Product> Products = new List<Product>
        {
            new Product { Name = "BMW", Price = 100000 },
            new Product { Name = "Mircidis", Price = 120000 },
        };

        // GET api/products
        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            return Products;
        }

        // Get api/products/id
        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id)
        {
            var product = Products.Find(p => p.Id == id);
            if(product == null)
            {
                return NotFound();
            }
            return product;
        }
    }
}
