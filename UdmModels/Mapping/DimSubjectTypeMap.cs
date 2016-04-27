using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CommonDataService.Models.Mapping
{
    public class DimSubjectTypeMap : EntityTypeConfiguration<DimSubjectType>
    {
        public DimSubjectTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.SubjectTypeKey);

            // Properties
            this.Property(t => t.SubjectType1)
                .HasMaxLength(50);

            this.Property(t => t.SubjectType2)
                .HasMaxLength(50);

            this.Property(t => t.SubjectType3)
                .HasMaxLength(50);

            this.Property(t => t.SubjectType4)
                .HasMaxLength(50);

            this.Property(t => t.SubjectType5)
                .HasMaxLength(50);

            this.Property(t => t.SubjectType6)
                .HasMaxLength(50);

            this.Property(t => t.SubjectType7)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DimSubjectType");
            this.Property(t => t.SubjectTypeKey).HasColumnName("SubjectTypeKey");
            this.Property(t => t.SubjectType1).HasColumnName("SubjectType1");
            this.Property(t => t.SubjectType2).HasColumnName("SubjectType2");
            this.Property(t => t.SubjectType3).HasColumnName("SubjectType3");
            this.Property(t => t.SubjectType4).HasColumnName("SubjectType4");
            this.Property(t => t.SubjectType5).HasColumnName("SubjectType5");
            this.Property(t => t.SubjectType6).HasColumnName("SubjectType6");
            this.Property(t => t.SubjectType7).HasColumnName("SubjectType7");
        }
    }
}
