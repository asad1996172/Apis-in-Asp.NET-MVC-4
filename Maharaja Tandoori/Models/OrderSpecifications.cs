using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Maharaja_Tandoori.Models
{
    public class OrderSpecifications
    {
        [JsonProperty("Amount")]
        public decimal Amount { get; set; }
        [JsonProperty("CustomerId")]
        public Int64 CustomerId { get; set; }
        [JsonProperty("OrderDateTime")]
        public string OrderDateTime { get; set; }
        [JsonProperty("ConfirmedDateTime")]
        public string ConfirmedDateTime { get; set; }
        [JsonProperty("Status")]
        public Byte Status { get; set; }
        [JsonProperty("PaymentRefID")]
        public string PaymentRefID { get; set; }
        [JsonProperty("FirstName")]
        public string FirstName { get; set; }
        [JsonProperty("LastName")]
        public string LastName { get; set; }
        [JsonProperty("Phone")]
        public string Phone { get; set; }
        [JsonProperty("Email")]
        public string Email { get; set; }
        [JsonProperty("Zipcode")]
        public string Zipcode { get; set; }
        [JsonProperty("City")]
        public string City { get; set; }
        [JsonProperty("DeliveryAdress")]
        public string DeliveryAdress { get; set; }
        [JsonProperty("PayerID")]
        public string PayerID { get; set; }
        [JsonProperty("Notes")]
        public string Notes { get; set; }
        [JsonProperty("AppliedDiscount")]
        public decimal AppliedDiscount { get; set; }
        [JsonProperty("PayBy")]
        public string PayBy { get; set; }
        [JsonProperty("DeliveryTime")]
        public string DeliveryTime { get; set; }
        [JsonProperty("PayWith")]
        public decimal PayWith { get; set; }
        [JsonProperty("OrderStatus")]
        public string OrderStatus { get; set; }
        [JsonProperty("DeliveryMinutes")]
        public string DeliveryMinutes { get; set; }
        [JsonProperty("OrderDetail")]
        public IEnumerable<AllOrderSpecifications> OrderDetail { get; set; }

        public OrderSpecifications() { }
    }
}