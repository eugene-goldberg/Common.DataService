using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CommonDataService.Models
{
    public partial class DimStatu
    {
        [Key]
        public int StatusKey { get; set; }
        public string Status1 { get; set; }
        public string Status2 { get; set; }
        public string Status3 { get; set; }
        public string Status4 { get; set; }
        public string Status5 { get; set; }
        public string Status6 { get; set; }
        public string Status7 { get; set; }
    }
}
