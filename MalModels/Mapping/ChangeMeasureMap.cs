using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CommonDataService.Models.Mapping
{
    public class ChangeMeasureMap : EntityTypeConfiguration<ChangeMeasure>
    {
        public ChangeMeasureMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("ChangeMeasures");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.AccountID).HasColumnName("AccountID");
            this.Property(t => t.MeasureName).HasColumnName("MeasureName");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.Justification).HasColumnName("Justification");
            this.Property(t => t.Account_ID).HasColumnName("Account_ID");

            // Relationships
            this.HasOptional(t => t.Account)
                .WithMany(t => t.ChangeMeasures)
                .HasForeignKey(d => d.Account_ID);

        }
    }
}
