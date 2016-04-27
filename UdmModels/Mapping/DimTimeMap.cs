using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CommonDataService.Models.Mapping
{
    public class DimTimeMap : EntityTypeConfiguration<DimTime>
    {
        public DimTimeMap()
        {
            // Primary Key
            this.HasKey(t => t.DateKey);

            // Properties
            this.Property(t => t.DateKey)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DateName)
                .HasMaxLength(50);

            this.Property(t => t.YearName)
                .HasMaxLength(50);

            this.Property(t => t.QuarterName)
                .HasMaxLength(50);

            this.Property(t => t.MonthName)
                .HasMaxLength(50);

            this.Property(t => t.WeekName)
                .HasMaxLength(50);

            this.Property(t => t.DayOfYearName)
                .HasMaxLength(50);

            this.Property(t => t.DayOfQuarterName)
                .HasMaxLength(50);

            this.Property(t => t.DayOfMonthName)
                .HasMaxLength(50);

            this.Property(t => t.DayOfWeekName)
                .HasMaxLength(50);

            this.Property(t => t.WeekOfYearName)
                .HasMaxLength(50);

            this.Property(t => t.MonthOfYearName)
                .HasMaxLength(50);

            this.Property(t => t.MonthOfQuarterName)
                .HasMaxLength(50);

            this.Property(t => t.QuarterOfYearName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DimTime");
            this.Property(t => t.DateKey).HasColumnName("DateKey");
            this.Property(t => t.FullDate).HasColumnName("FullDate");
            this.Property(t => t.DateName).HasColumnName("DateName");
            this.Property(t => t.Year).HasColumnName("Year");
            this.Property(t => t.YearName).HasColumnName("YearName");
            this.Property(t => t.Quarter).HasColumnName("Quarter");
            this.Property(t => t.QuarterName).HasColumnName("QuarterName");
            this.Property(t => t.Month).HasColumnName("Month");
            this.Property(t => t.MonthName).HasColumnName("MonthName");
            this.Property(t => t.Week).HasColumnName("Week");
            this.Property(t => t.WeekName).HasColumnName("WeekName");
            this.Property(t => t.DayOfYear).HasColumnName("DayOfYear");
            this.Property(t => t.DayOfYearName).HasColumnName("DayOfYearName");
            this.Property(t => t.DayOfQuarter).HasColumnName("DayOfQuarter");
            this.Property(t => t.DayOfQuarterName).HasColumnName("DayOfQuarterName");
            this.Property(t => t.DayOfMonth).HasColumnName("DayOfMonth");
            this.Property(t => t.DayOfMonthName).HasColumnName("DayOfMonthName");
            this.Property(t => t.DayOfWeek).HasColumnName("DayOfWeek");
            this.Property(t => t.DayOfWeekName).HasColumnName("DayOfWeekName");
            this.Property(t => t.WeekOfYear).HasColumnName("WeekOfYear");
            this.Property(t => t.WeekOfYearName).HasColumnName("WeekOfYearName");
            this.Property(t => t.MonthOfYear).HasColumnName("MonthOfYear");
            this.Property(t => t.MonthOfYearName).HasColumnName("MonthOfYearName");
            this.Property(t => t.MonthOfQuarter).HasColumnName("MonthOfQuarter");
            this.Property(t => t.MonthOfQuarterName).HasColumnName("MonthOfQuarterName");
            this.Property(t => t.QuarterOfYear).HasColumnName("QuarterOfYear");
            this.Property(t => t.QuarterOfYearName).HasColumnName("QuarterOfYearName");
        }
    }
}
