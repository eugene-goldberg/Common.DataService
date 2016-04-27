using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CommonDataService.Models.Mapping
{
    public class DimServiceDeskMap : EntityTypeConfiguration<DimServiceDesk>
    {
        public DimServiceDeskMap()
        {
            // Primary Key
            this.HasKey(t => t.ServiceDeskKey);

            // Properties
            this.Property(t => t.ServiceDesk1)
                .HasMaxLength(200);

            this.Property(t => t.ServiceDesk2)
                .HasMaxLength(200);

            this.Property(t => t.ServiceDesk3)
                .HasMaxLength(50);

            this.Property(t => t.ServiceDesk4)
                .HasMaxLength(50);

            this.Property(t => t.ServiceDesk5)
                .HasMaxLength(50);

            this.Property(t => t.ServiceDesk6)
                .HasMaxLength(50);

            this.Property(t => t.ServiceDesk7)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DimServiceDesk");
            this.Property(t => t.ServiceDeskKey).HasColumnName("ServiceDeskKey");
            this.Property(t => t.ServiceDesk1).HasColumnName("ServiceDesk1");
            this.Property(t => t.ServiceDesk2).HasColumnName("ServiceDesk2");
            this.Property(t => t.ServiceDesk3).HasColumnName("ServiceDesk3");
            this.Property(t => t.ServiceDesk4).HasColumnName("ServiceDesk4");
            this.Property(t => t.ServiceDesk5).HasColumnName("ServiceDesk5");
            this.Property(t => t.ServiceDesk6).HasColumnName("ServiceDesk6");
            this.Property(t => t.ServiceDesk7).HasColumnName("ServiceDesk7");
        }
    }
}
