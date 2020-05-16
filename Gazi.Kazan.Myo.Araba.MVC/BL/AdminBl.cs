using Gazi.Kazan.Myo.Araba.MVC.DAL;
using Gazi.Kazan.Myo.Araba.MVC.Models;
using Gazi.Kazan.Myo.Araba.MVC.Models.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gazi.Kazan.Myo.Araba.MVC.BL
{
    public class AdminBl
    {
        public bool AdminEkle(Adminmodel prs)
        {
            try
            {
                ArabaContext ctx = new ArabaContext();
                ctx.admins.Add(prs);
                return ctx.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool Sil(Adminmodel adm)
        {
            try
            {
                ArabaContext ctx = new ArabaContext();
                ctx.admins.Remove(adm);
                return ctx.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool Guncelle(Adminmodel p, int AdmId)
        {
            try
            {
                ArabaContext ctx = new ArabaContext();
                Adminmodel adm = ctx.admins.Find(AdmId);
                if (adm != null)
                {

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
            catch (Exception)
            {

                throw;
            }
        }

        public List<Adminmodel> Listele()
        {
            try
            {
                ArabaContext ctx = new ArabaContext();
                List<Adminmodel> lst = ctx.admins.ToList();

                if (lst != null)
                {
                    return lst;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static rAdminmodel Getir(Adminmodel admin)
        {
            try
            {
                return AdminDAL.Getir(admin);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}