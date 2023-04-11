using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kocaeli_dron.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Anasayfa
            ()
        {
            return View();
        }

        public ActionResult Hakkimda()
        {
           

            return View();
        }

        public ActionResult İletisim()
        {
            

            return View();
        }
        public ActionResult Hizmetlerim()
        {
            return View();
        }
       
    }
}