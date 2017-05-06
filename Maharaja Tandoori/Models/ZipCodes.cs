using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Maharaja_Tandoori.Models
{
   
    [Table("tblZipCode")]
    public class ZipCodes
    {
        [Key]
        public Int64 Id { get; set; }
        public string ZipCode { get; set; }
        public string AreaName { get; set; }
        public bool? IsActive { get; set; }
    }
   
}