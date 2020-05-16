using Gazi.Kazan.Myo.Araba.MVC.Models;
using Gazi.Kazan.Myo.Araba.MVC.Models.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gazi.Kazan.Myo.Araba.MVC.DAL
{
    public class AdminDAL
    {
        public static rAdminmodel Getir(Adminmodel admin)
        {
            ArabaContext ctx = new ArabaContext();

            var sorgu = from a in ctx.admins
                        where a.KullanıcıAdı == admin.KullanıcıAdı && a.Sifre == admin.Sifre
                        select new rAdminmodel
                        {
                            KullanıcıAdı = a.KullanıcıAdı,
                            Sifre = a.Sifre,
                            Eposta = a.Eposta,
                            Id = a.Id
                        };

            return sorgu.FirstOrDefault();

        }
    }
}