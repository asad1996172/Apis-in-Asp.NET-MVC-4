using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Maharaja_Tandoori.Models
{
    [Table("tblProduct")]
    public class Product
    {
        [Key]
        public Int64 Id { get; set; }

        public Int64? CategoryId { get; set; }
        public string ProductCode { get; set; }
        public string Name { get; set; }
        public string NameFr { get; set; }
        public string NameDu { get; set; }
        public string Description { get; set; }
        public string DescriptionFr { get; set; }
        public string DescriptionDu { get; set; }
        public decimal? Price { get; set; }
        public decimal? FixedDiscount { get; set; }
        public decimal? DiscountPercentage { get; set; }
        public string Image { get; set; }
        public bool? IsActive { get; set; }



        //public int Id;
        //public int CategoryId;
        //public int ProductCode;
        //public string Name;
        //public string NameFr;
        //public string NameDu;
        //public string Description;
        //public string DescriptionFr;
        //public string DescriptionDu ;
        //public float Price ;
        //public float FixedDiscount;
        //public float DiscountPercentage;
        //public string Image ;
        //public bool IsActive ;

    }
}