using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CommonDataService.Models.Mapping
{
    public class DimMetricMap : EntityTypeConfiguration<DimMetric>
    {
        public DimMetricMap()
        {
            // Primary Key
            this.HasKey(t => t.MetricKey);

            // Properties
            this.Property(t => t.Metric1)
                .HasMaxLength(50);

            this.Property(t => t.Metric2)
                .HasMaxLength(50);

            this.Property(t => t.Metric3)
                .HasMaxLength(50);

            this.Property(t => t.Metric4)
                .HasMaxLength(50);

            this.Property(t => t.Metric5)
                .HasMaxLength(50);

            this.Property(t => t.Metric6)
                .HasMaxLength(50);

            this.Property(t => t.Metric7)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DimMetric");
            this.Property(t => t.MetricKey).HasColumnName("MetricKey");
            this.Property(t => t.Metric1).HasColumnName("Metric1");
            this.Property(t => t.Metric2).HasColumnName("Metric2");
            this.Property(t => t.Metric3).HasColumnName("Metric3");
            this.Property(t => t.Metric4).HasColumnName("Metric4");
            this.Property(t => t.Metric5).HasColumnName("Metric5");
            this.Property(t => t.Metric6).HasColumnName("Metric6");
            this.Property(t => t.Metric7).HasColumnName("Metric7");
        }
    }
}
