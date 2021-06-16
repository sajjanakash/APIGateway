﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductService.Models;

namespace ProductService.DatbaseContext
{
    public class ProductContext:DbContext
    {
        public DbSet<Product> Products{ get; set; }
        public ProductContext(DbContextOptions<ProductContext> options)
           : base(options)
        {
        }


    }
}
