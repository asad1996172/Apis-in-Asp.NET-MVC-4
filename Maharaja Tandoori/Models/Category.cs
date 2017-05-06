using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Maharaja_Tandoori.Models
{
    
    [Table("tblCategory")]
    public class Category
    {
        [Key]
        public Int64 Id { get; set; }
        public string Name { get; set; }
        public string NameFr { get; set; }
        public string NameDu { get; set; }
        public bool? IsActive { get; set; }
    }
}