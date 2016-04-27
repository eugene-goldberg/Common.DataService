using System;
using System.Collections.Generic;

namespace CommonDataService.Models
{
    public partial class AccountRolePerson
    {
        public AccountRolePerson()
        {
            this.Accounts = new List<Account>();
            this.People = new List<Person>();
            this.Roles = new List<Role>();
        }

        public int AccountRolePersonID { get; set; }
        public string AccountID { get; set; }
        public int PersonID { get; set; }
        public int RoleID { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<Person> People { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
    }
}
