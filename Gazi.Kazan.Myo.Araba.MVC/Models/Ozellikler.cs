using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Gazi.Kazan.Myo.Araba.MVC.Models
{
    [Table("tblOzellikler")]
    public class Ozellikler
    {
        public int Id { get; set; }
        [Column(TypeName ="varchar")]
        [MaxLength(50)]
        public string Marka { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Model { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Yakıt { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Vıtes { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string KasaTıpı { get; set; }
        public int Yılı { get; set; }

        public int Beygir { get; set; }
        public int Tork { get; set; }
        public int Hacim { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Cekısturu { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Renk { get; set; }
    }
}