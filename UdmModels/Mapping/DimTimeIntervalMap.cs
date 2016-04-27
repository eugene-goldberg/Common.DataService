using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CommonDataService.Models.Mapping
{
    public class DimTimeIntervalMap : EntityTypeConfiguration<DimTimeInterval>
    {
        public DimTimeIntervalMap()
        {
            // Primary Key
            this.HasKey(t => t.TimeIntervalKey);

            // Properties
            this.Property(t => t.TimeInterval1)
                .HasMaxLength(100);

            this.Property(t => t.TimeInterval2)
                .HasMaxLength(200);

            this.Property(t => t.TimeInterval3)
                .HasMaxLength(50);

            this.Property(t => t.TimeInterval4)
                .HasMaxLength(50);

            this.Property(t => t.TimeInterval5)
                .HasMaxLength(50);

            this.Property(t => t.TimeInterval6)
                .HasMaxLength(50);

            this.Property(t => t.TimeInterval7)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DimTimeInterval");
            this.Property(t => t.TimeIntervalKey).HasColumnName("TimeIntervalKey");
            this.Property(t => t.TimeInterval1).HasColumnName("TimeInterval1");
            this.Property(t => t.TimeInterval2).HasColumnName("TimeInterval2");
            this.Property(t => t.TimeInterval3).HasColumnName("TimeInterval3");
            this.Property(t => t.TimeInterval4).HasColumnName("TimeInterval4");
            this.Property(t => t.TimeInterval5).HasColumnName("TimeInterval5");
            this.Property(t => t.TimeInterval6).HasColumnName("TimeInterval6");
            this.Property(t => t.TimeInterval7).HasColumnName("TimeInterval7");
        }
    }
}
