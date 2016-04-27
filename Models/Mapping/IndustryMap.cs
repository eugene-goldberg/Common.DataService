using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CommonDataService.Models.Mapping
{
    public class IndustryMap : EntityTypeConfiguration<Industry>
    {
        public IndustryMap()
        {
            // Primary Key
            this.HasKey(t => t.IndustryID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Industries");
            this.Property(t => t.IndustryID).HasColumnName("IndustryID");
            this.Property(t => t.IndustryName).HasColumnName("IndustryName");
        }
    }
}
