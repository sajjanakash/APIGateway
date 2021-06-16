using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductService.Models;

namespace ProductService.Repository
{
   public  interface IProduct
    {
        IEnumerable<Product> GetProducts();

        Product InsertProduct(Product product);
        Product GetProductByName(string ProductName);






    }
}
