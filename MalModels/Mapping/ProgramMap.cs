using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CommonDataService.Models.Mapping
{
    public class ProgramMap : EntityTypeConfiguration<Program>
    {
        public ProgramMap()
        {
            // Primary Key
            this.HasKey(t => t.ProgramID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Programs");
            this.Property(t => t.ProgramID).HasColumnName("ProgramID");
            this.Property(t => t.ProgramName).HasColumnName("ProgramName");
            this.Property(t => t.AccountProgram_AccountProgramID).HasColumnName("AccountProgram_AccountProgramID");

            // Relationships
            this.HasOptional(t => t.AccountProgram)
                .WithMany(t => t.Programs)
                .HasForeignKey(d => d.AccountProgram_AccountProgramID);

        }
    }
}
