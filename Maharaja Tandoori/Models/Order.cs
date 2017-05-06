using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Maharaja_Tandoori.Models
{
    
    [Table("tblOrder")]
    public class Order
    {
        [Key]
        public Int64 ID { get; set; }

        public decimal Amount { get; set; }
        public Int64 CustomerId { get; set; }
        public DateTime OrderDateTime { get; set; }
        public DateTime ConfirmedDateTime { get; set; }
        public Byte Status { get; set; }
        public string PaymentRefID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Zipcode { get; set; }
        public string City { get; set; }
        public string DeliveryAddress { get; set; }
        public string PayerID { get; set; }
        public string Notes { get; set; }
        public decimal AppliedDiscount { get; set; }
        public string PayBy { get; set; }
        public TimeSpan DeliveryTime { get; set; }
        public decimal PayWith { get; set; }
        public string OrderStatus { get; set; }
        public TimeSpan DeliveryMintues { get; set; }

    }
}