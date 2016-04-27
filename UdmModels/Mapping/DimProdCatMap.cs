using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CommonDataService.Models.Mapping
{
    public class DimProdCatMap : EntityTypeConfiguration<DimProdCat>
    {
        public DimProdCatMap()
        {
            // Primary Key
            this.HasKey(t => t.ProdCatKey);

            // Properties
            this.Property(t => t.ProdCat1)
                .HasMaxLength(100);

            this.Property(t => t.ProdCat2)
                .HasMaxLength(200);

            this.Property(t => t.ProdCat3)
                .HasMaxLength(50);

            this.Property(t => t.ProdCat4)
                .HasMaxLength(50);

            this.Property(t => t.ProdCat5)
                .HasMaxLength(50);

            this.Property(t => t.ProdCat6)
                .HasMaxLength(50);

            this.Property(t => t.ProdCat7)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DimProdCat");
            this.Property(t => t.ProdCatKey).HasColumnName("ProdCatKey");
            this.Property(t => t.ProdCat1).HasColumnName("ProdCat1");
            this.Property(t => t.ProdCat2).HasColumnName("ProdCat2");
            this.Property(t => t.ProdCat3).HasColumnName("ProdCat3");
            this.Property(t => t.ProdCat4).HasColumnName("ProdCat4");
            this.Property(t => t.ProdCat5).HasColumnName("ProdCat5");
            this.Property(t => t.ProdCat6).HasColumnName("ProdCat6");
            this.Property(t => t.ProdCat7).HasColumnName("ProdCat7");
        }
    }
}
