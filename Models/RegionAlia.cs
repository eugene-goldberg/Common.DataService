using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CommonDataService.Models
{
    public partial class RegionAlia
    {
        [Key]
        public int RegionAliasID { get; set; }
        public string RegionName { get; set; }
        public string SourceSystem { get; set; }
        public string SourceColumn { get; set; }
        public string SourceValue { get; set; }
    }
}
