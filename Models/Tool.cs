using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CommonDataService.Models
{
    public partial class Tool
    {
        [Key]
        public int ID { get; set; }
        public int ToolID { get; set; }
        public string ToolCategoryName { get; set; }
        public string ToolInstanceName { get; set; }
        public string Description { get; set; }
    }
}
