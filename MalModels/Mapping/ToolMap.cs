using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CommonDataService.Models.Mapping
{
    public class ToolMap : EntityTypeConfiguration<Tool>
    {
        public ToolMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Tools");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ToolID).HasColumnName("ToolID");
            this.Property(t => t.ToolCategoryName).HasColumnName("ToolCategoryName");
            this.Property(t => t.ToolInstanceName).HasColumnName("ToolInstanceName");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
