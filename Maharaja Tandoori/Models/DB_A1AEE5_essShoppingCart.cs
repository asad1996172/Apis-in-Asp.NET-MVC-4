using Maharaja_Tandoori.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Maharaja_Tandoori.Services
{
    public class DB_A1AEE5_essShoppingCart : DbContext
    {
        
        public DbSet<Product> Products
        {
            get;
            set;
        }
        public DbSet<ZipCodes> ZipCodes
        {
            get;
            set;
        }
        public DbSet<ProductExtra> ProductExtras
        {
            get;
            set;
        }
        public DbSet<Category> Categories
        {
            get;
            set;
        }

        public DbSet<Promotion> Promotions
        {
            get;
            set;
        }
        public DbSet<Setup> Settings
        {
            get;
            set;
        }
        public DbSet<Order> Orders
        {
            get;
            set;
        }
        public DbSet<OrderDetails> OrderDetails
        {
            get;
            set;
        }
    }
}