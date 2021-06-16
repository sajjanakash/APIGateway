using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductService.Models;
using ProductService.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {


        private IProduct _product;

        public ProductController(IProduct product)
        {
            _product = product;
        }
        // GET: api/<ProductController>
        [HttpGet]
       
            public IEnumerable<Product> Get()
            {
                return _product.GetProducts();
            
             }

        // GET api/<ProductController>/5
        [HttpGet("{Name}")]
        public IActionResult Get(string Name)
        {
            var products = _product.GetProductByName(Name);
            return new OkObjectResult(products);
        }

        // POST api/<ProductController>
        [HttpPost]
        public IActionResult Post([FromBody] Product product)
        {

            _product.InsertProduct(product);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host
                + HttpContext.Request.Path + "/" + product.ProductId, product);





        }


    }
}
