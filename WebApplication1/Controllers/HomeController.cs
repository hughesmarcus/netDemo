using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult BuyersSellers()
        {
            return View();
        }
        public ActionResult Items()
        {
            return  RedirectToAction("Index", "Item");
        }
        public ActionResult Users()
        {
            return RedirectToAction("Index", "Buyer");
        }
        public ActionResult Buyers()
        {
            return RedirectToAction("Index", "Buyer");
        }
        public ActionResult Sellers()
        {
            return RedirectToAction("Index", "Seller");
        }
        public ActionResult Transactions()
        {
            return RedirectToAction("Index", "Transaction");
        }
        public ActionResult SalesPeople()
        {
            return RedirectToAction("Index", "SalesPerson");

        }
    }
}