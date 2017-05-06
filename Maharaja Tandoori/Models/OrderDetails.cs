using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Maharaja_Tandoori.Models
{
    [Table("tblOrderDetails")]
    public class OrderDetails
    {
        [Key]
        public Int64 ID { get; set; }
        public Int64 OderID { get; set; }
        public decimal Price { get; set; }
        public Int64 ProductID { get; set; }
        public int Quantity { get; set; }
        public Int64 ProductExtraID { get; set; }
        public decimal ProductExtraPrice { get; set; }
    }
}