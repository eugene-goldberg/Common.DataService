using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using CommonDataService.Models.Mapping;

namespace CommonDataService.Models
{
    public partial class UDMContext : DbContext
    {
        static UDMContext()
        {
            Database.SetInitializer<UDMContext>(null);
        }

        public UDMContext()
            : base("Name=UDMContext")
        {
        }

        public DbSet<DimAccount> DimAccounts { get; set; }
        public DbSet<DimAgent> DimAgents { get; set; }
        public DbSet<DimCauseCode> DimCauseCodes { get; set; }
        public DbSet<DimContactSource> DimContactSources { get; set; }
        public DbSet<DimDtlIncidentDay> DimDtlIncidentDays { get; set; }
        public DbSet<DimDtlIncidentMonth> DimDtlIncidentMonths { get; set; }
        public DbSet<DimDtlIncidentMTD> DimDtlIncidentMTDs { get; set; }
        public DbSet<DimDtlIncidentWeek> DimDtlIncidentWeeks { get; set; }
        public DbSet<DimIndustry> DimIndustries { get; set; }
        public DbSet<DimMetric> DimMetrics { get; set; }
        public DbSet<DimOpCat> DimOpCats { get; set; }
        public DbSet<DimPriority> DimPriorities { get; set; }
        public DbSet<DimProdCat> DimProdCats { get; set; }
        public DbSet<DimQueue> DimQueues { get; set; }
        public DbSet<DimRegion> DimRegions { get; set; }
        public DbSet<DimRegionIndustry> DimRegionIndustries { get; set; }
        public DbSet<DimResCat> DimResCats { get; set; }
        public DbSet<DimServiceDesk> DimServiceDesks { get; set; }
        public DbSet<DimSourceOd> DimSourceOds { get; set; }
        public DbSet<DimStatu> DimStatus { get; set; }
        public DbSet<DimSubjectType> DimSubjectTypes { get; set; }
        public DbSet<DimTime> DimTimes { get; set; }
        public DbSet<DimTimeInterval> DimTimeIntervals { get; set; }
        public DbSet<DimVip> DimVips { get; set; }
        public DbSet<Fact> Facts { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DimAccountMap());
            modelBuilder.Configurations.Add(new DimAgentMap());
            modelBuilder.Configurations.Add(new DimCauseCodeMap());
            modelBuilder.Configurations.Add(new DimContactSourceMap());
            modelBuilder.Configurations.Add(new DimDtlIncidentDayMap());
            modelBuilder.Configurations.Add(new DimDtlIncidentMonthMap());
            modelBuilder.Configurations.Add(new DimDtlIncidentMTDMap());
            modelBuilder.Configurations.Add(new DimDtlIncidentWeekMap());
            modelBuilder.Configurations.Add(new DimIndustryMap());
            modelBuilder.Configurations.Add(new DimMetricMap());
            modelBuilder.Configurations.Add(new DimOpCatMap());
            modelBuilder.Configurations.Add(new DimPriorityMap());
            modelBuilder.Configurations.Add(new DimProdCatMap());
            modelBuilder.Configurations.Add(new DimQueueMap());
            modelBuilder.Configurations.Add(new DimRegionMap());
            modelBuilder.Configurations.Add(new DimRegionIndustryMap());
            modelBuilder.Configurations.Add(new DimResCatMap());
            modelBuilder.Configurations.Add(new DimServiceDeskMap());
            modelBuilder.Configurations.Add(new DimSourceOdMap());
            modelBuilder.Configurations.Add(new DimStatuMap());
            modelBuilder.Configurations.Add(new DimSubjectTypeMap());
            modelBuilder.Configurations.Add(new DimTimeMap());
            modelBuilder.Configurations.Add(new DimTimeIntervalMap());
            modelBuilder.Configurations.Add(new DimVipMap());
            modelBuilder.Configurations.Add(new FactMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
        }
    }
}
