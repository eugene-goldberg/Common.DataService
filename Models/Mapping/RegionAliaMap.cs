using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CommonDataService.Models.Mapping
{
    public class RegionAliaMap : EntityTypeConfiguration<RegionAlia>
    {
        public RegionAliaMap()
        {
            // Primary Key
            this.HasKey(t => t.RegionAliasID);

            // Properties
            // Table & Column Mappings
            this.ToTable("RegionAlias");
            this.Property(t => t.RegionAliasID).HasColumnName("RegionAliasID");
            this.Property(t => t.RegionName).HasColumnName("RegionName");
            this.Property(t => t.SourceSystem).HasColumnName("SourceSystem");
            this.Property(t => t.SourceColumn).HasColumnName("SourceColumn");
            this.Property(t => t.SourceValue).HasColumnName("SourceValue");
        }
    }
}
