using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Maharaja_Tandoori.Models
{
    public class AllProductExtras
    {
        public Int64 Id { get; set; }
        
        public string Name { get; set; }
        public string NameFr { get; set; }
        public string NameDu { get; set; }
        public decimal? Price { get; set; }
    }
}