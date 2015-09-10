using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProjectTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Route("aaa/bbb")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View("About");
        }

        [Route("aaa/bbb")]
        [HttpPost]
        public ActionResult About(string text)
        {
            ViewBag.Message = "And here we go " + text;

            return View("About");
        }



        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}