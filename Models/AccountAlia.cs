using System;
using System.Collections.Generic;

namespace CommonDataService.Models
{
    public partial class AccountAlia
    {
        public int ID { get; set; }
        public int AccountAlilasID { get; set; }
        public string AliasName { get; set; }
        public string SourceSystem { get; set; }
        public string SourceColumn { get; set; }
        public string SourceValue { get; set; }
        public Nullable<int> Account_ID { get; set; }
        public virtual Account Account { get; set; }
    }
}
