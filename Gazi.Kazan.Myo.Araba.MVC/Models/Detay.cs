using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Gazi.Kazan.Myo.Araba.MVC.Models
{
    [Table("tblDetaylar")]
    public class Detay
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(500)]
        public string Aciklama { get; set; }
    }
}