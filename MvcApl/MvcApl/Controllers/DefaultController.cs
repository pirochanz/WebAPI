using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApl.Extensions;

namespace MvcApl.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        [HttpGet]
        public ActionResult Index()
        {
            ViewData["msg"] = "hello";
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
            }
            if (clear != null)
            {
                Console.WriteLine("clear");
            }

            return View();
        }
    }
}