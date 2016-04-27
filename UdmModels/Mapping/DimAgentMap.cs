using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CommonDataService.Models.Mapping
{
    public class DimAgentMap : EntityTypeConfiguration<DimAgent>
    {
        public DimAgentMap()
        {
            // Primary Key
            this.HasKey(t => t.AgentKey);

            // Properties
            this.Property(t => t.Agent1)
                .HasMaxLength(100);

            this.Property(t => t.Agent2)
                .HasMaxLength(200);

            this.Property(t => t.Agent3)
                .HasMaxLength(50);

            this.Property(t => t.Agent4)
                .HasMaxLength(50);

            this.Property(t => t.Agent5)
                .HasMaxLength(50);

            this.Property(t => t.Agent6)
                .HasMaxLength(50);

            this.Property(t => t.Agent7)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DimAgent");
            this.Property(t => t.AgentKey).HasColumnName("AgentKey");
            this.Property(t => t.Agent1).HasColumnName("Agent1");
            this.Property(t => t.Agent2).HasColumnName("Agent2");
            this.Property(t => t.Agent3).HasColumnName("Agent3");
            this.Property(t => t.Agent4).HasColumnName("Agent4");
            this.Property(t => t.Agent5).HasColumnName("Agent5");
            this.Property(t => t.Agent6).HasColumnName("Agent6");
            this.Property(t => t.Agent7).HasColumnName("Agent7");
        }
    }
}
