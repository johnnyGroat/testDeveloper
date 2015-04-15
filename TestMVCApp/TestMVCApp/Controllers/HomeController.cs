using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestMVCApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "What am I like?";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Here's how you can get @ me";

            return View();
        }

        public ActionResult Genrefy()
        {
            ViewBag.Message = "Genrefy Template";

            return View();
        }
    }
}
