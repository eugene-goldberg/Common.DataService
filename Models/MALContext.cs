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
        public DbSet<AccountProgram> AccountPrograms { get; set; }
        public DbSet<AccountRolePerson> AccountRolePersons { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountTool> AccountTools { get; set; }
        public DbSet<ChangeMeasure> ChangeMeasures { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Program> Programs { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Service> Services { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AccountAliaMap());
            modelBuilder.Configurations.Add(new AccountProgramMap());
            modelBuilder.Configurations.Add(new AccountRolePersonMap());
            modelBuilder.Configurations.Add(new AccountMap());
            modelBuilder.Configurations.Add(new AccountToolMap());
            modelBuilder.Configurations.Add(new ChangeMeasureMap());
            modelBuilder.Configurations.Add(new PersonMap());
            modelBuilder.Configurations.Add(new ProgramMap());
            modelBuilder.Configurations.Add(new RoleMap());
            modelBuilder.Configurations.Add(new ServiceMap());
        }
    }
}
