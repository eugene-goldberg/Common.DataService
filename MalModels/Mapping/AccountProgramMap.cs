using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CommonDataService.Models.Mapping
{
    public class AccountProgramMap : EntityTypeConfiguration<AccountProgram>
    {
        public AccountProgramMap()
        {
            // Primary Key
            this.HasKey(t => t.AccountProgramID);

            // Properties
            // Table & Column Mappings
            this.ToTable("AccountPrograms");
            this.Property(t => t.AccountProgramID).HasColumnName("AccountProgramID");
            this.Property(t => t.ProgramPhase).HasColumnName("ProgramPhase");
            this.Property(t => t.AccountID).HasColumnName("AccountID");
            this.Property(t => t.ProgramGoLiveDate).HasColumnName("ProgramGoLiveDate");
            this.Property(t => t.ProgramStabilizationDate).HasColumnName("ProgramStabilizationDate");
        }
    }
}
