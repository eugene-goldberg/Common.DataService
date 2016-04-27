using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CommonDataService.Models.Mapping
{
    public class PersonMap : EntityTypeConfiguration<Person>
    {
        public PersonMap()
        {
            // Primary Key
            this.HasKey(t => t.PersonID);

            // Properties
            // Table & Column Mappings
            this.ToTable("People");
            this.Property(t => t.PersonID).HasColumnName("PersonID");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.MI).HasColumnName("MI");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.PhoneNumber).HasColumnName("PhoneNumber");
            this.Property(t => t.AccountRolePerson_AccountRolePersonID).HasColumnName("AccountRolePerson_AccountRolePersonID");

            // Relationships
            this.HasOptional(t => t.AccountRolePerson)
                .WithMany(t => t.People)
                .HasForeignKey(d => d.AccountRolePerson_AccountRolePersonID);

        }
    }
}
