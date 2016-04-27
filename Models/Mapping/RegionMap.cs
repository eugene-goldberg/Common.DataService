using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CommonDataService.Models.Mapping
{
    public class RegionMap : EntityTypeConfiguration<Region>
    {
        public RegionMap()
        {
            // Primary Key
            this.HasKey(t => t.RegionID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Regions");
            this.Property(t => t.RegionID).HasColumnName("RegionID");
            this.Property(t => t.RegionName).HasColumnName("RegionName");
        }
    }
}
