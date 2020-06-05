using System.Collections.Generic;
using TestDnn.ApplicationServices.Interfaces;
using TestDnn.Domain.Interfaces;
using TestDnn.Domain.MainContext;

namespace TestDnn.ApplicationServices
{
    public class MessageService : IMessageService
    {
        protected IRepository<TestMessage> MessageRepository { get; }

        public MessageService(IRepository<TestMessage> messageRepository)
        {
            MessageRepository = messageRepository;
        }

        public IEnumerable<TestMessage> GetMessages()
        {
            return MessageRepository.Get();
        }
    }
}
