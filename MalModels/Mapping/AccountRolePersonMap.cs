using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CommonDataService.Models.Mapping
{
    public class AccountRolePersonMap : EntityTypeConfiguration<AccountRolePerson>
    {
        public AccountRolePersonMap()
        {
            // Primary Key
            this.HasKey(t => t.AccountRolePersonID);

            // Properties
            // Table & Column Mappings
            this.ToTable("AccountRolePersons");
            this.Property(t => t.AccountRolePersonID).HasColumnName("AccountRolePersonID");
            this.Property(t => t.AccountID).HasColumnName("AccountID");
            this.Property(t => t.PersonID).HasColumnName("PersonID");
            this.Property(t => t.RoleID).HasColumnName("RoleID");
        }
    }
}
