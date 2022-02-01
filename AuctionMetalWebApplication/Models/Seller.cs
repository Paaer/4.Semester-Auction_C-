using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuctionMetalWebApplication.Models
{
    public class Seller
    {
        public int SellerId { get; set; }
        public string MetalType { get; set; }

        public int Amount { get; set; }

        public DateTime TimeLimit { get; set; }

        public Buyer CurrentBuyer { get; set; }

        public string TimeLeft => CalcTimeLeft(TimeLimit);

        public double HighestBidder { get
            {
                if (CurrentBuyer != null)
                {
                    return CurrentBuyer.BidAmount;
                }
                else
                {
                    return 0;
                }

            }
        }
        public String CalcTimeLeft(DateTime time)
        {
            if (time < DateTime.Now)
            {
                return "Udløbet";
            }
            else
            {
                TimeSpan TimeRemaining = time - DateTime.Now;
                return TimeRemaining.ToString(@"dd\.hh\:mm\:ss");
            }

        }

    }
}