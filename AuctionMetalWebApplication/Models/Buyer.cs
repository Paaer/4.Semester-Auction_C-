using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuctionMetalWebApplication.Models
{
    public class Buyer
    {
        public int BuyerId { get; set; }
        public int BidAmount { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumer { get; set; }

    }
}