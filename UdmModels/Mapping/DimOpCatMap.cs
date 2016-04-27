using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CommonDataService.Models.Mapping
{
    public class DimOpCatMap : EntityTypeConfiguration<DimOpCat>
    {
        public DimOpCatMap()
        {
            // Primary Key
            this.HasKey(t => t.OpCatKey);

            // Properties
            this.Property(t => t.OpCat1)
                .HasMaxLength(100);

            this.Property(t => t.OpCat2)
                .HasMaxLength(200);

            this.Property(t => t.OpCat3)
                .HasMaxLength(50);

            this.Property(t => t.OpCat4)
                .HasMaxLength(50);

            this.Property(t => t.OpCat5)
                .HasMaxLength(50);

            this.Property(t => t.OpCat6)
                .HasMaxLength(50);

            this.Property(t => t.OpCat7)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DimOpCat");
            this.Property(t => t.OpCatKey).HasColumnName("OpCatKey");
            this.Property(t => t.OpCat1).HasColumnName("OpCat1");
            this.Property(t => t.OpCat2).HasColumnName("OpCat2");
            this.Property(t => t.OpCat3).HasColumnName("OpCat3");
            this.Property(t => t.OpCat4).HasColumnName("OpCat4");
            this.Property(t => t.OpCat5).HasColumnName("OpCat5");
            this.Property(t => t.OpCat6).HasColumnName("OpCat6");
            this.Property(t => t.OpCat7).HasColumnName("OpCat7");
        }
    }
}
