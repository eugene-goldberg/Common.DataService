using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CommonDataService.Models.Mapping
{
    public class OfferingMap : EntityTypeConfiguration<Offering>
    {
        public OfferingMap()
        {
            // Primary Key
            this.HasKey(t => t.OfferingID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Offerings");
            this.Property(t => t.OfferingID).HasColumnName("OfferingID");
            this.Property(t => t.OfferingName).HasColumnName("OfferingName");
        }
    }
}
