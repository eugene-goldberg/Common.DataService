using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CommonDataService.Models
{
    public partial class Fact
    {
        [Key]
        public int AccountKey { get; set; }
        public int AccountRegionIndustryKey { get; set; }
        public int AccountRegionKey { get; set; }
        public int AgentKey { get; set; }
        public int CauseCodeKey { get; set; }
        public int ContactSourceKey { get; set; }
        public int DeliveryRegionKey { get; set; }
        public int IndustryKey { get; set; }
        public int MetricKey { get; set; }
        public int PeriodKey { get; set; }
        public int PriorityKey { get; set; }
        public int QueueKey { get; set; }
        public int ServiceDeskKey { get; set; }
        public int SourceOdsKey { get; set; }
        public int StatusKey { get; set; }
        public int SubjectTypeKey { get; set; }
        public int TimeIntervalKey { get; set; }
        public int VipKey { get; set; }
        public Nullable<double> Actual1Sum { get; set; }
        public Nullable<double> Actual2Sum { get; set; }
        public Nullable<double> Actual3Sum { get; set; }
    }
}
