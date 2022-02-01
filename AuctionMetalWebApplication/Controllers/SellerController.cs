using AuctionMetalWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace AuctionMetalWebApplication.Controllers
{
    public class SellerController : Controller
    {
        private AuctionContext auctionContext = new AuctionContext();

        // GET: Seller
        public ActionResult Index()
        {
            
            if(Session["Name"] != null && Session["Email"] != null && Session["PhoneNumer"] != null)
            {
                var sellers = auctionContext.Sellers.Include(so => so.CurrentBuyer)
                .AsNoTracking(); 
                return View(sellers.ToList());
            }
            else
            {
                return Redirect("/Home/Login");
            }
        }

        public ActionResult Create()
        {
            if (Session["Name"] != null && Session["Email"] != null && Session["PhoneNumer"] != null)
            {
                return View();
            }
            else
            {
                return Redirect("/Home/Login");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(int? sellerId, [Bind(Include = "BuyerId,BidAmount")] Buyer buyer)
        {
            if (ModelState.IsValid)
            {
                Seller seller = auctionContext.Sellers.Find(sellerId);
                auctionContext.Entry(seller).Reference(so => so.CurrentBuyer).Load();
                if (seller.TimeLimit > DateTime.Now)
                {
                    if (seller.HighestBidder == 0 || seller.HighestBidder < buyer.BidAmount)
                    {
                        buyer.Name = (string)Session["Name"];
                        buyer.PhoneNumer = (string)Session["PhoneNumer"];
                        buyer.Email = (string)Session["Email"];
                        auctionContext.Buyers.Add(buyer);
                        seller.CurrentBuyer = buyer;
                        auctionContext.SaveChanges();
                        return RedirectToAction("Index");
                    }

                }
            }
                return View(buyer);
            }
        }
        
    }
