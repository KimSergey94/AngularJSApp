using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AngularApp.Models.EF
{
    public class AngularAppDbContext : DbContext
    {
        public AngularAppDbContext() : base("name = AngularAppDbContext")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }
    }
}