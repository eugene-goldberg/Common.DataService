using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CommonDataService.Models.Mapping
{
    public class DimSourceOdMap : EntityTypeConfiguration<DimSourceOd>
    {
        public DimSourceOdMap()
        {
            // Primary Key
            this.HasKey(t => t.SourceOdsKey);

            // Properties
            this.Property(t => t.SourceOds1)
                .HasMaxLength(100);

            this.Property(t => t.SourceOds2)
                .HasMaxLength(200);

            this.Property(t => t.SourceOds3)
                .HasMaxLength(50);

            this.Property(t => t.SourceOds4)
                .HasMaxLength(50);

            this.Property(t => t.SourceOds5)
                .HasMaxLength(50);

            this.Property(t => t.SourceOds6)
                .HasMaxLength(50);

            this.Property(t => t.SourceOds7)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DimSourceOds");
            this.Property(t => t.SourceOdsKey).HasColumnName("SourceOdsKey");
            this.Property(t => t.SourceOds1).HasColumnName("SourceOds1");
            this.Property(t => t.SourceOds2).HasColumnName("SourceOds2");
            this.Property(t => t.SourceOds3).HasColumnName("SourceOds3");
            this.Property(t => t.SourceOds4).HasColumnName("SourceOds4");
            this.Property(t => t.SourceOds5).HasColumnName("SourceOds5");
            this.Property(t => t.SourceOds6).HasColumnName("SourceOds6");
            this.Property(t => t.SourceOds7).HasColumnName("SourceOds7");
        }
    }
}
