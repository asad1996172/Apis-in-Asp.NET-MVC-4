using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Maharaja_Tandoori.Models
{
    
    [Table("tblSetup")]
    public class Setup
    {
        [Key]
        public int Id { get; set; }
        public bool? Status { get; set; }
        public string Timing { get; set; }
        public int? DeliveryCost { get; set; }
        public decimal? PayPalCost { get; set; }
        public decimal? MinimumOrderAmount { get; set; }
        
    }
}