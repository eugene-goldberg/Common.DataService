using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CommonDataService.Models.Mapping
{
    public class DimCauseCodeMap : EntityTypeConfiguration<DimCauseCode>
    {
        public DimCauseCodeMap()
        {
            // Primary Key
            this.HasKey(t => t.CauseCodeKey);

            // Properties
            this.Property(t => t.CauseCode1)
                .HasMaxLength(200);

            this.Property(t => t.CauseCode2)
                .HasMaxLength(200);

            this.Property(t => t.CauseCode3)
                .HasMaxLength(200);

            this.Property(t => t.CauseCode4)
                .HasMaxLength(200);

            this.Property(t => t.CauseCode5)
                .HasMaxLength(200);

            this.Property(t => t.CauseCode6)
                .HasMaxLength(200);

            this.Property(t => t.CauseCode7)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("DimCauseCode");
            this.Property(t => t.CauseCodeKey).HasColumnName("CauseCodeKey");
            this.Property(t => t.CauseCode1).HasColumnName("CauseCode1");
            this.Property(t => t.CauseCode2).HasColumnName("CauseCode2");
            this.Property(t => t.CauseCode3).HasColumnName("CauseCode3");
            this.Property(t => t.CauseCode4).HasColumnName("CauseCode4");
            this.Property(t => t.CauseCode5).HasColumnName("CauseCode5");
            this.Property(t => t.CauseCode6).HasColumnName("CauseCode6");
            this.Property(t => t.CauseCode7).HasColumnName("CauseCode7");
        }
    }
}
