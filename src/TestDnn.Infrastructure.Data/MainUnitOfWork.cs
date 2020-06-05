using TestDnn.Domain.Interfaces;
using TestDnn.Domain.MainContext;

namespace TestDnn.Infrastructure.Data
{
    public class MainUnitOfWork : IUnitOfWork
    {
        protected MainDbContext DbContext { get; }

        public MainUnitOfWork(MainDbContext dbContext)
        {
            DbContext = dbContext;
        }

        private IRepository<TestMessage> _messageRepository;
        protected IRepository<TestMessage> MessageRepository
        {
            get
            {
                if (_messageRepository == null)
                {
                    _messageRepository = new GenericRepository<TestMessage>(DbContext);
                }
                return _messageRepository;
            }
        }

        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}
