using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApl.Extensions;
using MvcApl.Models;
using MvcApl.DAL;
using System.Linq;
using System.Web.Security;


namespace MvcApl.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        [HttpGet]
        public ActionResult Index()
        {
            ViewData["msg"] = "hello";

            YahiroHouse house = new YahiroHouse();
            house.HouseName = "yasaka1";

            List<CatMan> lstCats = new List<CatMan>();
            lstCats.Add(new CatMan("howa", "white"));
            lstCats.Add(new CatMan("omi", "茶色"));
            house.lstCats = lstCats;

            ViewData["Cats"] = lstCats;

            return View();
        }

        [HttpPost]
        [Button(ButtonName = "Search")]
        [ValidateAntiForgeryToken]
        public ActionResult Index(string search, string clear)
        {
            if (search != null)
            {
                Console.WriteLine("search");
                ViewData["msg"] = "search";

                //YahiroHouse house = new YahiroHouse();

                //List<CatMan> lstCats = house.GetCats();

                //ViewData["Cats"] = lstCats;

            }
            if (clear != null)
            {
                Console.WriteLine("clear");
            }

            return View();
        }

        //[HttpPost]
        //[Button(ButtonName = "Clear")]
        //[ValidateAntiForgeryToken]
        //public ActionResult Login(authmodel)

    }
}