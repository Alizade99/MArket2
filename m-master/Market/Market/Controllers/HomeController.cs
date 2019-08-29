using Market.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Helpers;

namespace Market.Controllers
{
    public class HomeController : Controller
    {
        MarketEntities1 db = new MarketEntities1();

        public ActionResult Index()
        {
            ViewBag.Product = db.Products.First();
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}