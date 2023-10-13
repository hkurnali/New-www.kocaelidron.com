using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace Kocaeli_dron.Controllers
{
    public class IletisimController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string Adsoyad = null, string Mail = null, string Telefon = null, string Mesaj = null)
        {
            if (Adsoyad != null && Mail != null && Telefon != null && Mesaj != null)
            {
                WebMail.SmtpServer = "mail.kocaelidron.com";
                WebMail.EnableSsl = false;
                WebMail.UserName = "info@kocaelidron.com";
                WebMail.Password = "Tel5568881.";
                WebMail.SmtpPort = 587;
                WebMail.Send("info@kocaelidron.com", Adsoyad, Telefon + "-" + Mail + "-" + Mesaj);
                ViewBag.uyari = "Mesajınız Gönderilmiştir.";
            }
            else
            {
                ViewBag.uyari = "Hata Oluştu Tekrar Deneyiniz.";
            }
            return View();
        }
    }
}