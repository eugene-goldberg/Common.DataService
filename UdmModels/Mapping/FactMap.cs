using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CommonDataService.Models.Mapping
{
    public class FactMap : EntityTypeConfiguration<Fact>
    {
        public FactMap()
        {
            // Primary Key
            this.HasKey(t => new { t.AccountKey, t.AccountRegionIndustryKey, t.AccountRegionKey, t.AgentKey, t.CauseCodeKey, t.ContactSourceKey, t.DeliveryRegionKey, t.IndustryKey, t.MetricKey, t.PeriodKey, t.PriorityKey, t.QueueKey, t.ServiceDeskKey, t.SourceOdsKey, t.StatusKey, t.SubjectTypeKey, t.TimeIntervalKey, t.VipKey });

            // Properties
            this.Property(t => t.AccountKey)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AccountRegionIndustryKey)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AccountRegionKey)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AgentKey)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CauseCodeKey)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ContactSourceKey)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DeliveryRegionKey)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IndustryKey)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MetricKey)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PeriodKey)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PriorityKey)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.QueueKey)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ServiceDeskKey)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SourceOdsKey)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.StatusKey)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SubjectTypeKey)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TimeIntervalKey)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.VipKey)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Fact");
            this.Property(t => t.AccountKey).HasColumnName("AccountKey");
            this.Property(t => t.AccountRegionIndustryKey).HasColumnName("AccountRegionIndustryKey");
            this.Property(t => t.AccountRegionKey).HasColumnName("AccountRegionKey");
            this.Property(t => t.AgentKey).HasColumnName("AgentKey");
            this.Property(t => t.CauseCodeKey).HasColumnName("CauseCodeKey");
            this.Property(t => t.ContactSourceKey).HasColumnName("ContactSourceKey");
            this.Property(t => t.DeliveryRegionKey).HasColumnName("DeliveryRegionKey");
            this.Property(t => t.IndustryKey).HasColumnName("IndustryKey");
            this.Property(t => t.MetricKey).HasColumnName("MetricKey");
            this.Property(t => t.PeriodKey).HasColumnName("PeriodKey");
            this.Property(t => t.PriorityKey).HasColumnName("PriorityKey");
            this.Property(t => t.QueueKey).HasColumnName("QueueKey");
            this.Property(t => t.ServiceDeskKey).HasColumnName("ServiceDeskKey");
            this.Property(t => t.SourceOdsKey).HasColumnName("SourceOdsKey");
            this.Property(t => t.StatusKey).HasColumnName("StatusKey");
            this.Property(t => t.SubjectTypeKey).HasColumnName("SubjectTypeKey");
            this.Property(t => t.TimeIntervalKey).HasColumnName("TimeIntervalKey");
            this.Property(t => t.VipKey).HasColumnName("VipKey");
            this.Property(t => t.Actual1Sum).HasColumnName("Actual1Sum");
            this.Property(t => t.Actual2Sum).HasColumnName("Actual2Sum");
            this.Property(t => t.Actual3Sum).HasColumnName("Actual3Sum");
        }
    }
}
