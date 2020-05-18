using Gazi.Kazan.Myo.Araba.MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Gazi.Kazan.Myo.Araba.MVC.DAL
{
    public class ArabaContext : DbContext
    {
        public ArabaContext(): base ("cstr")
        {



        }

        public DbSet<Ozellikler> ozelliklers { get; set; }
        public DbSet<Adminmodel> admins { get; set; }
        public DbSet<Detay> detays { get; set; }
    }
}