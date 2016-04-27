using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CommonDataService.Models
{
    public partial class DimVip
    {
        [Key]
        public int VipKey { get; set; }
        public string Vip1 { get; set; }
        public string Vip2 { get; set; }
        public string Vip3 { get; set; }
        public string Vip4 { get; set; }
        public string Vip5 { get; set; }
        public string Vip6 { get; set; }
        public string Vip7 { get; set; }
    }
}
