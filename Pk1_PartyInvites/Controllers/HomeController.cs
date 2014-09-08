using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pk1_PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public String Index()
        {
            return "Hola ITGAM";
        }
        public ActionResult Index()
        {
            var hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Buenos Dias!!" : "Buenas tardes!!";
            return View();
        }
        public ViewResult GetTimeImage()
        {
            var hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour;
            return View();
        }

    }
}
