using System.Data.Entity;
using TestDnn.Infrastructure.Data.Mappings;

namespace TestDnn.Infrastructure.Data
{
    public class MainDbContext : DbContext
    {
        public MainDbContext(string connectionString) : base(connectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new MessageConfiguration());
        }
    }
}
