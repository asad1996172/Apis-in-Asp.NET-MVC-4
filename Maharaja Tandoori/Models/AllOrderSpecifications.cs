using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Maharaja_Tandoori.Models
{
    public class AllOrderSpecifications
    {
        [JsonProperty("ODOrderID")]
        public Int64 ODOrderID { get; set; }
        [JsonProperty("ODPrice")]
        public decimal ODPrice { get; set; }
        [JsonProperty("ODProductID")]
        public Int64 ODProductID { get; set; }
        [JsonProperty("ODQuantity")]
        public int ODQuantity { get; set; }
        [JsonProperty("ODProductExtraID")]
        public Int64 ODProductExtraID { get; set; }
        [JsonProperty("ODProductExtraPrice")]
        public decimal ODProductExtraPrice { get; set; }
    }
}