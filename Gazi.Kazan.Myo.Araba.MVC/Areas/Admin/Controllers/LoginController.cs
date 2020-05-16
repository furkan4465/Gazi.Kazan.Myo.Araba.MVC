using Gazi.Kazan.Myo.Araba.MVC.BL;
using Gazi.Kazan.Myo.Araba.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gazi.Kazan.Myo.Araba.MVC.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Adminmodel admin)
        {
            var sonuc = AdminBl.Getir(admin);

            if (sonuc != null && sonuc.Id > 0)
            {
                Session["Admin"] = sonuc.KullanıcıAdı;
                return Redirect("/Home/Index");
            }

            return View();
        }
    }
}