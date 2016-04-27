using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CommonDataService.Models.Mapping
{
    public class CountryMap : EntityTypeConfiguration<Country>
    {
        public CountryMap()
        {
            // Primary Key
            this.HasKey(t => t.CountryID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Countries");
            this.Property(t => t.CountryID).HasColumnName("CountryID");
            this.Property(t => t.CountryName).HasColumnName("CountryName");
        }
    }
}
