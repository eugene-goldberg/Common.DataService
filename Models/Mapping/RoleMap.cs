using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CommonDataService.Models.Mapping
{
    public class RoleMap : EntityTypeConfiguration<Role>
    {
        public RoleMap()
        {
            // Primary Key
            this.HasKey(t => t.RoleID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Roles");
            this.Property(t => t.RoleID).HasColumnName("RoleID");
            this.Property(t => t.RoleName).HasColumnName("RoleName");
            this.Property(t => t.RoleDescription).HasColumnName("RoleDescription");
            this.Property(t => t.AccountRolePerson_AccountRolePersonID).HasColumnName("AccountRolePerson_AccountRolePersonID");

            // Relationships
            this.HasOptional(t => t.AccountRolePerson)
                .WithMany(t => t.Roles)
                .HasForeignKey(d => d.AccountRolePerson_AccountRolePersonID);

        }
    }
}
