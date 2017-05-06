using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Maharaja_Tandoori.Models
{

    [Table("tblPromotion")]
    public class Promotion
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public string DiscountCoupon { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public decimal? Discount { get; set; }
    }
}