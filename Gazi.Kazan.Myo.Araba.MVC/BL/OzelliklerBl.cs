﻿using Gazi.Kazan.Myo.Araba.MVC.DAL;
using Gazi.Kazan.Myo.Araba.MVC.Models;
using Gazi.Kazan.Myo.Araba.MVC.Models.Parameter;
using Gazi.Kazan.Myo.Araba.MVC.Models.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gazi.Kazan.Myo.Araba.MVC.BL
{
    public class OzelliklerBl
    {

        public static bool Ekle(pOzellikler ozl)
        {
            try
            {
                Ozellikler o = new Ozellikler();
                o.Marka = ozl.Marka;
                o.Model = ozl.Model;
                o.Yakıt = ozl.Yakıt;
                o.Vıtes = ozl.Vıtes;
                o.KasaTıpı = ozl.KasaTıpı;
                o.Yılı = ozl.Yılı;
                o.Beygir = ozl.Beygir;
                o.Tork = ozl.Tork;
                o.Hacim = ozl.Hacim;
                o.Cekısturu = ozl.Cekısturu;
                o.Renk = ozl.Renk;

                return OzelliklerDAL.Ekle(o);
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
                return OzelliklerDAL.Sil(Id);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static bool Guncelle(Ozellikler o)
        {
            try
            {
                return OzelliklerDAL.Guncelle(o);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<rOzellikler> Listele()
        {
            try
            {
                return OzelliklerDAL.Listele();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Ozellikler Getir(int Id)
        {
            try
            {
                return OzelliklerDAL.Getir(Id);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}