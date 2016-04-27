using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CommonDataService.Models.Mapping
{
    public class DimAccountMap : EntityTypeConfiguration<DimAccount>
    {
        public DimAccountMap()
        {
            // Primary Key
            this.HasKey(t => t.AccountKey);

            // Properties
            this.Property(t => t.Account1)
                .HasMaxLength(200);

            this.Property(t => t.Account2)
                .HasMaxLength(200);

            this.Property(t => t.Account3)
                .HasMaxLength(50);

            this.Property(t => t.Account4)
                .HasMaxLength(50);

            this.Property(t => t.Account5)
                .HasMaxLength(50);

            this.Property(t => t.Account6)
                .HasMaxLength(50);

            this.Property(t => t.Account7)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DimAccount");
            this.Property(t => t.AccountKey).HasColumnName("AccountKey");
            this.Property(t => t.Account1).HasColumnName("Account1");
            this.Property(t => t.Account2).HasColumnName("Account2");
            this.Property(t => t.Account3).HasColumnName("Account3");
            this.Property(t => t.Account4).HasColumnName("Account4");
            this.Property(t => t.Account5).HasColumnName("Account5");
            this.Property(t => t.Account6).HasColumnName("Account6");
            this.Property(t => t.Account7).HasColumnName("Account7");
        }
    }
}
