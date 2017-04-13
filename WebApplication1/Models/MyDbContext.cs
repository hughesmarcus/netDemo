using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("Van")
        {

        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Buyer> Buyers { get; set; }
        public DbSet<SalesPerson> SalesPeople { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}