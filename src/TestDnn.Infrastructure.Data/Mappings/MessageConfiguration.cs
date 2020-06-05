using System.Data.Entity.ModelConfiguration;
using TestDnn.Domain.MainContext;

namespace TestDnn.Infrastructure.Data.Mappings
{
    public class MessageConfiguration : EntityTypeConfiguration<TestMessage>
    {
        public MessageConfiguration()
        {
            ToTable("Messages");
            HasKey(x => x.Id);
        }
    }
}
