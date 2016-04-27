using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CommonDataService.Models.Mapping
{
    public class DimPriorityMap : EntityTypeConfiguration<DimPriority>
    {
        public DimPriorityMap()
        {
            // Primary Key
            this.HasKey(t => t.PriorityKey);

            // Properties
            this.Property(t => t.Priority1)
                .HasMaxLength(50);

            this.Property(t => t.Priority2)
                .HasMaxLength(50);

            this.Property(t => t.Priority3)
                .HasMaxLength(50);

            this.Property(t => t.Priority4)
                .HasMaxLength(50);

            this.Property(t => t.Priority5)
                .HasMaxLength(50);

            this.Property(t => t.Priority6)
                .HasMaxLength(50);

            this.Property(t => t.Priority7)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DimPriority");
            this.Property(t => t.PriorityKey).HasColumnName("PriorityKey");
            this.Property(t => t.Priority1).HasColumnName("Priority1");
            this.Property(t => t.Priority2).HasColumnName("Priority2");
            this.Property(t => t.Priority3).HasColumnName("Priority3");
            this.Property(t => t.Priority4).HasColumnName("Priority4");
            this.Property(t => t.Priority5).HasColumnName("Priority5");
            this.Property(t => t.Priority6).HasColumnName("Priority6");
            this.Property(t => t.Priority7).HasColumnName("Priority7");
        }
    }
}
