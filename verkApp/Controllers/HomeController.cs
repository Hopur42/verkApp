using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace verkApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "hello world!";

            return View();
        }

        public ActionResult Contact()
        {
            // Nýtt Comment
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}