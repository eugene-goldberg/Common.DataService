using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CommonDataService.Models.Mapping
{
    public class DimRegionMap : EntityTypeConfiguration<DimRegion>
    {
        public DimRegionMap()
        {
            // Primary Key
            this.HasKey(t => t.RegionKey);

            // Properties
            this.Property(t => t.Region1)
                .HasMaxLength(50);

            this.Property(t => t.Region2)
                .HasMaxLength(50);

            this.Property(t => t.Region3)
                .HasMaxLength(50);

            this.Property(t => t.Region4)
                .HasMaxLength(50);

            this.Property(t => t.Region5)
                .HasMaxLength(50);

            this.Property(t => t.Region6)
                .HasMaxLength(50);

            this.Property(t => t.Region7)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DimRegion");
            this.Property(t => t.RegionKey).HasColumnName("RegionKey");
            this.Property(t => t.Region1).HasColumnName("Region1");
            this.Property(t => t.Region2).HasColumnName("Region2");
            this.Property(t => t.Region3).HasColumnName("Region3");
            this.Property(t => t.Region4).HasColumnName("Region4");
            this.Property(t => t.Region5).HasColumnName("Region5");
            this.Property(t => t.Region6).HasColumnName("Region6");
            this.Property(t => t.Region7).HasColumnName("Region7");
        }
    }
}
