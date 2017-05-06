using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Maharaja_Tandoori.Models
{
    [Table("tblProductExtra")]
    public class ProductExtra
    {
        [Key]
        public Int64 Id { get; set; }
        public Int64? ProductId { get; set; }
        public string Name { get; set; }
        public string NameFr { get; set; }
        public string NameDu { get; set; }
        public decimal? Price { get; set; }
    }
}