using System.Collections.Generic;
using TestDnn.Domain.Interfaces;
using TestDnn.Domain.MainContext;

namespace TestDnn.Infrastructure.Data
{
    public class MessageRepository : IRepository<Message>
    {
        private List<Message> Messages { get; }

        public MessageRepository()
        {
            Messages = new List<Message>
            {
                new Message
                {
                    Content = "Content1"
                },
                new Message
                {
                    Content = "Content2"
                },
                new Message
                {
                    Content = "Content2"
                },
            };
        }

        public IEnumerable<Message> GetAll()
        {
            return Messages;
        }
    }
}
