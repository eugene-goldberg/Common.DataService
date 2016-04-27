using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CommonDataService.Models.Mapping
{
    public class DimIndustryMap : EntityTypeConfiguration<DimIndustry>
    {
        public DimIndustryMap()
        {
            // Primary Key
            this.HasKey(t => t.IndustryKey);

            // Properties
            this.Property(t => t.Industry1)
                .HasMaxLength(100);

            this.Property(t => t.Industry2)
                .HasMaxLength(200);

            this.Property(t => t.Industry3)
                .HasMaxLength(50);

            this.Property(t => t.Industry4)
                .HasMaxLength(50);

            this.Property(t => t.Industry5)
                .HasMaxLength(50);

            this.Property(t => t.Industry6)
                .HasMaxLength(50);

            this.Property(t => t.Industry7)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DimIndustry");
            this.Property(t => t.IndustryKey).HasColumnName("IndustryKey");
            this.Property(t => t.Industry1).HasColumnName("Industry1");
            this.Property(t => t.Industry2).HasColumnName("Industry2");
            this.Property(t => t.Industry3).HasColumnName("Industry3");
            this.Property(t => t.Industry4).HasColumnName("Industry4");
            this.Property(t => t.Industry5).HasColumnName("Industry5");
            this.Property(t => t.Industry6).HasColumnName("Industry6");
            this.Property(t => t.Industry7).HasColumnName("Industry7");
        }
    }
}
