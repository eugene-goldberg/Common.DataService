using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using CommonDataService.Models.Mapping;

namespace CommonDataService.Models
{
    public partial class MALContext : DbContext
    {
        static MALContext()
        {
            Database.SetInitializer<MALContext>(null);
        }

        public MALContext()
            : base("Name=MALContext")
        {
        }

        public DbSet<AccountAlia> AccountAlias { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountTool> AccountTools { get; set; }
        public DbSet<ChangeMeasure> ChangeMeasures { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AccountAliaMap());
            modelBuilder.Configurations.Add(new AccountMap());
            modelBuilder.Configurations.Add(new AccountToolMap());
            modelBuilder.Configurations.Add(new ChangeMeasureMap());
        }
    }
}
