using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CommonDataService.Models.Mapping
{
    public class AccountAliaMap : EntityTypeConfiguration<AccountAlia>
    {
        public AccountAliaMap()
        {
            // Primary Key
            this.HasKey(t => t.AccountAlilasID);

            // Properties
            this.Property(t => t.Account_AccountID)
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("AccountAlias");
            this.Property(t => t.AccountAlilasID).HasColumnName("AccountAlilasID");
            this.Property(t => t.AliasName).HasColumnName("AliasName");
            this.Property(t => t.SourceSystem).HasColumnName("SourceSystem");
            this.Property(t => t.SourceColumn).HasColumnName("SourceColumn");
            this.Property(t => t.SourceValue).HasColumnName("SourceValue");
            this.Property(t => t.Account_AccountID).HasColumnName("Account_AccountID");

            // Relationships
            this.HasOptional(t => t.Account)
                .WithMany(t => t.AccountAlias)
                .HasForeignKey(d => d.Account_AccountID);

        }
    }
}
