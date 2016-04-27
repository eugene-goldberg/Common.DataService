using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CommonDataService.Models.Mapping
{
    public class DimDtlIncidentWeekMap : EntityTypeConfiguration<DimDtlIncidentWeek>
    {
        public DimDtlIncidentWeekMap()
        {
            // Primary Key
            this.HasKey(t => new { t.AccountCode, t.SourceOds, t.Company, t.IncidentIdentifier, t.AccountKey, t.AccountRegionIndustryKey, t.AccountRegionKey, t.AgentKey, t.CauseCodeKey, t.ContactSourceKey, t.DeliveryRegionKey, t.IndustryKey, t.OpCatKey, t.PriorityKey, t.ProdCatKey, t.QueueKey, t.ResCatKey, t.ServiceDeskKey, t.SourceOdsKey, t.StatusKey, t.SubjectTypeKey, t.TimeIntervalKey, t.VipKey });

            // Properties
            this.Property(t => t.AccountCode)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.SourceOds)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CssSystem)
                .HasMaxLength(50);

            this.Property(t => t.Company)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.IncidentIdentifier)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.AccountRegion)
                .HasMaxLength(50);

            this.Property(t => t.AssignedGroup)
                .HasMaxLength(150);

            this.Property(t => t.Assignee)
                .HasMaxLength(200);

            this.Property(t => t.CauseCodeDesc)
                .HasMaxLength(100);

            this.Property(t => t.Customer)
                .HasMaxLength(200);

            this.Property(t => t.DeliveryRegion)
                .HasMaxLength(50);

            this.Property(t => t.IncidentSummary)
                .HasMaxLength(400);

            this.Property(t => t.InternetEmail)
                .HasMaxLength(255);

            this.Property(t => t.L1TtrMins)
                .HasMaxLength(50);

            this.Property(t => t.L2L3AckTimeHours)
                .HasMaxLength(50);

            this.Property(t => t.OperationalCategorization)
                .HasMaxLength(300);

            this.Property(t => t.Pod)
                .HasMaxLength(50);

            this.Property(t => t.ProductCategorization)
                .HasMaxLength(300);

            this.Property(t => t.PwdNotCatAsPwd)
                .HasMaxLength(3);

            this.Property(t => t.ReportedSource)
                .HasMaxLength(50);

            this.Property(t => t.Resolution)
                .HasMaxLength(400);

            this.Property(t => t.ResolutionCategorization)
                .HasMaxLength(300);

            this.Property(t => t.ResolverGroupLevel)
                .HasMaxLength(50);

            this.Property(t => t.ServiceDesk)
                .HasMaxLength(75);

            this.Property(t => t.Status)
                .HasMaxLength(255);

            this.Property(t => t.StatusGroup)
                .HasMaxLength(25);

            this.Property(t => t.StatusReason)
                .HasMaxLength(60);

            this.Property(t => t.Submitter)
                .HasMaxLength(200);

            this.Property(t => t.TimeToResolveHours)
                .HasMaxLength(50);

            this.Property(t => t.TimeToResolveOver2Hours)
                .HasMaxLength(3);

            this.Property(t => t.Vip)
                .HasMaxLength(10);

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

            this.Property(t => t.OpCatKey)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PriorityKey)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProdCatKey)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.QueueKey)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ResCatKey)
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
            this.ToTable("DimDtlIncidentWeek");
            this.Property(t => t.AccountCode).HasColumnName("AccountCode");
            this.Property(t => t.SourceOds).HasColumnName("SourceOds");
            this.Property(t => t.CssSystem).HasColumnName("CssSystem");
            this.Property(t => t.Company).HasColumnName("Company");
            this.Property(t => t.IncidentIdentifier).HasColumnName("IncidentIdentifier");
            this.Property(t => t.ClosedDate).HasColumnName("ClosedDate");
            this.Property(t => t.LastAcknowledgedDate).HasColumnName("LastAcknowledgedDate");
            this.Property(t => t.LastResolvedDate).HasColumnName("LastResolvedDate");
            this.Property(t => t.PeriodDate).HasColumnName("PeriodDate");
            this.Property(t => t.ReportedDate).HasColumnName("ReportedDate");
            this.Property(t => t.ReportedWeek).HasColumnName("ReportedWeek");
            this.Property(t => t.SubmitDate).HasColumnName("SubmitDate");
            this.Property(t => t.AccountRegion).HasColumnName("AccountRegion");
            this.Property(t => t.Active1Inact0).HasColumnName("Active1Inact0");
            this.Property(t => t.AssignedGroup).HasColumnName("AssignedGroup");
            this.Property(t => t.Assignee).HasColumnName("Assignee");
            this.Property(t => t.CauseCodeDesc).HasColumnName("CauseCodeDesc");
            this.Property(t => t.CkmPwdCount).HasColumnName("CkmPwdCount");
            this.Property(t => t.CscPwdCount).HasColumnName("CscPwdCount");
            this.Property(t => t.CscPwdCountNew).HasColumnName("CscPwdCountNew");
            this.Property(t => t.Customer).HasColumnName("Customer");
            this.Property(t => t.DeliveryRegion).HasColumnName("DeliveryRegion");
            this.Property(t => t.Fcr).HasColumnName("Fcr");
            this.Property(t => t.GrossCloseHours).HasColumnName("GrossCloseHours");
            this.Property(t => t.GrossResolutionHours).HasColumnName("GrossResolutionHours");
            this.Property(t => t.HpdCount).HasColumnName("HpdCount");
            this.Property(t => t.IncidentSummary).HasColumnName("IncidentSummary");
            this.Property(t => t.InternetEmail).HasColumnName("InternetEmail");
            this.Property(t => t.L1TtrMins).HasColumnName("L1TtrMins");
            this.Property(t => t.L2L3AckTimeHours).HasColumnName("L2L3AckTimeHours");
            this.Property(t => t.OperationalCategorization).HasColumnName("OperationalCategorization");
            this.Property(t => t.Pod).HasColumnName("Pod");
            this.Property(t => t.Priority).HasColumnName("Priority");
            this.Property(t => t.ProductCategorization).HasColumnName("ProductCategorization");
            this.Property(t => t.PwdNotCatAsPwd).HasColumnName("PwdNotCatAsPwd");
            this.Property(t => t.ReportedSource).HasColumnName("ReportedSource");
            this.Property(t => t.Resolution).HasColumnName("Resolution");
            this.Property(t => t.ResolutionCategorization).HasColumnName("ResolutionCategorization");
            this.Property(t => t.ResolverGroupLevel).HasColumnName("ResolverGroupLevel");
            this.Property(t => t.ServiceDesk).HasColumnName("ServiceDesk");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.StatusGroup).HasColumnName("StatusGroup");
            this.Property(t => t.StatusReason).HasColumnName("StatusReason");
            this.Property(t => t.Submitter).HasColumnName("Submitter");
            this.Property(t => t.SvcDeskOpened).HasColumnName("SvcDeskOpened");
            this.Property(t => t.TimeToAcknowledgeSecs).HasColumnName("TimeToAcknowledgeSecs");
            this.Property(t => t.TimeToResolveSecs).HasColumnName("TimeToResolveSecs");
            this.Property(t => t.TimeToResolveHours).HasColumnName("TimeToResolveHours");
            this.Property(t => t.TimeToResolveOver2Hours).HasColumnName("TimeToResolveOver2Hours");
            this.Property(t => t.Vip).HasColumnName("Vip");
            this.Property(t => t.AccountKey).HasColumnName("AccountKey");
            this.Property(t => t.AccountRegionIndustryKey).HasColumnName("AccountRegionIndustryKey");
            this.Property(t => t.AccountRegionKey).HasColumnName("AccountRegionKey");
            this.Property(t => t.AgentKey).HasColumnName("AgentKey");
            this.Property(t => t.CauseCodeKey).HasColumnName("CauseCodeKey");
            this.Property(t => t.ContactSourceKey).HasColumnName("ContactSourceKey");
            this.Property(t => t.DeliveryRegionKey).HasColumnName("DeliveryRegionKey");
            this.Property(t => t.IndustryKey).HasColumnName("IndustryKey");
            this.Property(t => t.OpCatKey).HasColumnName("OpCatKey");
            this.Property(t => t.PriorityKey).HasColumnName("PriorityKey");
            this.Property(t => t.ProdCatKey).HasColumnName("ProdCatKey");
            this.Property(t => t.QueueKey).HasColumnName("QueueKey");
            this.Property(t => t.ResCatKey).HasColumnName("ResCatKey");
            this.Property(t => t.ServiceDeskKey).HasColumnName("ServiceDeskKey");
            this.Property(t => t.SourceOdsKey).HasColumnName("SourceOdsKey");
            this.Property(t => t.StatusKey).HasColumnName("StatusKey");
            this.Property(t => t.SubjectTypeKey).HasColumnName("SubjectTypeKey");
            this.Property(t => t.TimeIntervalKey).HasColumnName("TimeIntervalKey");
            this.Property(t => t.VipKey).HasColumnName("VipKey");
        }
    }
}
