using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CommonDataService.Models.Mapping
{
    public class DimResCatMap : EntityTypeConfiguration<DimResCat>
    {
        public DimResCatMap()
        {
            // Primary Key
            this.HasKey(t => t.ResCatKey);

            // Properties
            this.Property(t => t.ResCat1)
                .HasMaxLength(100);

            this.Property(t => t.ResCat2)
                .HasMaxLength(200);

            this.Property(t => t.ResCat3)
                .HasMaxLength(50);

            this.Property(t => t.ResCat4)
                .HasMaxLength(50);

            this.Property(t => t.ResCat5)
                .HasMaxLength(50);

            this.Property(t => t.ResCat6)
                .HasMaxLength(50);

            this.Property(t => t.ResCat7)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DimResCat");
            this.Property(t => t.ResCatKey).HasColumnName("ResCatKey");
            this.Property(t => t.ResCat1).HasColumnName("ResCat1");
            this.Property(t => t.ResCat2).HasColumnName("ResCat2");
            this.Property(t => t.ResCat3).HasColumnName("ResCat3");
            this.Property(t => t.ResCat4).HasColumnName("ResCat4");
            this.Property(t => t.ResCat5).HasColumnName("ResCat5");
            this.Property(t => t.ResCat6).HasColumnName("ResCat6");
            this.Property(t => t.ResCat7).HasColumnName("ResCat7");
        }
    }
}
