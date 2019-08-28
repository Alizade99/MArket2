using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Market.Areas.MarketAdmin.Controllers
{
    public class HomeController : Controller
    {
        // GET: MarketAdmin/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}