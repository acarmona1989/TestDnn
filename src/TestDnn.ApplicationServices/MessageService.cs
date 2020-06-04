using System.Collections.Generic;
using TestDnn.ApplicationServices.Interfaces;
using TestDnn.Domain.Interfaces;
using TestDnn.Domain.MainContext;

namespace TestDnn.ApplicationServices
{
    public class MessageService : IMessageService
    {
        protected IRepository<Message> MessageRepository { get; }

        public MessageService(IRepository<Message> messageRepository)
        {
            MessageRepository = messageRepository;
        }

        public IEnumerable<Message> GetMessages()
        {
            return MessageRepository.GetAll();
        }
    }
}
