using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CommonDataService.Models.Mapping
{
    public class DimVipMap : EntityTypeConfiguration<DimVip>
    {
        public DimVipMap()
        {
            // Primary Key
            this.HasKey(t => t.VipKey);

            // Properties
            this.Property(t => t.Vip1)
                .HasMaxLength(50);

            this.Property(t => t.Vip2)
                .HasMaxLength(50);

            this.Property(t => t.Vip3)
                .HasMaxLength(50);

            this.Property(t => t.Vip4)
                .HasMaxLength(50);

            this.Property(t => t.Vip5)
                .HasMaxLength(50);

            this.Property(t => t.Vip6)
                .HasMaxLength(50);

            this.Property(t => t.Vip7)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DimVip");
            this.Property(t => t.VipKey).HasColumnName("VipKey");
            this.Property(t => t.Vip1).HasColumnName("Vip1");
            this.Property(t => t.Vip2).HasColumnName("Vip2");
            this.Property(t => t.Vip3).HasColumnName("Vip3");
            this.Property(t => t.Vip4).HasColumnName("Vip4");
            this.Property(t => t.Vip5).HasColumnName("Vip5");
            this.Property(t => t.Vip6).HasColumnName("Vip6");
            this.Property(t => t.Vip7).HasColumnName("Vip7");
        }
    }
}
