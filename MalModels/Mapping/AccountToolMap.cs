using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CommonDataService.Models.Mapping
{
    public class AccountToolMap : EntityTypeConfiguration<AccountTool>
    {
        public AccountToolMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("AccountTools");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Account_ID).HasColumnName("Account_ID");

            // Relationships
            this.HasOptional(t => t.Account)
                .WithMany(t => t.AccountTools)
                .HasForeignKey(d => d.Account_ID);

        }
    }
}
