using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC3101.Models
{
    [Table ("TBL_Osoba")]
    public class Osoba
    {
        [HiddenInput(DisplayValue = false)]
        [Display(AutoGenerateField = false)]
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Adresa { get; set; }
        public int Godine { get; set; }
    }



  
}