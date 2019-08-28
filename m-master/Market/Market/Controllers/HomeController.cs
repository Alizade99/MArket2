using Market.Models;
using System;
using Market.ViewModel.Default;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Helpers;

namespace Market.Controllers
{
    public class HomeController : Controller
    {
        MarketEntities db = new MarketEntities();

        public ActionResult Index()
        {
            var defaultModel = new DefaultViewModel()
            {
                Brand=db.Brands.First(),
                AboutU=db.AboutUs.First(),

            }