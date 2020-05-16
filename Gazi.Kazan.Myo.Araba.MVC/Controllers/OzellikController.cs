using Gazi.Kazan.Myo.Araba.MVC.BL;
using Gazi.Kazan.Myo.Araba.MVC.Models;
using Gazi.Kazan.Myo.Araba.MVC.Models.Parameter;
using Gazi.Kazan.Myo.Araba.MVC.Models.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gazi.Kazan.Myo.Araba.MVC.Controllers
{
    public class OzellikController : Controller
    {
        // GET: Ozellik
        public ActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ekle(pOzellikler p)
        {
            //Eğer ekleme yapılmışsa sonucumuz true döner.
            var sonuc = OzelliklerBl.Ekle(p);

            //sonuc değeri bool olduğu için if kontrolünde kullanabiliyoruz.
            if (sonuc)
                return Redirect("/Home/Index");

            return View();
        }

        public ActionResult Sil(int? Id)
        {

            OzelliklerBl.Sil(Convert.ToInt32(Id));

            return Redirect("/Home/Index");
        }

        public ActionResult Guncelle(int Id)
        {
            var sonuc = OzelliklerBl.Getir(Id);
            
            return View(sonuc);
        }

        [HttpPost]
        public ActionResult Guncelle(Ozellikler o, int? Guncelleme = 0)
        {

            //OzelliklerBl.Guncelle(new Ozellikler
            //{
            //    Marka = o.Marka,
            //    Model = o.Model,
            //    Beygir = o.Beygir,
            //    Cekısturu = o.Cekısturu,
            //    Hacim = o.Hacim,
            //    Id = o.Id,
            //    KasaTıpı = o.KasaTıpı,
            //    Renk = o.Renk,
            //    Tork = o.Tork,
            //    Vıtes = o.Vıtes,
            //    Yakıt = o.Yakıt,
            //    Yılı = o.Yılı
            //});

            OzelliklerBl.Guncelle(o);

            return Redirect("/Home/Index");
        }
    }
}