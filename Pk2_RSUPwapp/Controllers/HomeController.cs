using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pk2_RSUPwapp.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var hour = DateTime.Now.Hour;//aqui define la hora del sistema
            ViewBag.Greeting = hour < 12 ? "Buenos Dias!!" : "Buenas tardes!!";//aki elige si es antes o desp de las doce 
            return View();//retorna la vista
        }

    }
}
