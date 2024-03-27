using kisiselWebProjesi.Models.siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace kisiselWebProjesi.Controllers
{
    public class AnaSayfaController : Controller
    {
        context c = new context();
        
        // GET: AnaSayfa
        public ActionResult Index()
        {
            var deger = c.AnaSayfas.ToList();
            return View(deger);
        }
        public PartialViewResult ikonlar()
        {
            var deger = c.İkonlars.ToList();
            return PartialView(deger);
        }
    }
}