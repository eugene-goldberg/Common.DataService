using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CommonDataService.Models.Mapping
{
    public class ToolMap : EntityTypeConfiguration<Tool>
    {
        public ToolMap()
        {
            // Primary Key
            this.HasKey(t => t.ToolID);

            // Properties
            this.Property(t => t.ToolID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Tools");
            this.Property(t => t.ToolID).HasColumnName("ToolID");
            this.Property(t => t.ToolCategoryName).HasColumnName("ToolCategoryName");
            this.Property(t => t.ToolInstanceName).HasColumnName("ToolInstanceName");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.ToolRegisterID).HasColumnName("ToolRegisterID");
        }
    }
}
