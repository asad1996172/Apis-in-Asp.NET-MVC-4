using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Maharaja_Tandoori.Models
{

    public class ProductDetails
    {

        public Int64 Id { get; set; }

        public string CategoryName { get; set; }
        public string CategoryNameFr { get; set; }
        public string CategoryNameDu { get; set; }
        public bool? CategoryIsActive { get; set; }

        public IEnumerable<AllProducts> products { get; set; }
       
    }

}