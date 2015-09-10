using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCProjectTest.ViewModels
{
    public class ProductViewModel
    {
       
            public int id { get; set; }
            [Display(Name = "Nazivv")]
            public string name { get; set; }

            [Display(Name = "Cijenaa")]
            public string cijena { get; set; }
    }
}
