using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CommonDataService.Models.Mapping
{
    public class ServiceMap : EntityTypeConfiguration<Service>
    {
        public ServiceMap()
        {
            // Primary Key
            this.HasKey(t => t.ServiceID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Services");
            this.Property(t => t.ServiceID).HasColumnName("ServiceID");
            this.Property(t => t.ServiceName).HasColumnName("ServiceName");
        }
    }
}
