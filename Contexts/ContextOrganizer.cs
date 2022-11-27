using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tech_test_payment_api.Models;
using Microsoft.EntityFrameworkCore;


namespace tech_test_payment_api.Contexts
{
    public class ContextOrganizer : DbContext
    {
         public ContextOrganizer(DbContextOptions<ContextOrganizer> options) : base (options)

         {

         }

         public DbSet<Seller> Sellers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderSale> OrderSales { get; set; }
    }
}