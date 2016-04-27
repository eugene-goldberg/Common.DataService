using System;
using System.Collections.Generic;

namespace CommonDataService.Models
{
    public partial class Service
    {
        public Service()
        {
            this.Accounts = new List<Account>();
        }

        public int ServiceID { get; set; }
        public string ServiceName { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
    }
}
