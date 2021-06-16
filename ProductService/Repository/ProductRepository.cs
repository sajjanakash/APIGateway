using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductService.DatbaseContext;
using ProductService.Models;

namespace ProductService.Repository
{
    public class ProductRepository : IProduct
    {
        ProductContext _dbContext;
        public ProductRepository(ProductContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Product GetProductByName(string ProductName)
        {
            return _dbContext.Products.Find(ProductName);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _dbContext.Products.ToList();
        }

        public Product InsertProduct(Product product)
        {
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
            return product;
        }
    }
}
