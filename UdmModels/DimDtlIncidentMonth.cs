using System;
using System.Collections.Generic;

namespace CommonDataService.Models
{
    public partial class DimDtlIncidentMonth
    {
        public string AccountCode { get; set; }
        public string SourceOds { get; set; }
        public string CssSystem { get; set; }
        public string Company { get; set; }
        public string IncidentIdentifier { get; set; }
        public Nullable<System.DateTime> ClosedDate { get; set; }
        public Nullable<System.DateTime> LastAcknowledgedDate { get; set; }
        public Nullable<System.DateTime> LastResolvedDate { get; set; }
        public Nullable<System.DateTime> PeriodDate { get; set; }
        public Nullable<System.DateTime> ReportedDate { get; set; }
        public Nullable<System.DateTime> ReportedMonth { get; set; }
        public Nullable<System.DateTime> SubmitDate { get; set; }
        public string AccountRegion { get; set; }
        public Nullable<int> Active1Inact0 { get; set; }
        public string AssignedGroup { get; set; }
        public string Assignee { get; set; }
        public string CauseCodeDesc { get; set; }
        public Nullable<int> CkmPwdCount { get; set; }
        public Nullable<int> CscPwdCount { get; set; }
        public Nullable<int> CscPwdCountNew { get; set; }
        public string Customer { get; set; }
        public string DeliveryRegion { get; set; }
        public Nullable<int> Fcr { get; set; }
        public Nullable<int> GrossCloseHours { get; set; }
        public Nullable<int> GrossResolutionHours { get; set; }
        public Nullable<int> HpdCount { get; set; }
        public string IncidentSummary { get; set; }
        public string InternetEmail { get; set; }
        public string L1TtrMins { get; set; }
        public string L2L3AckTimeHours { get; set; }
        public string OperationalCategorization { get; set; }
        public string Pod { get; set; }
        public Nullable<int> Priority { get; set; }
        public string ProductCategorization { get; set; }
        public string PwdNotCatAsPwd { get; set; }
        public string ReportedSource { get; set; }
        public string Resolution { get; set; }
        public string ResolutionCategorization { get; set; }
        public string ResolverGroupLevel { get; set; }
        public string ServiceDesk { get; set; }
        public string Status { get; set; }
        public string StatusGroup { get; set; }
        public string StatusReason { get; set; }
        public string Submitter { get; set; }
        public Nullable<int> SvcDeskOpened { get; set; }
        public Nullable<int> TimeToAcknowledgeSecs { get; set; }
        public Nullable<int> TimeToResolveSecs { get; set; }
        public string TimeToResolveHours { get; set; }
        public string TimeToResolveOver2Hours { get; set; }
        public string Vip { get; set; }
        public int AccountKey { get; set; }
        public int AccountRegionIndustryKey { get; set; }
        public int AccountRegionKey { get; set; }
        public int AgentKey { get; set; }
        public int CauseCodeKey { get; set; }
        public int ContactSourceKey { get; set; }
        public int DeliveryRegionKey { get; set; }
        public int IndustryKey { get; set; }
        public int OpCatKey { get; set; }
        public int PriorityKey { get; set; }
        public int ProdCatKey { get; set; }
        public int QueueKey { get; set; }
        public int ResCatKey { get; set; }
        public int ServiceDeskKey { get; set; }
        public int SourceOdsKey { get; set; }
        public int StatusKey { get; set; }
        public int SubjectTypeKey { get; set; }
        public int TimeIntervalKey { get; set; }
        public int VipKey { get; set; }
    }
}
