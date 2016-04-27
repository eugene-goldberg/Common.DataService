using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CommonDataService.Models.Mapping
{
    public class DimRegionIndustryMap : EntityTypeConfiguration<DimRegionIndustry>
    {
        public DimRegionIndustryMap()
        {
            // Primary Key
            this.HasKey(t => t.RegionIndustryKey);

            // Properties
            this.Property(t => t.RegionIndustry1)
                .HasMaxLength(100);

            this.Property(t => t.RegionIndustry2)
                .HasMaxLength(200);

            this.Property(t => t.RegionIndustry3)
                .HasMaxLength(50);

            this.Property(t => t.RegionIndustry4)
                .HasMaxLength(50);

            this.Property(t => t.RegionIndustry5)
                .HasMaxLength(50);

            this.Property(t => t.RegionIndustry6)
                .HasMaxLength(50);

            this.Property(t => t.RegionIndustry7)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DimRegionIndustry");
            this.Property(t => t.RegionIndustryKey).HasColumnName("RegionIndustryKey");
            this.Property(t => t.RegionIndustry1).HasColumnName("RegionIndustry1");
            this.Property(t => t.RegionIndustry2).HasColumnName("RegionIndustry2");
            this.Property(t => t.RegionIndustry3).HasColumnName("RegionIndustry3");
            this.Property(t => t.RegionIndustry4).HasColumnName("RegionIndustry4");
            this.Property(t => t.RegionIndustry5).HasColumnName("RegionIndustry5");
            this.Property(t => t.RegionIndustry6).HasColumnName("RegionIndustry6");
            this.Property(t => t.RegionIndustry7).HasColumnName("RegionIndustry7");
        }
    }
}
