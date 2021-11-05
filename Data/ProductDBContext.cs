using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DemoNetCore.Models;

    public class ProductDBContext : DbContext
    {
        public ProductDBContext (DbContextOptions<ProductDBContext> options)
            : base(options)
        {
        }

        public DbSet<DemoNetCore.Models.Product> Product { get; set; }
    }
