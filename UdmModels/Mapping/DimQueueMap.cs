using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CommonDataService.Models.Mapping
{
    public class DimQueueMap : EntityTypeConfiguration<DimQueue>
    {
        public DimQueueMap()
        {
            // Primary Key
            this.HasKey(t => t.QueueKey);

            // Properties
            this.Property(t => t.Queue1)
                .HasMaxLength(200);

            this.Property(t => t.Queue2)
                .HasMaxLength(200);

            this.Property(t => t.Queue3)
                .HasMaxLength(200);

            this.Property(t => t.Queue4)
                .HasMaxLength(200);

            this.Property(t => t.Queue5)
                .HasMaxLength(200);

            this.Property(t => t.Queue6)
                .HasMaxLength(200);

            this.Property(t => t.Queue7)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("DimQueue");
            this.Property(t => t.QueueKey).HasColumnName("QueueKey");
            this.Property(t => t.Queue1).HasColumnName("Queue1");
            this.Property(t => t.Queue2).HasColumnName("Queue2");
            this.Property(t => t.Queue3).HasColumnName("Queue3");
            this.Property(t => t.Queue4).HasColumnName("Queue4");
            this.Property(t => t.Queue5).HasColumnName("Queue5");
            this.Property(t => t.Queue6).HasColumnName("Queue6");
            this.Property(t => t.Queue7).HasColumnName("Queue7");
        }
    }
}
