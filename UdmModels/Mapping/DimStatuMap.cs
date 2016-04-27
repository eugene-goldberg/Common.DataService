using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CommonDataService.Models.Mapping
{
    public class DimStatuMap : EntityTypeConfiguration<DimStatu>
    {
        public DimStatuMap()
        {
            // Primary Key
            this.HasKey(t => t.StatusKey);

            // Properties
            this.Property(t => t.Status1)
                .HasMaxLength(100);

            this.Property(t => t.Status2)
                .HasMaxLength(100);

            this.Property(t => t.Status3)
                .HasMaxLength(100);

            this.Property(t => t.Status4)
                .HasMaxLength(100);

            this.Property(t => t.Status5)
                .HasMaxLength(100);

            this.Property(t => t.Status6)
                .HasMaxLength(100);

            this.Property(t => t.Status7)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("DimStatus");
            this.Property(t => t.StatusKey).HasColumnName("StatusKey");
            this.Property(t => t.Status1).HasColumnName("Status1");
            this.Property(t => t.Status2).HasColumnName("Status2");
            this.Property(t => t.Status3).HasColumnName("Status3");
            this.Property(t => t.Status4).HasColumnName("Status4");
            this.Property(t => t.Status5).HasColumnName("Status5");
            this.Property(t => t.Status6).HasColumnName("Status6");
            this.Property(t => t.Status7).HasColumnName("Status7");
        }
    }
}
