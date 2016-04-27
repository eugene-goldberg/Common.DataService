using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CommonDataService.Models.Mapping
{
    public class DimContactSourceMap : EntityTypeConfiguration<DimContactSource>
    {
        public DimContactSourceMap()
        {
            // Primary Key
            this.HasKey(t => t.ContactSourceKey);

            // Properties
            this.Property(t => t.ContactSource1)
                .HasMaxLength(100);

            this.Property(t => t.ContactSource2)
                .HasMaxLength(200);

            this.Property(t => t.ContactSource3)
                .HasMaxLength(50);

            this.Property(t => t.ContactSource4)
                .HasMaxLength(50);

            this.Property(t => t.ContactSource5)
                .HasMaxLength(50);

            this.Property(t => t.ContactSource6)
                .HasMaxLength(50);

            this.Property(t => t.ContactSource7)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DimContactSource");
            this.Property(t => t.ContactSourceKey).HasColumnName("ContactSourceKey");
            this.Property(t => t.ContactSource1).HasColumnName("ContactSource1");
            this.Property(t => t.ContactSource2).HasColumnName("ContactSource2");
            this.Property(t => t.ContactSource3).HasColumnName("ContactSource3");
            this.Property(t => t.ContactSource4).HasColumnName("ContactSource4");
            this.Property(t => t.ContactSource5).HasColumnName("ContactSource5");
            this.Property(t => t.ContactSource6).HasColumnName("ContactSource6");
            this.Property(t => t.ContactSource7).HasColumnName("ContactSource7");
        }
    }
}
