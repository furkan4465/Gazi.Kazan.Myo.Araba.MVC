using Gazi.Kazan.Myo.Araba.MVC.BL;
using Gazi.Kazan.Myo.Araba.MVC.Models;
using Gazi.Kazan.Myo.Araba.MVC.Models.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gazi.Kazan.Myo.Araba.MVC.DAL
{
    public class OzelliklerDAL
    {
        public static bool Ekle(Ozellikler ozl)
        {
            try
            {
                ArabaContext ctx = new ArabaContext();
                ctx.ozelliklers.Add(ozl);
                return ctx.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Ozellikler Getir(int Id)
        {
            ArabaContext ctx = new ArabaContext();
            var ozellik = ctx.ozelliklers.Where(o => o.Id == Id).FirstOrDefault();
            if (ozellik != null)
                return ozellik;

            return null;
        }
        public static List<rOzellikler> Listele()
        {
            try
            {
                ArabaContext ctx = new ArabaContext();

                var sorgu = from ozl in ctx.ozelliklers
                            select new rOzellikler
                            {
                                Id = ozl.Id,
                                Marka = ozl.Marka,
                                Model = ozl.Model,
                                Yakıt = ozl.Yakıt,
                                Vıtes = ozl.Vıtes,
                                KasaTıpı = ozl.KasaTıpı,
                                Yılı = ozl.Yılı,
                                Beygir = ozl.Beygir,
                                Tork = ozl.Tork,
                                Hacim = ozl.Hacim,
                                Cekısturu = ozl.Cekısturu,
                                Renk = ozl.Renk,
                            };

                return sorgu.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool Sil(int Id)
        {
            try
            {
                ArabaContext ctx = new ArabaContext();
                var ogr = ctx.ozelliklers.Where(o => o.Id == Id).FirstOrDefault();
                if (ogr != null)
                {
                    ctx.ozelliklers.Remove(ogr);
                    return ctx.SaveChanges() > 0;
                }

                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool Guncelle(Ozellikler ozl)
        {
            ArabaContext ctx = new ArabaContext();
            Ozellikler o1 = ctx.ozelliklers.Where(o => o.Id == ozl.Id).FirstOrDefault();
            if (o1 != null)
            {
                o1.Marka = ozl.Marka;
                o1.Model = ozl.Model;
                o1.Hacim = ozl.Hacim;
                o1.Cekısturu = ozl.Cekısturu;
                o1.Beygir = ozl.Beygir;
                o1.KasaTıpı = ozl.KasaTıpı;
                o1.Renk = ozl.Renk;
                o1.Vıtes = ozl.Vıtes;
                o1.Yılı = ozl.Yılı;
                o1.Yakıt = ozl.Yakıt;
                o1.Tork = ozl.Tork;

                int sonuc = ctx.SaveChanges();
                if (sonuc > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            else
            {
                return false;
            }
        }

        public static bool DetayGuncelle(Detay d)
        {
            ArabaContext ctx = new ArabaContext();
            ctx.detays.Add(d);
            return ctx.SaveChanges() > 0;
        }

        public static Detay DetayGetir()
        {
            ArabaContext ctx = new ArabaContext();
            return ctx.detays.FirstOrDefault();
        }
    }
}