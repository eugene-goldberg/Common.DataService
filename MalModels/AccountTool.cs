using System;
using System.Collections.Generic;

namespace CommonDataService.Models
{
    public partial class AccountTool
    {
        public int ID { get; set; }
        public Nullable<int> Account_ID { get; set; }
        public virtual Account Account { get; set; }
    }
}
