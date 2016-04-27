using System;
using System.Collections.Generic;

namespace CommonDataService.Models
{
    public partial class Person
    {
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string MI { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Nullable<int> AccountRolePerson_AccountRolePersonID { get; set; }
        public virtual AccountRolePerson AccountRolePerson { get; set; }
    }
}
