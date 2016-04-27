using System;
using System.Collections.Generic;

namespace CommonDataService.Models
{
    public partial class Role
    {
        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public Nullable<int> AccountRolePerson_AccountRolePersonID { get; set; }
        public virtual AccountRolePerson AccountRolePerson { get; set; }
    }
}
