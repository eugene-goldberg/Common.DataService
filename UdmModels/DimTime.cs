using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CommonDataService.Models
{
    public partial class DimTime
    {
        [Key]
        public int DateKey { get; set; }
        public Nullable<System.DateTime> FullDate { get; set; }
        public string DateName { get; set; }
        public Nullable<System.DateTime> Year { get; set; }
        public string YearName { get; set; }
        public Nullable<System.DateTime> Quarter { get; set; }
        public string QuarterName { get; set; }
        public Nullable<System.DateTime> Month { get; set; }
        public string MonthName { get; set; }
        public Nullable<System.DateTime> Week { get; set; }
        public string WeekName { get; set; }
        public Nullable<int> DayOfYear { get; set; }
        public string DayOfYearName { get; set; }
        public Nullable<int> DayOfQuarter { get; set; }
        public string DayOfQuarterName { get; set; }
        public Nullable<int> DayOfMonth { get; set; }
        public string DayOfMonthName { get; set; }
        public Nullable<int> DayOfWeek { get; set; }
        public string DayOfWeekName { get; set; }
        public Nullable<int> WeekOfYear { get; set; }
        public string WeekOfYearName { get; set; }
        public Nullable<int> MonthOfYear { get; set; }
        public string MonthOfYearName { get; set; }
        public Nullable<int> MonthOfQuarter { get; set; }
        public string MonthOfQuarterName { get; set; }
        public Nullable<int> QuarterOfYear { get; set; }
        public string QuarterOfYearName { get; set; }
    }
}
