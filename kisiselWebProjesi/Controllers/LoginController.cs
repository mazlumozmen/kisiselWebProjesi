using kisiselWebProjesi.Models.siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace kisiselWebProjesi.Controllers
{
    public class LoginController : Controller
    {
        context c = new context();

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(admin ad)
        {
            var bilgiler = c.Admins.FirstOrDefault(x => x.kullaniciAdi == ad.kullaniciAdi && x.sifre == ad.sifre);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.kullaniciAdi, false);
                Session["kullaniciAdi"] = bilgiler.kullaniciAdi.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index","Login");
        }
    }
}