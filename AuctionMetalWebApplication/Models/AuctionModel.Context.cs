using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AuctionMetalWebApplication.Models
{
    public class AuctionContext : DbContext
    {
        public AuctionContext() : base("name=CodeFirstAuction")
        {

        }

        public DbSet<Buyer> Buyers { get; set; }

        public DbSet<Seller> Sellers { get; set; }



    }
}