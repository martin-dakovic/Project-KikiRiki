using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCProjectTest.Models
{
    public class Product
    {
        public int id { get; set; }
        [Display(Name = "Naziv")]
        public string name { get; set; }

        [Display(Name = "Cijena")]
        public string cijena { get; set; }

        public string user { get; set; }

    }
}