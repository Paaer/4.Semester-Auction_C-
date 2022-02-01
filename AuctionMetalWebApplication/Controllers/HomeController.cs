using AuctionMetalWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuctionMetalWebApplication.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            if (Session["Name"] != null && Session["Email"] != null && Session["PhoneNumer"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult Login()
        {
            //TestData();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Buyer buyer)
        {
            if (ModelState.IsValid)
            {
                using (AuctionContext auctionContext = new AuctionContext())
                {
                    Session["Name"] = buyer.Name;
                    Session["Email"] = buyer.Email;
                    Session["PhoneNumer"] = buyer.PhoneNumer.ToString();
                    return RedirectToAction("Index");
                }
             }
            return View(buyer);
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Login");
        }
        public void TestData()
        {
            using (var auctionContext = new AuctionContext())
            {
                var buyer = new Buyer { BidAmount = 100, Email = "Per@email.dk", Name = "Per", PhoneNumer = "28357666" };
                var buyer2 = new Buyer { BidAmount = 150, Email = "Test@email.dk", Name = "Test", PhoneNumer = "12345678" };
              

                auctionContext.Buyers.Add(buyer);
                auctionContext.Buyers.Add(buyer2);
          

                var seller1 = new Seller { Amount = 100, CurrentBuyer = buyer, MetalType = "Gold", TimeLimit = new DateTime(2021, 06, 25, 23, 59, 59) };
                var seller2 = new Seller { Amount = 100, CurrentBuyer = buyer2, MetalType = "Palladium", TimeLimit = new DateTime(2021, 06, 15, 23, 59, 59) };
                var seller3 = new Seller { Amount = 100, CurrentBuyer = null, MetalType = "Platinum", TimeLimit = new DateTime(2021, 06, 12, 23, 59, 59) };
                auctionContext.Sellers.Add(seller1);
                auctionContext.Sellers.Add(seller2);
                auctionContext.Sellers.Add(seller3);
                auctionContext.SaveChanges();
            }
        }
    }
}