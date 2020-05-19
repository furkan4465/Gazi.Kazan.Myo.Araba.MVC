using Gazi.Kazan.Myo.Araba.MVC.DAL;
using Gazi.Kazan.Myo.Araba.MVC.Models;
using Gazi.Kazan.Myo.Araba.MVC.Models.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gazi.Kazan.Myo.Araba.MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<rOzellikler> lst = OzelliklerDAL.Listele();
            if (lst != null)
                return View(lst);

            return View();
        }

        public ActionResult DetayGuncelle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DetayGuncelle(string detay)
        {
            return Redirect("Index");
        }
    }
}