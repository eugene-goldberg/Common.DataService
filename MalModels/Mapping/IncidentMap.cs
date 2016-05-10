using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CommonDataService.Models.Mapping
{
    public class IncidentMap : EntityTypeConfiguration<Incident>
    {
        public IncidentMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Incidents");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.INCIDENTNUMBER).HasColumnName("INCIDENTNUMBER");
            this.Property(t => t.SUBMITTER).HasColumnName("SUBMITTER");
            this.Property(t => t.REPORTEDDATE).HasColumnName("REPORTEDDATE");
            this.Property(t => t.LASTRESOLVEDDATE).HasColumnName("LASTRESOLVEDDATE");
            this.Property(t => t.OWNERGROUP).HasColumnName("OWNERGROUP");
            this.Property(t => t.COMPANY).HasColumnName("COMPANY");
            this.Property(t => t.CATEGORIZATIONTIER1).HasColumnName("CATEGORIZATIONTIER1");
            this.Property(t => t.VATEGORIZATIONTIER2).HasColumnName("VATEGORIZATIONTIER2");
            this.Property(t => t.CATEGORIZATIONTIER3).HasColumnName("CATEGORIZATIONTIER3");
            this.Property(t => t.RESOLUTIONCATEGORY).HasColumnName("RESOLUTIONCATEGORY");
            this.Property(t => t.RESOLUTIONCATEGORYTIER2).HasColumnName("RESOLUTIONCATEGORYTIER2");
            this.Property(t => t.RESOLUTIONCATEGORYTIER3).HasColumnName("RESOLUTIONCATEGORYTIER3");
            this.Property(t => t.REPORTEDSOURCE).HasColumnName("REPORTEDSOURCE");
            this.Property(t => t.DESCRIPTION).HasColumnName("DESCRIPTION");
        }
    }
}
