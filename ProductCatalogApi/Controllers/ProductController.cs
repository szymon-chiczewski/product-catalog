using Microsoft.AspNetCore.Mvc;
using ProductCatalogApi.Models;
using System.Collections.Generic;

namespace ProductCatalogApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static List<Product> _products = new List<Product>();

        [HttpPost]
        public IActionResult AddProduct([FromBody] Product product)
        {
            _products.Add(product);
            return Ok(product);
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(_products);
        }
    }
}