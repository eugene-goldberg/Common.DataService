using System;
using System.Collections.Generic;

namespace CommonDataService.Models
{
    public partial class Tool
    {
        public int ToolID { get; set; }
        public string ToolCategoryName { get; set; }
        public string ToolInstanceName { get; set; }
        public string Description { get; set; }
        public string ToolRegisterID { get; set; }
    }
}
